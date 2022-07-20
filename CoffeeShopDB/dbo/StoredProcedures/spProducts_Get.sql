CREATE PROCEDURE [dbo].[spProducts_Get]
	@Id int
AS
begin
	SELECT * from Products
	where Id = @Id;
end
