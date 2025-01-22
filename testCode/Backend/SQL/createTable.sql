CREATE DATABASE Bank_Mega_Database;
GO

USE Bank_Mega_Database;

CREATE TABLE ms_storage_location (
    location_id VARCHAR(10) PRIMARY KEY,
    location_name VARCHAR(100) NOT NULL
);


CREATE TABLE ms_user (
    user_id BIGINT PRIMARY KEY,
    user_name VARCHAR(20) NOT NULL,
    password VARCHAR(50) NOT NULL, 
    is_active BIT NOT NULL
);

CREATE TABLE tr_bpkb (
    agreement_number VARCHAR(100) PRIMARY KEY,
    bpkb_no VARCHAR(100) NOT NULL,
    branch_id VARCHAR(10) NOT NULL,
    bpkb_date DATETIME NOT NULL,
    faktur_no VARCHAR(100) NOT NULL,
    faktur_date DATETIME NOT NULL,
    location_id VARCHAR(10) NOT NULL,
    police_no VARCHAR(20) NOT NULL,
    bpkb_date_in DATETIME NOT NULL,
    created_by VARCHAR(20) NOT NULL,
    created_on DATETIME NOT NULL,
    last_updated_by VARCHAR(20),
    last_updated_on DATETIME,
    FOREIGN KEY (location_id) REFERENCES ms_storage_location(location_id)
);

