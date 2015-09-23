-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Convert_ExcelShop`(

in Content nvarchar(300),

in Filename varchar(50)
)
BEGIN

 Set @Station_id = Mid(Filename, 14, 3);

 Case Left(Content, 3) 

When 000 Then

 Insert into file_header (Report_Type, Country_Code, Site_ID, Incremental_Counter, File_Type, Business_Day, Start_Date, Start_Time, End_Date, End_Time, File_Name)

 values ( 
 
SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

SPLIT_STR(Content, '|', 5) ,

SPLIT_STR(Content, '|', 6) ,

SPLIT_STR(Content, '|', 7) ,

SPLIT_STR(Content, '|', 8) ,

SPLIT_STR(Content, '|', 9) ,

SPLIT_STR(Content, '|', 10) , 

Filename); 

When 500 Then

insert into ticket_header (idFile_Header, Report_Type, Transaction_Date, Transaction_Start_Time, Transaction_id, Sales_Operator, POS_ID, Ticket_Total) 

 values ( 

(Select idFile_Header from File_Header order by idFile_Header desc limit 1),
 
SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

SPLIT_STR(Content, '|', 5) ,

SPLIT_STR(Content, '|', 6) ,

SPLIT_STR(Content, '|', 7)); 

When 501 Then

insert into sales (idFile_Header, Report_Type,  Item_No, Transaction_id, Category_id, Extended_Sales_Price, Original_Amount, Extended_VAT,

 Mark_Down_Indicator, Sales_Mode, Product_EAN_Code, Product_ID,

 Product_Description, Quantity, Unit_Sales_Price, Unit_VAT

)

 Values ( 

(Select idFile_Header from File_Header order by idFile_Header desc limit 1),

SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

SPLIT_STR(Content, '|', 5) ,

SPLIT_STR(Content, '|', 6) ,

SPLIT_STR(Content, '|', 7) ,

SPLIT_STR(Content, '|', 8) ,

 SPLIT_STR(Content, '|', 9) ,

 SPLIT_STR(Content, '|', 10) ,

 SPLIT_STR(Content, '|', 11) ,

 SPLIT_STR(Content, '|', 12) ,

 SPLIT_STR(Content, '|', 13) ,

 SPLIT_STR(Content, '|', 14) ,

 SPLIT_STR(Content, '|', 15)

); 

Insert into ExcelShop (Station_ID, Transaction_Date, Transaction_id, item_no, extended_price, Product_id, quantity, unit_Sales_Price, idfile_header) Values 

(@Station_id, 

(Select Transaction_Date from Ticket_Header Order by idTicket_Header desc limit 1) , 

(Select Transaction_ID from sales Order by idSales_n_Returns desc limit 1)  ,   (Select Item_No from sales Order by idSales_n_Returns desc limit 1), (Select Extended_Sales_Price from sales Order by idSales_n_Returns desc limit 1)   ,(Select Product_ID from sales Order by idSales_n_Returns desc limit 1)  , (Select Quantity from sales Order by idSales_n_Returns desc limit 1) , (Select Unit_Sales_Price from sales Order by idSales_n_Returns desc limit 1) , (Select idFile_Header from File_Header order by idFile_Header desc limit 1)) ;

When 502 Then

insert into sales (idFile_Header, Report_Type,  Item_No, Transaction_id, Category_id, Extended_Sales_Price, Original_Amount, Extended_VAT,

 Mark_Down_Indicator, Sales_Mode, Product_EAN_Code, Product_ID,

 Product_Description, Quantity, Unit_Sales_Price, Unit_VAT

)

 Values ( 

(Select idFile_Header from File_Header order by idFile_Header desc limit 1),

SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

SPLIT_STR(Content, '|', 5) ,

SPLIT_STR(Content, '|', 6) ,

SPLIT_STR(Content, '|', 7) ,

SPLIT_STR(Content, '|', 8) ,

 SPLIT_STR(Content, '|', 9) ,

 SPLIT_STR(Content, '|', 10) ,

 SPLIT_STR(Content, '|', 11) ,

 SPLIT_STR(Content, '|', 12) ,

 SPLIT_STR(Content, '|', 13) ,

 SPLIT_STR(Content, '|', 14) ,

 SPLIT_STR(Content, '|', 15)

); 

Insert into ExcelShop (Station_ID, Transaction_Date, Transaction_id, item_no, extended_price, Product_id, quantity, unit_Sales_Price, idfile_header) Values 

(@Station_id, 

(Select Transaction_Date from Ticket_Header Order by idTicket_Header desc limit 1) , 

(Select Transaction_ID from sales Order by idSales_n_Returns desc limit 1)  ,   (Select Item_No from sales Order by idSales_n_Returns desc limit 1), (Select Extended_Sales_Price from sales Order by idSales_n_Returns desc limit 1)   ,(Select Product_ID from sales Order by idSales_n_Returns desc limit 1)  , (Select Quantity from sales Order by idSales_n_Returns desc limit 1) , (Select Unit_Sales_Price from sales Order by idSales_n_Returns desc limit 1) , (Select idFile_Header from File_Header order by idFile_Header desc limit 1)) ;

When 550 Then

insert into price_correction (idFile_Header, Report_Type,  Item_No, Temp_1, Transaction_ID, Price_Correction_Type, Price_Event_ID, Discount_PAN, Quantity, Amount, Value, VAT_Amount)

Values ( 

(Select idFile_Header from File_Header order by idFile_Header desc limit 1),

SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

SPLIT_STR(Content, '|', 5) ,

SPLIT_STR(Content, '|', 6) ,

SPLIT_STR(Content, '|', 7) ,

SPLIT_STR(Content, '|', 8) ,

 SPLIT_STR(Content, '|', 9) ,

 SPLIT_STR(Content, '|', 10) ,

 SPLIT_STR(Content, '|', 11)

); 

When 600 Then

 insert into payments (idFile_Header, Report_Type,  Item_No, Transaction_ID, Method_Of_Payment, MOP_Description, PAN, Transaction_Currency, Transaction_Amount, Transaction_Amount_Home)

 Values ( 

(Select idFile_Header from File_Header order by idFile_Header desc limit 1),

SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

SPLIT_STR(Content, '|', 5) ,

SPLIT_STR(Content, '|', 6) ,

SPLIT_STR(Content, '|', 7) ,

SPLIT_STR(Content, '|', 8) ,

SPLIT_STR(Content, '|', 9) 

); 

Update ExcelShop 

Set mop = (Select Method_Of_Payment from Payments Order by idPayments desc limit 1) ,  

Transaction_Amount_Home = (Select  Transaction_Amount_Home from Payments Order by idPayments desc limit 1) 

where station_id =  @Station_id  

and idFile_Header = (Select idFile_Header from File_Header order by idFile_Header desc limit 1) 

and transaction_id = (Select transaction_id from Payments Order by idPayments desc limit 1);
 


When 999 Then

   insert into trailer (idFile_Header, Report_Type,  Start_Time, End_Time, Record_Count, Hash_Total_1, Hash_Total_2) 
                              
 Values ( 

(Select idFile_Header from File_Header order by idFile_Header desc limit 1),

SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

SPLIT_STR(Content, '|', 5) ,

SPLIT_STR(Content, '|', 6) 

); 

End Case;


END
