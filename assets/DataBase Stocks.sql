
CREATE DATABASE ApkDatabaseStocks;
GO
USE ApkDatabaseStocks;

-- Tabel Users
CREATE TABLE Users (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nama VARCHAR(50),
    Email VARCHAR(50),
    Password VARCHAR(255)
);

-- Tabel Customers
CREATE TABLE Customers (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nama VARCHAR(50),
    Email VARCHAR(45),
    NomorTelepon VARCHAR(20)
);

-- Tabel Products
CREATE TABLE Products (
    KodeBarang INT IDENTITY(1,1) PRIMARY KEY,
    NamaBarang VARCHAR(50),
    Harga FLOAT,
    MerekBarang VARCHAR(45)
);

-- Tabel Orders
CREATE TABLE Orders (
    PembelianBarangID INT IDENTITY(1,1) PRIMARY KEY,
    TanggalOrders DATETIME,
    Harga FLOAT
);

-- Tabel Purchase
CREATE TABLE Purchase (
    PenjualanBarangID INT IDENTITY(1,1) PRIMARY KEY,
    TanggalPembelian DATETIME,
    Harga FLOAT
);

-- Tabel Suppliers
CREATE TABLE Suppliers (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Nama VARCHAR(45),
    NomorTelepon VARCHAR(20),
    Email VARCHAR(45)
);

-- Tabel DetailOrders
CREATE TABLE DetailOrders (
    PencatatanPenjualanBarang INT IDENTITY(1,1) PRIMARY KEY,
    KuantitasBarang INT,
    HargaSatuan INT,
    Orders_PembelianBarangID INT,
    FOREIGN KEY (Orders_PembelianBarangID) REFERENCES Orders(PembelianBarangID)
);

-- Tabel DetailPurchases
CREATE TABLE DetailPurchases (
    PencatatanPembelianBarang INT IDENTITY(1,1) PRIMARY KEY,
    KuantitasBarang INT,
    HargaSatuan INT,
    Purchase_PenjualanBarangID INT,
    FOREIGN KEY (Purchase_PenjualanBarangID) REFERENCES Purchase(PenjualanBarangID)
);

-- Tabel InventoryStock_has_Orders (relasi many-to-many)
CREATE TABLE InventoryStock_has_Orders (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Orders_PembelianBarangID INT,
    Customers_ID INT,
    Products_KodeBarang INT,
    FOREIGN KEY (Orders_PembelianBarangID) REFERENCES Orders(PembelianBarangID),
    FOREIGN KEY (Customers_ID) REFERENCES Customers(ID),
    FOREIGN KEY (Products_KodeBarang) REFERENCES Products(KodeBarang)
);

-- Tabel Products_has_Purchase (relasi many-to-many)
CREATE TABLE Products_has_Purchase (
    Products_KodeBarang INT,
    Purchase_PenjualanBarangID INT,
    FOREIGN KEY (Products_KodeBarang) REFERENCES Products(KodeBarang),
    FOREIGN KEY (Purchase_PenjualanBarangID) REFERENCES Purchase(PenjualanBarangID)
);

-- Tabel Suppliers_has_Purchase (relasi many-to-many)
CREATE TABLE Suppliers_has_Purchase (
    Suppliers_ID INT,
    Purchase_PenjualanBarangID INT,
    FOREIGN KEY (Suppliers_ID) REFERENCES Suppliers(ID),
    FOREIGN KEY (Purchase_PenjualanBarangID) REFERENCES Purchase(PenjualanBarangID)
);

Insert Into insert into Products
(NamaBarang, Harga, MerekBarang)

    values
    ('Laptop','24000000','MacBook')
    ,('Laptop','12000000','Lenovo')
    ,('Laptop','25500000','Legion')
    ,('Laptop','16000000','LOQ')
    ,('Laptop','10000000','ThinkPad')
    ,('Laptop','1250000','Asus')    
    ,('Laptop','25800000','Asus ROG')
    ,('Laptop','16500000','Asus TUF')
    ,('Laptop','8000000','HP')
    ,('Laptop','10000000','Omen')
    ,('Laptop','12500000','Victus')
    ,('Laptop','13000000','MSI')
    ,('Laptop','10000000','Acer')
    ,('Laptop','14000000','Predator')
    ,('Laptop','7000000','Infinix')
    ,('Laptop','18000000','Predator')
    ,('Laptop','6000000','Dell')
    ,('Laptop','4000000','Google Pixel')
    ,('Laptop','6000000','Advan')
    ,('Laptop','8000000','Axio')

Insert Into Customers
(Nama, Email, NomorTelepon)

    values
    ('Justyn','justyn@gmail.com','087612345612')
    ,('Owen','owen@gmail.com','082167345098')
    ,('Felix','felix@gmail.com','080987612345')
    ,('William','william@gmail.com','080451236781')
    ,('Richard','richard@gmail.com','087512346890')
    ,('Jesse','jesse@gmail.com','087845761234')
    ,('David','david@gmail.com','081234567890')
    ,('Jhon','jhon@gmail.com','080987654321')
    ,('Amanda','amanda@gmail.com','085432167890')
    ,('Becca','becca@gmail.com','087571344580')

Insert Into Suppliers
(Nama, NomorTelepon, Email)

    values
    ('Filbert','084567123567','fil@gmail.com')
    ,('Caroline','089672345189','caroline@gmail.com')
    ,('Nora','081357901234','nora@gmail.com')
    ,('Naomi','082468009876','naomi@gmail.com')
    ,('Peter','087271456310','peter@gmail.com')
    ,('Dennis','081726354123','dennis@gmail.com')
    ,('Angeline','084567987612','angeline@gmail.com')
    ,('Vinny','087645328901','vinny@gmail.com')
    ,('Edward','087545671920','edward@gmail.com')
    ,('Mita','0875458912098','mita@gmail.com')
