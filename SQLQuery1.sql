Create Table Brands(
		Id int primary key identity(1,1),
		BrandName nvarchar (50),

)

Create Table Colors(
		ColorId int primary key identity(1,1),
		ColorName nvarchar (50),

)

Create Table Cars(
		Id int primary key identity (1,1),
		BrandId int,
		ColorId int,
		ModelYear int,
		DailyPrice decimal,
		Descriptions nvarchar (50)
		Foreign key (BrandId) references Brand(BrandId),
		Foreign key (ColorId) references Color(ColorId)
)