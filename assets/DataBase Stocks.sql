
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
