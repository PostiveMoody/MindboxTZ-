USE MindBoxTest;

CREATE SCHEMA MINDGAME;

CREATE TABLE MINDGAME.PRODUCT
(
 ProductID int IDENTITY (1,1) NOT NULL,
 PName varchar(150) not null,
 PCost money not null,
 PCategoryName varchar(150) null,
 PBrand varchar(100) null,
 PDescription varchar(200) null,

 CONSTRAINT PK_PRODUCT_PRODUCTID PRIMARY KEY CLUSTERED (ProductID)
 );

INSERT INTO MindBoxTest.MINDGAME.PRODUCT VALUES ('WD20EZBX', 17152, 'Hard disk', 'Western Digital','Cool');
INSERT INTO MindBoxTest.MINDGAME.PRODUCT VALUES ('A400SA400S37', 31455, 'SSD', 'Kingston','Cooool');
INSERT INTO MindBoxTest.MINDGAME.PRODUCT VALUES ('Ryzen 5 5600', 14859, 'CPU', 'AMD ','Gooood');
INSERT INTO MindBoxTest.MINDGAME.PRODUCT VALUES ('Ryzen 7 5600', 24859, 'CPU', 'AMD ','Gooood');

CREATE TABLE MINDGAME.CATEGORY
(
CategoryID int IDENTITY (1,1) NOT NULL,
CName varchar(150) not null,

CONSTRAINT PK_CATEGORY_CategoryID PRIMARY KEY CLUSTERED (CategoryID)
);
INSERT INTO MindBoxTest.MINDGAME.CATEGORY VALUES ('Memory');
INSERT INTO MindBoxTest.MINDGAME.CATEGORY VALUES ('CPU');
INSERT INTO MindBoxTest.MINDGAME.CATEGORY VALUES ('Monitor');
INSERT INTO MindBoxTest.MINDGAME.CATEGORY VALUES ('Disk');

CREATE TABLE MINDGAME.PRODUCTCATEGORIES
(
ProductID INT NOT NULL,
CategoryID INT NOT NULL

);

INSERT INTO MindBoxTest.MINDGAME.PRODUCTCATEGORIES VALUES (1,1);
INSERT INTO MindBoxTest.MINDGAME.PRODUCTCATEGORIES VALUES (1,4);
INSERT INTO MindBoxTest.MINDGAME.PRODUCTCATEGORIES VALUES (2,1);
INSERT INTO MindBoxTest.MINDGAME.PRODUCTCATEGORIES VALUES (2,4);
INSERT INTO MindBoxTest.MINDGAME.PRODUCTCATEGORIES VALUES (3,2);

select MMP.PName, MMC.CName from MindBoxTest.MINDGAME.PRODUCT MMP
LEFT JOIN MindBoxTest.MINDGAME.PRODUCTCATEGORIES MMPC ON MMP.ProductID = MMPC.ProductID
LEFT JOIN MindBoxTest.MINDGAME.CATEGORY MMC ON MMC.CategoryID = MMPC.CategoryID


