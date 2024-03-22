DROP DATABASE HoTroGiangVien
use HoTroGiangVien

CREATE TABLE TaiKhoan(
id VARCHAR(255) PRIMARY KEY,
mk VARCHAR(255));

go
CREATE PROC proc_logic
@user varchar(255),
@pass varchar(255)
as
begin
	select * from TaiKhoan where id=@user and mk=@pass
end
go;
CREATE TABLE Users (
    user_id INT PRIMARY KEY IDENTITY,
    id VARCHAR(255) FOREIGN KEY REFERENCES TaiKhoan(id),
    email NVARCHAR(100) UNIQUE NOT NULL,
    full_name NVARCHAR(100),
    phone_number NVARCHAR(20),
    address NVARCHAR(255),
	sohd VARCHAR(255),
	ngayhethan DATE

);



-- Tạo bảng Lịch dạy
CREATE TABLE TeachingSchedule (
    schedule_id INT PRIMARY KEY IDENTITY,
    user_id INT FOREIGN KEY REFERENCES Users(user_id),
    date DATE NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    baovang BIT NOT NULL
);


-- Tạo bảng Tính lương
CREATE TABLE SalaryCalculations (
    calculation_id INT PRIMARY KEY IDENTITY,
    user_id INT FOREIGN KEY REFERENCES Users(user_id),
    month DATE NOT NULL,
    total_hours DECIMAL(10, 2) NOT NULL,
    total_earnings DECIMAL(10, 2) NOT NULL
);

-- Tạo bảng Quản lý phiên
CREATE TABLE SessionManagement (
    session_id INT PRIMARY KEY IDENTITY,
    user_id INT FOREIGN KEY REFERENCES Users(user_id),
    token NVARCHAR(255) NOT NULL,
    expiration_time DATETIME NOT NULL
);
INSERT INTO TaiKhoan (id, mk) VALUES ('52200123', '123');
INSERT INTO Users (id, email, full_name, phone_number, address, sohd, ngayhethan)
VALUES ('52200123', '52200123', 'Trịnh lê tuyết nhung', '123456789', 'quận 7', '1231135', '2024-03-08');
