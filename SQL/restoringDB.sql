--RESTORE FILELISTONLY 
--FROM DISK = 'D:\cursoWeb\PruebaPracticaGB\BAK\AdventureWorks2014.bak'

USE MASTER
GO
RESTORE DATABASE AdventureWorks
FROM DISK = 'D:\cursoWeb\PruebaPracticaGB\BAK\AdventureWorks2014.bak'
WITH REPLACE,
MOVE 'AdventureWorks2014_Data' TO 'D:\cursoWeb\PruebaPracticaGB\BAK\AdventureWorks2014.mdf',
MOVE 'AdventureWorks2014_Log' TO 'D:\cursoWeb\PruebaPracticaGB\BAK\AdventureWorks2014.ldf'



