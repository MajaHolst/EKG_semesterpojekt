--Create table PhysioNet(
--PNID int IDENTiTY(1,1) Primary key,
--PNData varbinary(max));


--create table MeasuredData(
--MeasuringID int IDENTiTY(1,1) Primary key,
--CPR nvarchar (11),
--measuringDate DateTime,
--measurement varbinary(max));


--drop table #temp
--create table #temp(
--PNData varbinary(max),
--DataNumber int);

--insert into PhysioNet
--SELECT BulkColumn
--from openrowset(Bulk 'C:\Users\majah\OneDrive\Dokumenter\GitHub\EKG_semesterpojekt\ClassLibrary1\EKG-signal-fra-physionet-AFIB.txt', SINGLE_BLOB ) AS BLOB

