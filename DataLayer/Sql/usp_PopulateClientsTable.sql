alter procedure usp_PopulateClientsTable
as
begin

delete from client

create table #client
(
	name varchar(50)
);

declare @i int = 0
declare @name varchar(50)

while @i < 15
begin
	 
	set @name = CONCAT('Client-', FLOOR(rand()*10000))
	insert into #client select @name

	set @i = @i + 1
end

insert into client
select name from #client

select * from #client

end