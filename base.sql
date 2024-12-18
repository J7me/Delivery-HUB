 
USE [DeliveryHUB]
GO
/****** Object:  Table [dbo].[Administrators]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrators](
	[AdministratorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[PickupPointID] [int] NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK__Administ__ACDEFE33638407D4] PRIMARY KEY CLUSTERED 
(
	[AdministratorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__Customer__A4AE64B8D46A7BC3] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery](
	[DeliveryID] [int] IDENTITY(1,1) NOT NULL,
	[PickupPointID] [int] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK__Delivery__626D8FEE501664AE] PRIMARY KEY CLUSTERED 
(
	[DeliveryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IssueStatuses]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IssueStatuses](
	[IssueStatusID] [int] NOT NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_IssueStatuses] PRIMARY KEY CLUSTERED 
(
	[IssueStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderIssues]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderIssues](
	[IssueID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[IssueDate] [datetime] NOT NULL,
	[ResolvedDate] [datetime] NOT NULL,
	[IssueStatusID] [int] NOT NULL,
 CONSTRAINT [PK__OrderIss__6C86162473B0153A] PRIMARY KEY CLUSTERED 
(
	[IssueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[OrderItemID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK__OrderIte__57ED06A1E78B1F71] PRIMARY KEY CLUSTERED 
(
	[OrderItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[PickupPointID] [int] NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[PickupDate] [datetime] NOT NULL,
	[Status] [int] NOT NULL,
	[TotalAmount] [decimal](10, 2) NOT NULL,
	[PaymentID] [int] NOT NULL,
 CONSTRAINT [PK__Orders__C3905BAFDB97FC12] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusDescription] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__OrderSta__C8EE20435BE7E54C] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentMethods]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentMethods](
	[PaymentMethodID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentMethod] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PaymentMethods] PRIMARY KEY CLUSTERED 
(
	[PaymentMethodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[Amount] [decimal](10, 2) NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[PaymentMethodID] [int] NOT NULL,
 CONSTRAINT [PK__Payments__9B556A58A33539E5] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PickupPoints]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PickupPoints](
	[PickupPointID] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](10) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK__PickupPo__195D7E803AD72DF5] PRIMARY KEY CLUSTERED 
(
	[PickupPointID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](255) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
	[StockQuantity] [int] NOT NULL,
 CONSTRAINT [PK__Products__B40CC6EDC00314A9] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusesDelivery]    Script Date: 29.11.2024 0:30:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusesDelivery](
	[DeliveryStatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusDelivery] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusesDelivery] PRIMARY KEY CLUSTERED 
(
	[DeliveryStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrators] ON 

INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (1, N'Ivan', N'Ivanov', 1, N'admin', N'Qwerty111')
INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (2, N'Petr', N'Smirnov', 2, N'manager1', N'pass1234')
INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (3, N'Maria', N'Kuznetsova', 3, N'operator1', N'pass1234')
INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (4, N'Alexey', N'Volkov', 1, N'driver1', N'pass1234')
INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (5, N'Olga', N'Lebedeva', 2, N'courier1', N'pass1234')
INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (6, N'Mikhail', N'Sidorov', 3, N'manager2', N'pass1234')
INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (7, N'Elena', N'Morozova', 4, N'operator2', N'pass1234')
INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (8, N'Marina', N'Kozlova', 5, N'courier2', N'pass1234')
INSERT [dbo].[Administrators] ([AdministratorID], [FirstName], [LastName], [PickupPointID], [Login], [Password]) VALUES (9, N'Dmitry', N'Petrov', 1, N'admin2', N'password456')
SET IDENTITY_INSERT [dbo].[Administrators] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (1, N'Ivan', N'Ivanov', N'+71234567890', N'ivanov@example.com', N'Ivan1', N'Ivan1111')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (2, N'Anna', N'Smirnova', N'+79876543210', N'smirnova@example.com', N'Anna2', N'Anna2222')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (3, N'Petr', N'Petrov', N'+79123456789', N'petrov@example.com', N'Petr3', N'Petr3333')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (4, N'Olga', N'Sidorova', N'+79991234567', N'sidorova@example.com', N'Olga4', N'Olga4444')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (5, N'Dmitry', N'Kuznetsov', N'+79811234567', N'kuznetsov@example.com', N'Dmitry5', N'Dmitry555')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (6, N'Elena', N'Morozova', N'+79671234567', N'morozova@example.com', N'Elena6', N'Elena666')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (7, N'Alexey', N'Volkov', N'+79561234567', N'volkov@example.com', N'Alexey7', N'Alexey777')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (8, N'Marina', N'Lebedeva', N'+79451234567', N'lebedeva@example.com', N'Marina8', N'Marina888')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (9, N'Mikhail', N'Kozlov', N'+79341234567', N'kozlov@example.com', N'Mikhail9', N'Mikhail999')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (10, N'Svetochka', N'Popova', N'+79999999999', N'popova@example.com', N'Svetochka10', N'Svetochka10')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (11, N'bobr', N'bobrov', N'777', N'bobo@bo.bo', N'bober', N'bober111')
INSERT [dbo].[Customers] ([CustomerID], [FirstName], [LastName], [Phone], [Email], [Login], [Password]) VALUES (12, N'eed', N'eded', N'ded', N'eded@dd.ru', N'eeeeeeee', N'wdwedw2222')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Delivery] ON 

INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (1, 1, CAST(N'2024-11-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (2, 2, CAST(N'2024-11-11T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (3, 3, CAST(N'2024-11-12T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (4, 4, CAST(N'2024-11-13T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (5, 5, CAST(N'2024-11-14T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (6, 1, CAST(N'2024-11-15T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (7, 2, CAST(N'2024-11-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (8, 3, CAST(N'2024-11-17T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (9, 4, CAST(N'2024-11-18T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (10, 5, CAST(N'2024-11-19T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (12, 1, CAST(N'2024-11-28T22:17:34.197' AS DateTime), 2)
INSERT [dbo].[Delivery] ([DeliveryID], [PickupPointID], [DeliveryDate], [Status]) VALUES (13, 1, CAST(N'2024-11-28T22:41:16.267' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Delivery] OFF
GO
INSERT [dbo].[IssueStatuses] ([IssueStatusID], [Status]) VALUES (1, N'Открыта')
INSERT [dbo].[IssueStatuses] ([IssueStatusID], [Status]) VALUES (2, N'В процессе')
INSERT [dbo].[IssueStatuses] ([IssueStatusID], [Status]) VALUES (3, N'Решена')
INSERT [dbo].[IssueStatuses] ([IssueStatusID], [Status]) VALUES (4, N'Закрыта')
GO
SET IDENTITY_INSERT [dbo].[OrderIssues] ON 

INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (1, 1, N'Product damaged during delivery', CAST(N'2024-11-10T00:00:00.000' AS DateTime), CAST(N'2024-11-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (2, 2, N'Missing items in the order', CAST(N'2024-11-11T00:00:00.000' AS DateTime), CAST(N'2024-11-12T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (3, 3, N'Incorrect product delivered', CAST(N'2024-11-12T00:00:00.000' AS DateTime), CAST(N'2024-11-12T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (4, 4, N'Delivery delayed', CAST(N'2024-11-13T00:00:00.000' AS DateTime), CAST(N'2024-11-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (5, 5, N'Customer requested return', CAST(N'2024-11-14T00:00:00.000' AS DateTime), CAST(N'2024-11-15T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (6, 1, N'Payment issue', CAST(N'2024-11-15T00:00:00.000' AS DateTime), CAST(N'2024-11-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (7, 2, N'Wrong address provided', CAST(N'2024-11-16T00:00:00.000' AS DateTime), CAST(N'2024-11-12T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (8, 3, N'Order cancelled by customer', CAST(N'2024-11-17T00:00:00.000' AS DateTime), CAST(N'2024-11-18T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (9, 4, N'Out of stock', CAST(N'2024-11-18T00:00:00.000' AS DateTime), CAST(N'2024-11-12T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[OrderIssues] ([IssueID], [OrderID], [Description], [IssueDate], [ResolvedDate], [IssueStatusID]) VALUES (10, 5, N'Damage reported by courier', CAST(N'2024-11-19T00:00:00.000' AS DateTime), CAST(N'2024-11-12T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[OrderIssues] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderItems] ON 

INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (1, 1, 1, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (2, 2, 2, 2)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (3, 3, 3, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (4, 4, 4, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (5, 5, 5, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (6, 12, 2, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (7, 13, 5, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (8, 14, 6, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (9, 15, 8, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (10, 16, 1, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (13, 2, 1, 2)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (14, 19, 4, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (16, 1, 1, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (18, 23, 5, 1)
INSERT [dbo].[OrderItems] ([OrderItemID], [OrderID], [ProductID], [Quantity]) VALUES (1010, 25, 5, 1)
SET IDENTITY_INSERT [dbo].[OrderItems] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (1, 1, 1, CAST(N'2021-07-10T00:00:00.000' AS DateTime), CAST(N'2021-07-10T00:00:00.000' AS DateTime), 2, CAST(22222.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (2, 2, 2, CAST(N'2024-11-02T00:00:00.000' AS DateTime), CAST(N'2024-11-06T00:00:00.000' AS DateTime), 2, CAST(59999.99 AS Decimal(10, 2)), 2)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (3, 3, 3, CAST(N'2024-11-03T00:00:00.000' AS DateTime), CAST(N'2024-11-07T00:00:00.000' AS DateTime), 3, CAST(89999.99 AS Decimal(10, 2)), 3)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (4, 4, 4, CAST(N'2024-11-04T00:00:00.000' AS DateTime), CAST(N'2024-11-08T00:00:00.000' AS DateTime), 4, CAST(49999.99 AS Decimal(10, 2)), 4)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (5, 5, 5, CAST(N'2024-11-05T00:00:00.000' AS DateTime), CAST(N'2024-11-09T00:00:00.000' AS DateTime), 5, CAST(29999.99 AS Decimal(10, 2)), 5)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (6, 5, 5, CAST(N'1999-10-10T00:00:00.000' AS DateTime), CAST(N'1999-10-10T00:00:00.000' AS DateTime), 2, CAST(333.00 AS Decimal(10, 2)), 2)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (12, 1, 1, CAST(N'2024-11-25T20:04:27.777' AS DateTime), CAST(N'1999-10-10T00:00:00.000' AS DateTime), 2, CAST(777.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (13, 1, 2, CAST(N'2024-11-25T20:07:36.337' AS DateTime), CAST(N'1999-10-10T00:00:00.000' AS DateTime), 1, CAST(2222.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (14, 1, 2, CAST(N'2024-08-14T20:13:19.000' AS DateTime), CAST(N'2024-08-05T20:13:38.000' AS DateTime), 2, CAST(22121.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (15, 1, 2, CAST(N'2024-11-01T20:18:49.000' AS DateTime), CAST(N'2024-11-25T20:18:56.143' AS DateTime), 1, CAST(22222222.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (16, 2, 2, CAST(N'2024-11-25T21:49:32.243' AS DateTime), CAST(N'2024-11-25T21:49:34.657' AS DateTime), 2, CAST(1212.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (17, 2, 2, CAST(N'2024-10-01T00:00:00.000' AS DateTime), CAST(N'2024-11-25T00:00:00.000' AS DateTime), 2, CAST(8989889.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (18, 2, 1, CAST(N'1999-10-10T00:00:00.000' AS DateTime), CAST(N'1999-10-10T00:00:00.000' AS DateTime), 2, CAST(1111.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (19, 2, 1, CAST(N'1999-10-10T00:00:00.000' AS DateTime), CAST(N'1999-10-10T00:00:00.000' AS DateTime), 1, CAST(22111.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (23, 1, 3, CAST(N'2024-10-01T23:03:43.000' AS DateTime), CAST(N'2024-10-01T23:03:50.000' AS DateTime), 2, CAST(3232.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[Orders] ([OrderID], [CustomerID], [PickupPointID], [OrderDate], [PickupDate], [Status], [TotalAmount], [PaymentID]) VALUES (25, 1, 1, CAST(N'2024-11-29T00:20:10.687' AS DateTime), CAST(N'2024-11-29T00:20:14.830' AS DateTime), 2, CAST(253.00 AS Decimal(10, 2)), 2)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[OrderStatus] ON 

INSERT [dbo].[OrderStatus] ([StatusID], [StatusDescription]) VALUES (1, N'Processing')
INSERT [dbo].[OrderStatus] ([StatusID], [StatusDescription]) VALUES (2, N'Shipped')
INSERT [dbo].[OrderStatus] ([StatusID], [StatusDescription]) VALUES (3, N'Delivered')
INSERT [dbo].[OrderStatus] ([StatusID], [StatusDescription]) VALUES (4, N'Cancelled')
INSERT [dbo].[OrderStatus] ([StatusID], [StatusDescription]) VALUES (5, N'Returned')
SET IDENTITY_INSERT [dbo].[OrderStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[PaymentMethods] ON 

INSERT [dbo].[PaymentMethods] ([PaymentMethodID], [PaymentMethod]) VALUES (1, N'Кредитная карта')
INSERT [dbo].[PaymentMethods] ([PaymentMethodID], [PaymentMethod]) VALUES (2, N'Дебетовая карта')
INSERT [dbo].[PaymentMethods] ([PaymentMethodID], [PaymentMethod]) VALUES (3, N'Электронный кошелек')
INSERT [dbo].[PaymentMethods] ([PaymentMethodID], [PaymentMethod]) VALUES (4, N'Наличные')
INSERT [dbo].[PaymentMethods] ([PaymentMethodID], [PaymentMethod]) VALUES (5, N'Криптовалюта')
SET IDENTITY_INSERT [dbo].[PaymentMethods] OFF
GO
SET IDENTITY_INSERT [dbo].[Payments] ON 

INSERT [dbo].[Payments] ([PaymentID], [PaymentDate], [Amount], [Status], [PaymentMethodID]) VALUES (1, CAST(N'2024-11-01T00:00:00.000' AS DateTime), CAST(129999.99 AS Decimal(10, 2)), N'Success', 1)
INSERT [dbo].[Payments] ([PaymentID], [PaymentDate], [Amount], [Status], [PaymentMethodID]) VALUES (2, CAST(N'2024-11-02T00:00:00.000' AS DateTime), CAST(59999.99 AS Decimal(10, 2)), N'Success', 2)
INSERT [dbo].[Payments] ([PaymentID], [PaymentDate], [Amount], [Status], [PaymentMethodID]) VALUES (3, CAST(N'2024-11-03T00:00:00.000' AS DateTime), CAST(89999.99 AS Decimal(10, 2)), N'Pending', 2)
INSERT [dbo].[Payments] ([PaymentID], [PaymentDate], [Amount], [Status], [PaymentMethodID]) VALUES (4, CAST(N'2024-11-04T00:00:00.000' AS DateTime), CAST(49999.99 AS Decimal(10, 2)), N'Success', 2)
INSERT [dbo].[Payments] ([PaymentID], [PaymentDate], [Amount], [Status], [PaymentMethodID]) VALUES (5, CAST(N'2024-11-05T00:00:00.000' AS DateTime), CAST(29999.99 AS Decimal(10, 2)), N'Success', 2)
SET IDENTITY_INSERT [dbo].[Payments] OFF
GO
SET IDENTITY_INSERT [dbo].[PickupPoints] ON 

INSERT [dbo].[PickupPoints] ([PickupPointID], [Address], [City], [PostalCode], [Phone]) VALUES (1, N'Lenina St, 1', N'Moscow', N'101000', N'+74951234567')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address], [City], [PostalCode], [Phone]) VALUES (2, N'Pushkina St, 10', N'Saint Petersburg', N'190000', N'+78121234567')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address], [City], [PostalCode], [Phone]) VALUES (3, N'Sovetskaya St, 15', N'Novosibirsk', N'630000', N'+73831234567')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address], [City], [PostalCode], [Phone]) VALUES (4, N'Mira Ave, 5', N'Kazan', N'420000', N'+78431234567')
INSERT [dbo].[PickupPoints] ([PickupPointID], [Address], [City], [PostalCode], [Phone]) VALUES (5, N'Pobedy St, 20', N'Yekaterinburg', N'620000', N'+73431234567')
SET IDENTITY_INSERT [dbo].[PickupPoints] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (1, N'Laptop', N'Powerful gaming laptop', CAST(89999.99 AS Decimal(10, 2)), 10)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (2, N'Smartphone', N'Flagship smartphone', CAST(59999.99 AS Decimal(10, 2)), 25)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (3, N'Tablet', N'Compact tablet for work', CAST(29999.99 AS Decimal(10, 2)), 15)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (4, N'Headphones', N'Wireless noise-cancelling headphones', CAST(9999.99 AS Decimal(10, 2)), 50)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (5, N'Camera', N'DSLR camera with lens', CAST(49999.99 AS Decimal(10, 2)), 20)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (6, N'Smartwatch', N'Fitness smartwatch', CAST(19999.99 AS Decimal(10, 2)), 30)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (7, N'Keyboard', N'Mechanical keyboard', CAST(4999.99 AS Decimal(10, 2)), 40)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (8, N'Mouse', N'Gaming mouse', CAST(2999.99 AS Decimal(10, 2)), 60)
INSERT [dbo].[Products] ([ProductID], [Name], [Description], [Price], [StockQuantity]) VALUES (9, N'Monitor', N'4K Ultra HD monitor', CAST(39999.99 AS Decimal(10, 2)), 15)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[StatusesDelivery] ON 

INSERT [dbo].[StatusesDelivery] ([DeliveryStatusID], [StatusDelivery]) VALUES (1, N'In Transit')
INSERT [dbo].[StatusesDelivery] ([DeliveryStatusID], [StatusDelivery]) VALUES (2, N'Delivered')
INSERT [dbo].[StatusesDelivery] ([DeliveryStatusID], [StatusDelivery]) VALUES (3, N'Pending')
INSERT [dbo].[StatusesDelivery] ([DeliveryStatusID], [StatusDelivery]) VALUES (4, N'Cancelled')
INSERT [dbo].[StatusesDelivery] ([DeliveryStatusID], [StatusDelivery]) VALUES (5, N'Returned')
SET IDENTITY_INSERT [dbo].[StatusesDelivery] OFF
GO
ALTER TABLE [dbo].[Administrators]  WITH CHECK ADD  CONSTRAINT [FK_Employees_PickupPoints] FOREIGN KEY([PickupPointID])
REFERENCES [dbo].[PickupPoints] ([PickupPointID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Administrators] CHECK CONSTRAINT [FK_Employees_PickupPoints]
GO
ALTER TABLE [dbo].[Delivery]  WITH CHECK ADD  CONSTRAINT [FK_Delivery_PickupPoints] FOREIGN KEY([PickupPointID])
REFERENCES [dbo].[PickupPoints] ([PickupPointID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Delivery] CHECK CONSTRAINT [FK_Delivery_PickupPoints]
GO
ALTER TABLE [dbo].[Delivery]  WITH CHECK ADD  CONSTRAINT [FK_Delivery_StatusesDelivery] FOREIGN KEY([Status])
REFERENCES [dbo].[StatusesDelivery] ([DeliveryStatusID])
GO
ALTER TABLE [dbo].[Delivery] CHECK CONSTRAINT [FK_Delivery_StatusesDelivery]
GO
ALTER TABLE [dbo].[OrderIssues]  WITH CHECK ADD  CONSTRAINT [FK_OrderIssues_IssueStatuses] FOREIGN KEY([IssueStatusID])
REFERENCES [dbo].[IssueStatuses] ([IssueStatusID])
GO
ALTER TABLE [dbo].[OrderIssues] CHECK CONSTRAINT [FK_OrderIssues_IssueStatuses]
GO
ALTER TABLE [dbo].[OrderIssues]  WITH CHECK ADD  CONSTRAINT [FK_OrderIssues_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderIssues] CHECK CONSTRAINT [FK_OrderIssues_Orders]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Orders]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Products]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_OrderStatus] FOREIGN KEY([Status])
REFERENCES [dbo].[OrderStatus] ([StatusID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_OrderStatus]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Payments] FOREIGN KEY([PaymentID])
REFERENCES [dbo].[Payments] ([PaymentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Payments]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_PickupPoints] FOREIGN KEY([PickupPointID])
REFERENCES [dbo].[PickupPoints] ([PickupPointID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_PickupPoints]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_Payments_PaymentMethods] FOREIGN KEY([PaymentMethodID])
REFERENCES [dbo].[PaymentMethods] ([PaymentMethodID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_Payments_PaymentMethods]
GO
USE [master]
GO
ALTER DATABASE [DeliveryHUB] SET  READ_WRITE 
GO
