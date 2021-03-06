USE [master]
GO
/****** Object:  Database [DBDASS21]    Script Date: 25/06/2022 14:42:25 ******/
CREATE DATABASE [DBDASS21]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBDASS21', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBDASS21.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBDASS21_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DBDASS21_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBDASS21] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBDASS21].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBDASS21] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBDASS21] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBDASS21] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBDASS21] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBDASS21] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBDASS21] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBDASS21] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBDASS21] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBDASS21] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBDASS21] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBDASS21] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBDASS21] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBDASS21] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBDASS21] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBDASS21] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBDASS21] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBDASS21] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBDASS21] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBDASS21] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBDASS21] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBDASS21] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBDASS21] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBDASS21] SET RECOVERY FULL 
GO
ALTER DATABASE [DBDASS21] SET  MULTI_USER 
GO
ALTER DATABASE [DBDASS21] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBDASS21] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBDASS21] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBDASS21] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBDASS21] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBDASS21] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBDASS21', N'ON'
GO
ALTER DATABASE [DBDASS21] SET QUERY_STORE = OFF
GO
USE [DBDASS21]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Ciudades] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Encuesta]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Encuesta](
	[Id] [int] NOT NULL,
	[PacienteId] [int] NOT NULL,
 CONSTRAINT [PK_Encuesta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Eps]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eps](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Eps] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Generos]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Generos](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Generos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NivelEscolaridad]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelEscolaridad](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NivelEscolaridad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pacientes]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pacientes](
	[Id] [int] NOT NULL,
	[Nombre1] [nvarchar](50) NOT NULL,
	[Nombre2] [nvarchar](50) NULL,
	[Apellido1] [nvarchar](50) NOT NULL,
	[Apellido2] [nvarchar](50) NULL,
	[TipoId] [int] NOT NULL,
	[Numeroid] [nvarchar](20) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Telefono] [nvarchar](50) NOT NULL,
	[Direccion] [nvarchar](150) NOT NULL,
	[Ocupacion] [nvarchar](150) NOT NULL,
	[Email] [nvarchar](150) NOT NULL,
	[ContactoEmergencia] [nvarchar](50) NOT NULL,
	[GeneroId] [int] NOT NULL,
	[EstadoCivilId] [int] NOT NULL,
	[RegimenId] [int] NOT NULL,
	[NivelescolaridadId] [int] NOT NULL,
	[EpsId] [int] NOT NULL,
	[CiudadId] [int] NOT NULL,
 CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PreguntaRespuestas]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PreguntaRespuestas](
	[Id] [int] NOT NULL,
	[EncuestaId] [int] NOT NULL,
	[PreguntaId] [int] NOT NULL,
	[RespuestaId] [int] NOT NULL,
 CONSTRAINT [PK_PreguntaRespuestas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Preguntas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Regimenes]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Regimenes](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Regimenes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Respuestas]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuestas](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Respuestas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumentos]    Script Date: 25/06/2022 14:42:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumentos](
	[Id] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoDocumentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (1, N'Arboletes')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (2, N'San Juan de Urabá')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (3, N'San Pedro de Urabá')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (4, N'Necoclí')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (5, N'Apartadó')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (6, N'Carepa')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (7, N'Chigorodó')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (8, N'Turbo')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (9, N'Mutatá')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (10, N'Murindo')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (11, N'Vigia del fuerte')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (12, N'Acandí')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (13, N'El Carmen del Darién')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (14, N'Riosucio')
INSERT [dbo].[Ciudades] ([Id], [Nombre]) VALUES (15, N'Unguía')
GO
INSERT [dbo].[Eps] ([Id], [Nombre]) VALUES (1, N'Savia Salud')
INSERT [dbo].[Eps] ([Id], [Nombre]) VALUES (2, N'Nueva EPS')
INSERT [dbo].[Eps] ([Id], [Nombre]) VALUES (3, N'Sura')
INSERT [dbo].[Eps] ([Id], [Nombre]) VALUES (4, N'Particular')
INSERT [dbo].[Eps] ([Id], [Nombre]) VALUES (5, N'Salud Total')
INSERT [dbo].[Eps] ([Id], [Nombre]) VALUES (6, N'AIC')
INSERT [dbo].[Eps] ([Id], [Nombre]) VALUES (7, N'Comfachocó')
INSERT [dbo].[Eps] ([Id], [Nombre]) VALUES (8, N'No tiene EPS')
GO
INSERT [dbo].[EstadoCivil] ([Id], [Nombre]) VALUES (1, N'Soltero')
INSERT [dbo].[EstadoCivil] ([Id], [Nombre]) VALUES (2, N'Casado')
INSERT [dbo].[EstadoCivil] ([Id], [Nombre]) VALUES (3, N'Union Libre')
INSERT [dbo].[EstadoCivil] ([Id], [Nombre]) VALUES (4, N'Viudo')
GO
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (1, N'Masculino')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (2, N'Femenino')
INSERT [dbo].[Generos] ([Id], [Nombre]) VALUES (3, N'Otro')
GO
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (1, N'Preescolar')
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (2, N'Primaria')
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (3, N'Secundaria')
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (4, N'Media')
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (5, N'Tecnica')
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (6, N'Tecnológia')
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (7, N'Pregrado')
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (8, N'Postgrado')
INSERT [dbo].[NivelEscolaridad] ([Id], [Nombre]) VALUES (9, N'Ninguno')
GO
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (1, N'Me ha costado mucho descargar la tensión')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (2, N'Me di cuenta que tenía la boca seca')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (3, N'No podía sentir ningún sentimiento positivo')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (4, N'Se me hizo difícil respirar')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (5, N'Se me hizo difícil tomar la iniciativa para hacer cosas')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (6, N'Reaccioné exageradamente en ciertas situaciones')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (7, N'Sentí que mis manos temblaban')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (8, N'He sentido que estaba gastando una gran cantidad de energía')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (9, N'Estaba preocupado por situaciones en las cuales podía tener pánico o en las que podría
hacer el ridículo')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (10, N'He sentido que no había nada que me ilusionara')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (11, N'Me he sentido inquieto')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (12, N'Se me hizo difícil relajarme')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (13, N'Me sentí triste y deprimido')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (14, N'No toleré nada que no me permitiera continuar con lo que estaba haciendo')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (15, N'Sentí que estaba al punto de pánico')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (16, N'No me pude entusiasmar por nada')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (17, N'Sentí que valía muy poco como persona')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (18, N'He tendido a sentirme enfadado con facilidad')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (19, N'Sentí los latidos de mi corazón a pesar de no haber hecho ningún esfuerzo físico')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (20, N'Tuve miedo sin razón')
INSERT [dbo].[Preguntas] ([Id], [Nombre]) VALUES (21, N'Sentí que la vida no tenía ningún sentido')
GO
INSERT [dbo].[Regimenes] ([Id], [Nombre]) VALUES (1, N'Subsidiado')
INSERT [dbo].[Regimenes] ([Id], [Nombre]) VALUES (2, N'Contributivo')
INSERT [dbo].[Regimenes] ([Id], [Nombre]) VALUES (3, N'Beneficiario')
GO
INSERT [dbo].[Respuestas] ([Id], [Nombre]) VALUES (0, N'No me ha ocurrido')
INSERT [dbo].[Respuestas] ([Id], [Nombre]) VALUES (1, N'Me ha ocurrido un poco, o durante parte del tiempo')
INSERT [dbo].[Respuestas] ([Id], [Nombre]) VALUES (2, N'Me ha ocurrido
bastante, o durante una buena parte del tiempo')
INSERT [dbo].[Respuestas] ([Id], [Nombre]) VALUES (3, N'Me ha ocurrido mucho, o la mayor parte del tiempo')
GO
INSERT [dbo].[TipoDocumentos] ([Id], [Nombre]) VALUES (1, N'CC')
INSERT [dbo].[TipoDocumentos] ([Id], [Nombre]) VALUES (2, N'TI')
INSERT [dbo].[TipoDocumentos] ([Id], [Nombre]) VALUES (3, N'PA')
INSERT [dbo].[TipoDocumentos] ([Id], [Nombre]) VALUES (4, N'CE')
INSERT [dbo].[TipoDocumentos] ([Id], [Nombre]) VALUES (5, N'AS')
GO
ALTER TABLE [dbo].[Encuesta]  WITH CHECK ADD  CONSTRAINT [FK_Encuesta_Pacientes] FOREIGN KEY([PacienteId])
REFERENCES [dbo].[Pacientes] ([Id])
GO
ALTER TABLE [dbo].[Encuesta] CHECK CONSTRAINT [FK_Encuesta_Pacientes]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Ciudades] FOREIGN KEY([CiudadId])
REFERENCES [dbo].[Ciudades] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Ciudades]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Eps] FOREIGN KEY([EpsId])
REFERENCES [dbo].[Eps] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Eps]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_EstadoCivil] FOREIGN KEY([EstadoCivilId])
REFERENCES [dbo].[EstadoCivil] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_EstadoCivil]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Generos] FOREIGN KEY([GeneroId])
REFERENCES [dbo].[Generos] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Generos]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_NivelEscolaridad] FOREIGN KEY([NivelescolaridadId])
REFERENCES [dbo].[NivelEscolaridad] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_NivelEscolaridad]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Regimenes] FOREIGN KEY([RegimenId])
REFERENCES [dbo].[Regimenes] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Regimenes]
GO
ALTER TABLE [dbo].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_TipoDocumentos] FOREIGN KEY([TipoId])
REFERENCES [dbo].[TipoDocumentos] ([Id])
GO
ALTER TABLE [dbo].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_TipoDocumentos]
GO
ALTER TABLE [dbo].[PreguntaRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntaRespuestas_Encuesta] FOREIGN KEY([EncuestaId])
REFERENCES [dbo].[Encuesta] ([Id])
GO
ALTER TABLE [dbo].[PreguntaRespuestas] CHECK CONSTRAINT [FK_PreguntaRespuestas_Encuesta]
GO
ALTER TABLE [dbo].[PreguntaRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntaRespuestas_Preguntas] FOREIGN KEY([PreguntaId])
REFERENCES [dbo].[Preguntas] ([Id])
GO
ALTER TABLE [dbo].[PreguntaRespuestas] CHECK CONSTRAINT [FK_PreguntaRespuestas_Preguntas]
GO
ALTER TABLE [dbo].[PreguntaRespuestas]  WITH CHECK ADD  CONSTRAINT [FK_PreguntaRespuestas_Respuestas] FOREIGN KEY([RespuestaId])
REFERENCES [dbo].[Respuestas] ([Id])
GO
ALTER TABLE [dbo].[PreguntaRespuestas] CHECK CONSTRAINT [FK_PreguntaRespuestas_Respuestas]
GO
USE [master]
GO
ALTER DATABASE [DBDASS21] SET  READ_WRITE 
GO
