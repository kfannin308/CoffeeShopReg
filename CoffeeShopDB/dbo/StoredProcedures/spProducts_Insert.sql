CREATE PROCEDURE [dbo].[spProducts_Insert]
	@Id int,
	@Name nvarchar(20),
	@Description nvarchar(30),
	@Price DECIMAL(10, 2),
	@Category nvarchar(10)
AS
begin
	update Products
	set Name = @Name, Description = @Description, Price = @Price, Category = @Category
	where Id = @Id;
end

