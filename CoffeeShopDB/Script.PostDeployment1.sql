/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (select 1 from Products )
begin
    insert into Products (name, description, price, category)
    values 
    ('expresso', 'Expresso', '4.00', 'drinks'),
    ('latte', 'Latte', '5.00', 'drinks'),
    ('coffee', 'Coffee', '3.00', 'drinks'),
    ('danish', 'Danish', '2.00', 'food items'),
    ('sandwich', 'Breakfast Sandwich', '3.00', 'food items');


end

