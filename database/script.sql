USE [master]
GO
/****** Object:  Database [bd_uno]    Script Date: 9/12/2022 11:53:54 AM ******/
CREATE DATABASE [bd_uno]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd_uno', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd_uno.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd_uno_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd_uno_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bd_uno] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd_uno].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd_uno] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd_uno] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd_uno] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd_uno] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd_uno] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd_uno] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd_uno] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd_uno] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd_uno] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd_uno] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd_uno] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd_uno] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd_uno] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd_uno] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd_uno] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd_uno] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd_uno] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd_uno] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd_uno] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd_uno] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd_uno] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd_uno] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd_uno] SET RECOVERY FULL 
GO
ALTER DATABASE [bd_uno] SET  MULTI_USER 
GO
ALTER DATABASE [bd_uno] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd_uno] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd_uno] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd_uno] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd_uno] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd_uno] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bd_uno', N'ON'
GO
ALTER DATABASE [bd_uno] SET QUERY_STORE = OFF
GO
USE [bd_uno]
GO
/****** Object:  UserDefinedFunction [dbo].[ft_vacacion_gnr]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--generar vacaciones
create function [dbo].[ft_vacacion_gnr]
(
	@p_fecha_ing AS DATE
	, @p_fecha_corte AS DATE
)

RETURNS DECIMAL(18,2)
AS
BEGIN
	DECLARE @v_dias AS DECIMAL(18,2)
	SELECT @v_dias = DATEDIFF(dd,@p_fecha_ing, @p_fecha_corte) / 30 * 2.5

	RETURN @v_dias
END
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[empleado_id] [int] IDENTITY(1,1) NOT NULL,
	[emp_nombre] [varchar](70) NOT NULL,
	[tipo_ident_id] [int] NOT NULL,
	[emp_identificacion] [varchar](30) NOT NULL,
	[emp_fecha_ingreso] [date] NOT NULL,
	[emp_sal_base_men] [numeric](18, 2) NOT NULL,
	[emp_direccion] [varchar](70) NOT NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[empleado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipo_identificacion]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_identificacion](
	[tipo_ident_id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](30) NOT NULL,
 CONSTRAINT [PK_tipo_identificacion] PRIMARY KEY CLUSTERED 
(
	[tipo_ident_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vacaciones]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vacaciones](
	[vacacion_id] [int] IDENTITY(1,1) NOT NULL,
	[empleado_id] [int] NULL,
	[fecha] [date] NOT NULL,
	[fecha_ini] [date] NOT NULL,
	[fecha_fin] [date] NOT NULL,
	[dias] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_vacaciones] PRIMARY KEY CLUSTERED 
(
	[vacacion_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_empleado_tipo_identificacion] FOREIGN KEY([tipo_ident_id])
REFERENCES [dbo].[tipo_identificacion] ([tipo_ident_id])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_empleado_tipo_identificacion]
GO
ALTER TABLE [dbo].[vacaciones]  WITH CHECK ADD  CONSTRAINT [FK_vacaciones_empleado] FOREIGN KEY([empleado_id])
REFERENCES [dbo].[empleado] ([empleado_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[vacaciones] CHECK CONSTRAINT [FK_vacaciones_empleado]
GO
/****** Object:  StoredProcedure [dbo].[VP_CrearVacacion]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VP_CrearVacacion]

  @P_EMPID INT,
  @P_FECHA DATE,
  @P_FECHAINI DATE,
  @P_FECHAFIN DATE,
  @P_DIAS DECIMAL(18,2)

AS
	BEGIN
		INSERT INTO [dbo].[vacaciones]
           ([empleado_id]
           ,[fecha]
           ,[fecha_ini]
           ,[fecha_fin]
           ,[dias])
		VALUES
           (@P_EMPID
           ,@P_FECHA
           ,@P_FECHAINI
           ,@P_FECHAFIN
           ,@P_DIAS)
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_EditarEmpleado]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VP_EditarEmpleado]
@P_EMPID INT,
@P_EMPNOM VARCHAR(70),
@P_TIDENT INT,
@P_EMPIDENT VARCHAR(30),
@P_EMPFINGRESO DATE,
@P_EMPSALBASEMEN NUMERIC(18, 2),
@P_EMPDIR VARCHAR(70)
AS
	BEGIN
		UPDATE empleado SET [emp_nombre] = @P_EMPNOM
		,[tipo_ident_id] = @P_TIDENT
		,[emp_identificacion] = @P_EMPIDENT
		,[emp_fecha_ingreso] = @P_EMPFINGRESO
		,[emp_sal_base_men] = @P_EMPSALBASEMEN
		,[emp_direccion] = @P_EMPDIR
		WHERE empleado_id = @P_EMPID
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_EditarVacacion]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VP_EditarVacacion]
  @P_VACACIONID INT,
  @P_EMPID INT,
  @P_FECHA DATE,
  @P_FECHAINI DATE,
  @P_FECHAFIN DATE,
  @P_DIAS DECIMAL(18,2)

AS
	BEGIN
		UPDATE [dbo].[vacaciones]
		SET [fecha] = @P_FECHA
		,[fecha_ini] = @P_FECHAINI
		,[fecha_fin] = @P_FECHAFIN
		,[dias] = @P_DIAS
		WHERE empleado_id = @P_EMPID
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_EliminarEmpleado]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VP_EliminarEmpleado]
@P_EMPID INT
AS
	BEGIN
		DELETE FROM empleado
		WHERE empleado_id = @P_EMPID;
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_EliminarVacacion]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VP_EliminarVacacion]
    @P_VACACIONID INT
AS
	BEGIN

		DELETE FROM [dbo].[vacaciones]
		WHERE vacacion_id = @P_VACACIONID
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_InsertarEmpleado]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VP_InsertarEmpleado]
@P_EMPNOM VARCHAR(70),
@P_TIDENT INT,
@P_EMPIDENT VARCHAR(30),
@P_EMPFINGRESO DATE,
@P_EMPSALBASEMEN NUMERIC(18, 2),
@P_EMPDIR VARCHAR(70)
AS
	BEGIN
		INSERT INTO empleado ([emp_nombre], [tipo_ident_id], [emp_identificacion], [emp_fecha_ingreso], [emp_sal_base_men], [emp_direccion])
		VALUES (@P_EMPNOM, @P_TIDENT, @P_EMPIDENT, @P_EMPFINGRESO, @P_EMPSALBASEMEN, @P_EMPDIR);
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_ObtenerCalculoDeVacaciones]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VP_ObtenerCalculoDeVacaciones]
	@p_fecha_ini AS DATE,
	@p_fecha_corte AS DATE
AS
	SET NOCOUNT ON
	;WITH vac_CTE AS (
		SELECT	empleado_id, sum(dias) Tomados
		FROM	dbo.vacaciones
		WHERE fecha_fin <= @p_fecha_corte
		GROUP BY empleado_id
	), gen_CTE AS (
		SELECT	e.empleado_id, e.emp_nombre, [dbo].[ft_vacacion_gnr](@p_fecha_ini, @p_fecha_corte) Generado
		FROM dbo.empleado e 	
	)

	SELECT	e.empleado_id, e.emp_nombre, v.Tomados, e.Generado, e.Generado- v.Tomados Saldo
	FROM	gen_CTE e inner join
			vac_CTE v ON e.empleado_id = v.empleado_id

GO
/****** Object:  StoredProcedure [dbo].[VP_ObtenerEmpleados]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VP_ObtenerEmpleados]
AS
	BEGIN
		SELECT empleado_id, emp_nombre, ti.tipo, ti.tipo_ident_id, emp_identificacion, emp_fecha_ingreso, emp_sal_base_men, emp_direccion
		FROM empleado
		INNER JOIN tipo_identificacion AS ti ON empleado.tipo_ident_id = ti.tipo_ident_id
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_ObtenerTipoIdentPorNombre]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VP_ObtenerTipoIdentPorNombre]
@P_TIPO VARCHAR(30)
AS
	BEGIN
		DECLARE @ret int
			SET @ret = (SELECT tipo_ident_id FROM tipo_identificacion WHERE tipo = @P_TIPO)
		RETURN @ret
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_ObtenerTipoIdents]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VP_ObtenerTipoIdents]
AS
	BEGIN
		SELECT tipo_ident_id, tipo FROM tipo_identificacion
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_ObtenerVacaciones]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VP_ObtenerVacaciones]
  @P_EMPID INT

AS
	BEGIN
		SELECT [vacacion_id]
		,[empleado_id]
		,fecha
		,fecha_ini
		,fecha_fin
		,[dias]
		FROM [dbo].[vacaciones]
		WHERE empleado_id = @P_EMPID
	END
GO
/****** Object:  StoredProcedure [dbo].[VP_ObtenerVacacionesConEmpleados]    Script Date: 9/12/2022 11:53:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[VP_ObtenerVacacionesConEmpleados]
AS
	BEGIN
		SELECT [e].[emp_nombre]
		,[e].[emp_identificacion]
		,[fecha]
		,[fecha_ini]
		,[fecha_fin]
		,[dias]
		FROM [dbo].[vacaciones] AS v
		INNER JOIN empleado AS e ON e.empleado_id = v.empleado_id
	END
GO
USE [master]
GO
ALTER DATABASE [bd_uno] SET  READ_WRITE 
GO
