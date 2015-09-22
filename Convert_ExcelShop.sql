-- --------------------------------------------------------------------------------
-- Routine DDL
-- Note: comments before and after the routine body will not be stored by the server
-- --------------------------------------------------------------------------------
DELIMITER $$

CREATE DEFINER=`root`@`localhost` PROCEDURE `Convert_ExcelShop`(

in Content varchar(300),

in Filename varchar(40)
)
BEGIN

Drop Temporary Table if Exists Sales, Payments;

CREATE TEMPORARY TABLE Sales(
  `idSales_n_Returns` int(11) NOT NULL AUTO_INCREMENT,
  `Report_Type` char(3) NOT NULL DEFAULT '0',
  `Item_No` char(2) NOT NULL,
  `Transaction_id` int(11) NOT NULL,
  `Category_id` char(8) NOT NULL,
  `Extended_Sales_Price` decimal(9,3) NOT NULL,
  `Original_Amount` decimal(9,3) NOT NULL,
  `Extended_VAT` decimal(9,5) NOT NULL,
  `Mark_Down_Indicator` decimal(9,5) NOT NULL,
  `Sales_Mode` char(4) NOT NULL,
  `Product_EAN_Code` char(16) NOT NULL,
  `Product_ID` int(11) NOT NULL,
  `Product_Description` char(24) NOT NULL,
  `Quantity` decimal(9,3) NOT NULL,
  `Unit_Sales_Price` decimal(9,3) NOT NULL,
  `Unit_VAT` decimal(9,5) NOT NULL,
   PRIMARY KEY (`idSales_n_Returns`)
   ) ENGINE=MyISAM AUTO_INCREMENT=5596 DEFAULT CHARSET=utf8 COMMENT='station name';

CREATE TEMPORARY TABLE `payments` (
  `idPayments` int(11) NOT NULL AUTO_INCREMENT,
  `Report_Type` char(3) NOT NULL DEFAULT '0',
  `Item_No` char(2) NOT NULL,
  `Transaction_ID` char(7) NOT NULL,
  `Method_Of_Payment` char(4) NOT NULL,
  `MOP_Description` char(6) DEFAULT NULL,
  `PAN` char(6) DEFAULT NULL,
  `Transaction_Currency` char(3) NOT NULL,
  `Transaction_Amount` decimal(9,3) NOT NULL,
  `Transaction_Amount_Home` decimal(9,3) NOT NULL,
   PRIMARY KEY (`idPayments`)
  ) ENGINE=MyISAM AUTO_INCREMENT=5596 DEFAULT CHARSET=utf8 COMMENT='station name';

  Set @Station_id = Mid(Filename, 14, 3);

  Select @Station_id;

select Left(Content, 3);

 Case Left(Content, 3) 

When 000 Then

 Insert into file_header (Report_Type, Country_Code, Site_ID, 

Incremental_Counter, File_Type, Business_Day, Start_Date, 

Start_Time, End_Date, End_Time, File_Name)

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

SPLIT_STR(Content, '|', 10) , Filename); 

When 500 Then

insert into ticket_header (Report_Type, Transaction_Date, Transaction_Start_Time, Transaction_id, Sales_Operator, POS_ID, Ticket_Total, File_Name) 

 values ( 
 
SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

SPLIT_STR(Content, '|', 5) ,

SPLIT_STR(Content, '|', 6) ,

SPLIT_STR(Content, '|', 7) , Filename); 

When 501 Then

insert into sales (File_Name) Values (Filename);

insert into sales (Report_Type,  Item_No, Transaction_id, Category_id, Extended_Sales_Price, Original_Amount, Extended_VAT, Mark_Down_Indicator, Sales_Mode, Product_EAN_Code, Product_ID, Product_Description, Quantity, Unit_Sales_Price, Unit_VAT, File_Name)

 Values ( 

SPLIT_STR(Content, '|', 1) ,
 
SPLIT_STR(Content, '|', 2) ,

SPLIT_STR(Content, '|', 3) ,

SPLIT_STR(Content, '|', 4) ,

Cast(SPLIT_STR(Content, '|', 5) as Decimal(9,3)),

 Cast(SPLIT_STR(Content, '|', 6) as Decimal(9,3)),

 Cast(SPLIT_STR(Content, '|', 7) as Decimal(9,5)),

 Cast(SPLIT_STR(Content, '|', 8) as Decimal(9,5)),

 SPLIT_STR(Content, '|', 9) ,

 SPLIT_STR(Content, '|', 10) ,

 SPLIT_STR(Content, '|', 11) ,

 SPLIT_STR(Content, '|', 12) ,

 Cast(SPLIT_STR(Content, '|', 13) as Decimal(9,3)) ,

 Cast(SPLIT_STR(Content, '|', 14)  as Decimal(9,3)) ,

 Cast(SPLIT_STR(Content, '|', 15)  as Decimal(9,5)),

 filename); 




else

select Left(Content, 3)  ;
 
End Case;


END
