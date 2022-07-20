CREATE PROCEDURE [dbo].[spProducts_Delete]
	@Id int
AS
begin
	DELETE from Products
	where Id = @Id;
end
