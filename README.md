# ConsoleExportJson
Console Export SQL Server 2008+ Database Structure as Json


Application console that performs querying in the database extracting the struture of the tables in a JSON format

Aplicação console que executa consultar na base de dados extraindo a strutura das tabelas em um formato JSON


```json
{
	"Tables": [{
		"TableName": "TestCampo",
		"Fields": [{
			"Name": "Id",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": true,
			"IsPrimaryKey": true,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Texto",
			"Type": "varchar",
			"MaxLength": -1,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Nome",
			"Type": "varchar",
			"MaxLength": 300,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CPF",
			"Type": "varchar",
			"MaxLength": 14,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CNPJ",
			"Type": "varchar",
			"MaxLength": 22,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "IE",
			"Type": "varchar",
			"MaxLength": 14,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CEP",
			"Type": "varchar",
			"MaxLength": 10,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Numero",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "IsTest",
			"Type": "bit",
			"MaxLength": 1,
			"Precision": 1,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Valor",
			"Type": "numeric",
			"MaxLength": 9,
			"Precision": 18,
			"Scale": 2,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		}],
		"RefMeTables": [],
		"RefTables": []
	},
	{
		"TableName": "TestCampoPai",
		"Fields": [{
			"Name": "Id",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": true,
			"IsPrimaryKey": true,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Texto",
			"Type": "varchar",
			"MaxLength": -1,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Nome",
			"Type": "varchar",
			"MaxLength": 300,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CPF",
			"Type": "varchar",
			"MaxLength": 14,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CNPJ",
			"Type": "varchar",
			"MaxLength": 22,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "IE",
			"Type": "varchar",
			"MaxLength": 14,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CEP",
			"Type": "varchar",
			"MaxLength": 10,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Numero",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "IsTest",
			"Type": "bit",
			"MaxLength": 1,
			"Precision": 1,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Valor",
			"Type": "numeric",
			"MaxLength": 9,
			"Precision": 18,
			"Scale": 2,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		}],
		"RefMeTables": [{
			"Key": "Id",
			"Table": "TestCampoItem",
			"Column": "IdPai",
			"RefName": "Pai_Item_fk"
		}],
		"RefTables": []
	},
	{
		"TableName": "TestCampoItem",
		"Fields": [{
			"Name": "Id",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": true,
			"IsPrimaryKey": true,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Texto",
			"Type": "varchar",
			"MaxLength": -1,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Nome",
			"Type": "varchar",
			"MaxLength": 300,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CPF",
			"Type": "varchar",
			"MaxLength": 14,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CNPJ",
			"Type": "varchar",
			"MaxLength": 22,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "IE",
			"Type": "varchar",
			"MaxLength": 14,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "CEP",
			"Type": "varchar",
			"MaxLength": 10,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Numero",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "IsTest",
			"Type": "bit",
			"MaxLength": 1,
			"Precision": 1,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Valor",
			"Type": "numeric",
			"MaxLength": 9,
			"Precision": 18,
			"Scale": 2,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "IdPai",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": true,
			"Id": 0
		}],
		"RefMeTables": [],
		"RefTables": [{
			"Key": "Id",
			"Table": "TestCampoPai",
			"Column": "IdPai",
			"RefName": "Pai_Item_fk"
		}]
	},
	{
		"TableName": "Roles",
		"Fields": [{
			"Name": "Id",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": true,
			"IsPrimaryKey": true,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Name",
			"Type": "varchar",
			"MaxLength": 256,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		}],
		"RefMeTables": [{
			"Key": "Id",
			"Table": "UserRoles",
			"Column": "RoleId",
			"RefName": "IdentityRole_Users"
		}],
		"RefTables": []
	},
	{
		"TableName": "UserClaims",
		"Fields": [{
			"Name": "Id",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": true,
			"IsPrimaryKey": true,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "UserId",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": true,
			"Id": 0
		},
		{
			"Name": "ClaimType",
			"Type": "varchar",
			"MaxLength": 500,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "ClaimValue",
			"Type": "varchar",
			"MaxLength": 500,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		}],
		"RefMeTables": [],
		"RefTables": [{
			"Key": "Id",
			"Table": "Users",
			"Column": "UserId",
			"RefName": "ApplicationUser_Claims"
		}]
	},
	{
		"TableName": "UserLogins",
		"Fields": [{
			"Name": "Id",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": true,
			"IsPrimaryKey": true,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "LoginProvider",
			"Type": "varchar",
			"MaxLength": 128,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "ProviderKey",
			"Type": "varchar",
			"MaxLength": 128,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "UserId",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": true,
			"Id": 0
		}],
		"RefMeTables": [],
		"RefTables": [{
			"Key": "Id",
			"Table": "Users",
			"Column": "UserId",
			"RefName": "ApplicationUser_Logins"
		}]
	},
	{
		"TableName": "UserRoles",
		"Fields": [{
			"Name": "UserId",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": false,
			"IsPrimaryKey": true,
			"IsForeignKey": true,
			"Id": 0
		},
		{
			"Name": "RoleId",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": false,
			"IsPrimaryKey": true,
			"IsForeignKey": true,
			"Id": 0
		}],
		"RefMeTables": [],
		"RefTables": [{
			"Key": "Id",
			"Table": "Users",
			"Column": "UserId",
			"RefName": "ApplicationUser_Roles"
		},
		{
			"Key": "Id",
			"Table": "Roles",
			"Column": "RoleId",
			"RefName": "IdentityRole_Users"
		}]
	},
	{
		"TableName": "Users",
		"Fields": [{
			"Name": "Id",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": false,
			"IsIdentity": true,
			"IsPrimaryKey": true,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Name",
			"Type": "varchar",
			"MaxLength": 60,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Email",
			"Type": "varchar",
			"MaxLength": 300,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Pwd",
			"Type": "varchar",
			"MaxLength": 128,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "Hash",
			"Type": "varchar",
			"MaxLength": 128,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "EmailConfirmed",
			"Type": "bit",
			"MaxLength": 1,
			"Precision": 1,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "PasswordHash",
			"Type": "varchar",
			"MaxLength": 256,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "SecurityStamp",
			"Type": "varchar",
			"MaxLength": 256,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "PhoneNumber",
			"Type": "varchar",
			"MaxLength": 256,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "PhoneNumberConfirmed",
			"Type": "bit",
			"MaxLength": 1,
			"Precision": 1,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "TwoFactorEnabled",
			"Type": "bit",
			"MaxLength": 1,
			"Precision": 1,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "LockoutEndDateUtc",
			"Type": "datetime",
			"MaxLength": 8,
			"Precision": 23,
			"Scale": 3,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "LockoutEnabled",
			"Type": "bit",
			"MaxLength": 1,
			"Precision": 1,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "AccessFailedCount",
			"Type": "int",
			"MaxLength": 4,
			"Precision": 10,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		},
		{
			"Name": "UserName",
			"Type": "varchar",
			"MaxLength": 256,
			"Precision": 0,
			"Scale": 0,
			"IsNullable": true,
			"IsIdentity": false,
			"IsPrimaryKey": false,
			"IsForeignKey": false,
			"Id": 0
		}],
		"RefMeTables": [{
			"Key": "Id",
			"Table": "UserClaims",
			"Column": "UserId",
			"RefName": "ApplicationUser_Claims"
		},
		{
			"Key": "Id",
			"Table": "UserLogins",
			"Column": "UserId",
			"RefName": "ApplicationUser_Logins"
		},
		{
			"Key": "Id",
			"Table": "UserRoles",
			"Column": "UserId",
			"RefName": "ApplicationUser_Roles"
		}],
		"RefTables": []
	}]
}

```
