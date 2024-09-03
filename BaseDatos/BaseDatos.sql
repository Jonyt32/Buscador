USE [corotos]
GO
/****** Object:  Table [dbo].[Disponibilidad]    Script Date: 2/09/2024 7:54:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Disponibilidad](
	[IdDisponibilidad] [int] IDENTITY(1,1) NOT NULL,
	[IdSede] [int] NOT NULL,
	[IdTipoHabitacion] [int] NOT NULL,
	[MaxCupo] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Disponibilidad] PRIMARY KEY CLUSTERED 
(
	[IdDisponibilidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservas]    Script Date: 2/09/2024 7:54:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservas](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[IdDisponibilidad] [int] NOT NULL,
	[IdTarifa] [int] NOT NULL,
	[NombrePersona] [varchar](100) NOT NULL,
	[FechaInicio] [datetime] NOT NULL,
	[FechaFin] [datetime] NOT NULL,
	[CantidadPersonas] [int] NOT NULL,
 CONSTRAINT [PK_Reservas] PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sedes]    Script Date: 2/09/2024 7:54:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sedes](
	[IdSede] [int] IDENTITY(1,1) NOT NULL,
	[NombreSede] [varchar](50) NULL,
 CONSTRAINT [PK_Sedes] PRIMARY KEY CLUSTERED 
(
	[IdSede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarifas]    Script Date: 2/09/2024 7:54:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarifas](
	[IdTarifa] [int] IDENTITY(1,1) NOT NULL,
	[NonbreTarifa] [varchar](50) NOT NULL,
	[Porcentual] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Tarifas] PRIMARY KEY CLUSTERED 
(
	[IdTarifa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoAlojamiento]    Script Date: 2/09/2024 7:54:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAlojamiento](
	[Id_TipoAlojamiento] [int] IDENTITY(1,1) NOT NULL,
	[NombreAlojamiento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Habitaciones] PRIMARY KEY CLUSTERED 
(
	[Id_TipoAlojamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumentos]    Script Date: 2/09/2024 7:54:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumentos](
	[IdTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](20) NOT NULL,
	[Codigo] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_TipoDocumentos] PRIMARY KEY CLUSTERED 
(
	[IdTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
