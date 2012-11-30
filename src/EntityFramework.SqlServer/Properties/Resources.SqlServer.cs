﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.SqlServer.Resources
{
    using System.CodeDom.Compiler;
    using System.Globalization;
    using System.Resources;
    using System.Threading;

    /// <summary>
    ///     Strongly-typed and parameterized string resources.
    /// </summary>
    [GeneratedCode("Resources.SqlServer.tt", "1.0.0.0")]
    internal static class Strings
    {
        /// <summary>
        ///     A string like "The argument '{0}' cannot be null, empty or contain only white space."
        /// </summary>
        internal static string ArgumentIsNullOrWhitespace(object p0)
        {
            return EntityRes.GetString(EntityRes.ArgumentIsNullOrWhitespace, p0);
        }

        /// <summary>
        ///     A string like "The specified DbGeography value could not be converted to a SQL Server compatible value."
        /// </summary>
        internal static string SqlProvider_GeographyValueNotSqlCompatible
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_GeographyValueNotSqlCompatible); }
        }

        /// <summary>
        ///     A string like "The specified DbGeometry value could not be converted to a SQL Server compatible value."
        /// </summary>
        internal static string SqlProvider_GeometryValueNotSqlCompatible
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_GeometryValueNotSqlCompatible); }
        }

        /// <summary>
        ///     A string like "The provider returned null for the informationType '{0}'."
        /// </summary>
        internal static string ProviderReturnedNullForGetDbInformation(object p0)
        {
            return EntityRes.GetString(EntityRes.ProviderReturnedNullForGetDbInformation, p0);
        }

        /// <summary>
        ///     A string like "The underlying provider does not support the type '{0}'."
        /// </summary>
        internal static string ProviderDoesNotSupportType(object p0)
        {
            return EntityRes.GetString(EntityRes.ProviderDoesNotSupportType, p0);
        }

        /// <summary>
        ///     A string like "There is no store type corresponding to the conceptual side type '{0}' of primitive type '{1}'."
        /// </summary>
        internal static string NoStoreTypeForEdmType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.NoStoreTypeForEdmType, p0, p1);
        }

        /// <summary>
        ///     A string like "The provider manifest given is not of type '{0}'."
        /// </summary>
        internal static string Mapping_Provider_WrongManifestType(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Provider_WrongManifestType, p0);
        }

        /// <summary>
        ///     A string like "Internal .NET Framework Data Provider error {0}."
        /// </summary>
        internal static string ADP_InternalProviderError(object p0)
        {
            return EntityRes.GetString(EntityRes.ADP_InternalProviderError, p0);
        }

        /// <summary>
        ///     A string like "Could not determine storage version; a valid storage connection or a version hint is required."
        /// </summary>
        internal static string UnableToDetermineStoreVersion
        {
            get { return EntityRes.GetString(EntityRes.UnableToDetermineStoreVersion); }
        }

        /// <summary>
        ///     A string like "Spatial readers can only be produced from readers of type SqlDataReader.   A reader of type {0} was provided."
        /// </summary>
        internal static string SqlProvider_NeedSqlDataReader(object p0)
        {
            return EntityRes.GetString(EntityRes.SqlProvider_NeedSqlDataReader, p0);
        }

        /// <summary>
        ///     A string like "Spatial types and functions are only supported by SQL Server 2008 or later."
        /// </summary>
        internal static string SqlProvider_Sql2008RequiredForSpatial
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_Sql2008RequiredForSpatial); }
        }

        /// <summary>
        ///     A string like "Spatial types and functions are not available for this provider because the assembly 'Microsoft.SqlServer.Types' version 10 or higher could not be found. "
        /// </summary>
        internal static string SqlProvider_SqlTypesAssemblyNotFound
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_SqlTypesAssemblyNotFound); }
        }

        /// <summary>
        ///     A string like "The database creation succeeded, but the creation of the database objects failed. The consequent attempt to drop the database also failed. See InnerException for details."
        /// </summary>
        internal static string SqlProvider_IncompleteCreateDatabase
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_IncompleteCreateDatabase); }
        }

        /// <summary>
        ///     A string like "See InnerExceptions for details."
        /// </summary>
        internal static string SqlProvider_IncompleteCreateDatabaseAggregate
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_IncompleteCreateDatabaseAggregate); }
        }

        /// <summary>
        ///     A string like "Unable to complete operation. The supplied SqlConnection does not specify an initial catalog or AttachDBFileName."
        /// </summary>
        internal static string SqlProvider_DdlGeneration_MissingInitialCatalog
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_DdlGeneration_MissingInitialCatalog); }
        }

        /// <summary>
        ///     A string like "Unable to delete the database. There is no database that corresponds to the given AttachDBFileName."
        /// </summary>
        internal static string SqlProvider_DdlGeneration_CannotDeleteDatabaseNoInitialCatalog
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_DdlGeneration_CannotDeleteDatabaseNoInitialCatalog); }
        }

        /// <summary>
        ///     A string like "A connection to the specified database could not be opened. See InnerException for details. However, there is a database registered with the server that corresponds to the given AttachDbFileName."
        /// </summary>
        internal static string SqlProvider_DdlGeneration_CannotTellIfDatabaseExists
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_DdlGeneration_CannotTellIfDatabaseExists); }
        }

        /// <summary>
        ///     A string like "This operation requires a connection to the 'master' database. Unable to create a connection to the 'master' database because the original database connection has been opened and credentials have been removed from the connection string. Supply an unopened connection."
        /// </summary>
        internal static string SqlProvider_CredentialsMissingForMasterConnection
        {
            get { return EntityRes.GetString(EntityRes.SqlProvider_CredentialsMissingForMasterConnection); }
        }

        /// <summary>
        ///     A string like "Expected a geography value, found a value of type {0}."
        /// </summary>
        internal static string SqlProvider_InvalidGeographyColumn(object p0)
        {
            return EntityRes.GetString(EntityRes.SqlProvider_InvalidGeographyColumn, p0);
        }

        /// <summary>
        ///     A string like "Expected a geometry value, found a value of type {0}."
        /// </summary>
        internal static string SqlProvider_InvalidGeometryColumn(object p0)
        {
            return EntityRes.GetString(EntityRes.SqlProvider_InvalidGeometryColumn, p0);
        }

        /// <summary>
        ///     A string like "The connection is not of type '{0}'."
        /// </summary>
        internal static string Mapping_Provider_WrongConnectionType(object p0)
        {
            return EntityRes.GetString(EntityRes.Mapping_Provider_WrongConnectionType, p0);
        }

        /// <summary>
        ///     A string like "Store-generated keys are only supported for identity columns. More than one key column is marked as server generated in table '{0}'."
        /// </summary>
        internal static string Update_NotSupportedServerGenKey(object p0)
        {
            return EntityRes.GetString(EntityRes.Update_NotSupportedServerGenKey, p0);
        }

        /// <summary>
        ///     A string like "Store-generated keys are only supported for identity columns. Key column '{0}' has type '{1}', which is not a valid type for an identity column."
        /// </summary>
        internal static string Update_NotSupportedIdentityType(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.Update_NotSupportedIdentityType, p0, p1);
        }

        /// <summary>
        ///     A string like "Unable to update the EntitySet '{0}' because it has a DefiningQuery and no <{1}> element exists in the <{2}> element to support the current operation."
        /// </summary>
        internal static string Update_SqlEntitySetWithoutDmlFunctions(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.Update_SqlEntitySetWithoutDmlFunctions, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "The expression '{0}' is of an unsupported type. "
        /// </summary>
        internal static string Cqt_General_UnsupportedExpression(object p0)
        {
            return EntityRes.GetString(EntityRes.Cqt_General_UnsupportedExpression, p0);
        }

        /// <summary>
        ///     A string like "The execution of this query requires the APPLY operator, which is not supported in versions of SQL Server earlier than SQL Server 2005."
        /// </summary>
        internal static string SqlGen_ApplyNotSupportedOnSql8
        {
            get { return EntityRes.GetString(EntityRes.SqlGen_ApplyNotSupportedOnSql8); }
        }

        /// <summary>
        ///     A string like "Functions listed in the provider manifest that are attributed as NiladicFunction='true' cannot have parameter declarations."
        /// </summary>
        internal static string SqlGen_NiladicFunctionsCannotHaveParameters
        {
            get { return EntityRes.GetString(EntityRes.SqlGen_NiladicFunctionsCannotHaveParameters); }
        }

        /// <summary>
        ///     A string like "The DATEPART argument to the '{0}.{1}' function must be a literal string."
        /// </summary>
        internal static string SqlGen_InvalidDatePartArgumentExpression(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.SqlGen_InvalidDatePartArgumentExpression, p0, p1);
        }

        /// <summary>
        ///     A string like "'{0}' is not a valid value for the DATEPART argument in the '{1}.{2}' function."
        /// </summary>
        internal static string SqlGen_InvalidDatePartArgumentValue(object p0, object p1, object p2)
        {
            return EntityRes.GetString(EntityRes.SqlGen_InvalidDatePartArgumentValue, p0, p1, p2);
        }

        /// <summary>
        ///     A string like "Constant expressions of type {0} with a value of NaN are not supported by SQL Server."
        /// </summary>
        internal static string SqlGen_TypedNaNNotSupported(object p0)
        {
            return EntityRes.GetString(EntityRes.SqlGen_TypedNaNNotSupported, p0);
        }

        /// <summary>
        ///     A string like "Constant expressions of type {0} with a value of {1}.PositiveInfinity are not supported by SQL Server."
        /// </summary>
        internal static string SqlGen_TypedPositiveInfinityNotSupported(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.SqlGen_TypedPositiveInfinityNotSupported, p0, p1);
        }

        /// <summary>
        ///     A string like "Constant expressions of type {0} with a value of {1}.NegativeInfinity are not supported by SQL Server."
        /// </summary>
        internal static string SqlGen_TypedNegativeInfinityNotSupported(object p0, object p1)
        {
            return EntityRes.GetString(EntityRes.SqlGen_TypedNegativeInfinityNotSupported, p0, p1);
        }

        /// <summary>
        ///     A string like "There is no store type that maps to the EDM type '{0}' on versions of SQL Server earlier than SQL Server 2008."
        /// </summary>
        internal static string SqlGen_PrimitiveTypeNotSupportedPriorSql10(object p0)
        {
            return EntityRes.GetString(EntityRes.SqlGen_PrimitiveTypeNotSupportedPriorSql10, p0);
        }

        /// <summary>
        ///     A string like "The EDM function '{0}' is not supported on versions of SQL Server earlier than SQL Server 2008."
        /// </summary>
        internal static string SqlGen_CanonicalFunctionNotSupportedPriorSql10(object p0)
        {
            return EntityRes.GetString(EntityRes.SqlGen_CanonicalFunctionNotSupportedPriorSql10, p0);
        }

        /// <summary>
        ///     A string like "Parameters as arguments to a TOP sub-clause and a LIMIT sub-clause in a query, or a LimitExpression in a command tree, are not supported in versions of SQL Server earlier than SQL Server 2005."
        /// </summary>
        internal static string SqlGen_ParameterForLimitNotSupportedOnSql8
        {
            get { return EntityRes.GetString(EntityRes.SqlGen_ParameterForLimitNotSupportedOnSql8); }
        }

        /// <summary>
        ///     A string like "Parameters as arguments to a SKIP sub-clause in a query, or a SkipExpression in a command tree, are not supported in versions of SQL Server earlier than SQL Server 2005."
        /// </summary>
        internal static string SqlGen_ParameterForSkipNotSupportedOnSql8
        {
            get { return EntityRes.GetString(EntityRes.SqlGen_ParameterForSkipNotSupportedOnSql8); }
        }

        /// <summary>
        ///     A string like "The specified DbWellKnownGeographyValue does not contain either Well-Known Text or Well-Known Binary."
        /// </summary>
        internal static string Spatial_WellKnownGeographyValueNotValid
        {
            get { return EntityRes.GetString(EntityRes.Spatial_WellKnownGeographyValueNotValid); }
        }

        /// <summary>
        ///     A string like "The specified DbWellKnownGeometryValue does not contain either Well-Known Text or Well-Known Binary."
        /// </summary>
        internal static string Spatial_WellKnownGeometryValueNotValid
        {
            get { return EntityRes.GetString(EntityRes.Spatial_WellKnownGeometryValueNotValid); }
        }

        /// <summary>
        ///     A string like "The specified provider value is not compatible with this spatial services implementation. A value is required of type '{0}'."
        /// </summary>
        internal static string SqlSpatialServices_ProviderValueNotSqlType(object p0)
        {
            return EntityRes.GetString(EntityRes.SqlSpatialServices_ProviderValueNotSqlType, p0);
        }

        /// <summary>
        ///     A string like "A Spatial Reference System Identifier (SRID) value could not be retrieved from the specified DbGeography value."
        /// </summary>
        internal static string SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoSrid
        {
            get { return EntityRes.GetString(EntityRes.SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoSrid); }
        }

        /// <summary>
        ///     A string like "The specified DbGeography value did not provide either Well-Known Binary or Well-Known Text."
        /// </summary>
        internal static string SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoWkbOrWkt
        {
            get { return EntityRes.GetString(EntityRes.SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoWkbOrWkt); }
        }

        /// <summary>
        ///     A string like "A Spatial Reference System Identifier (SRID) value could not be retrieved from the specified DbGeometry value."
        /// </summary>
        internal static string SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoSrid
        {
            get { return EntityRes.GetString(EntityRes.SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoSrid); }
        }

        /// <summary>
        ///     A string like "The specified DbGeometry value did not provide either Well-Known Binary or Well-Known Text."
        /// </summary>
        internal static string SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoWkbOrWkt
        {
            get { return EntityRes.GetString(EntityRes.SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoWkbOrWkt); }
        }
    }

    /// <summary>
    ///     Strongly-typed and parameterized exception factory.
    /// </summary>
    [GeneratedCode("Resources.SqlServer.tt", "1.0.0.0")]
    internal static class Error
    {
        /// <summary>
        ///     ArgumentException with message like "The argument '{0}' cannot be null, empty or contain only white space."
        /// </summary>
        internal static Exception ArgumentIsNullOrWhitespace(object p0)
        {
            return new ArgumentException(Strings.ArgumentIsNullOrWhitespace(p0));
        }

        /// <summary>
        ///     The exception that is thrown when the value of an argument is outside the allowable range of values as defined by the invoked method.
        /// </summary>
        internal static Exception ArgumentOutOfRange(string paramName)
        {
            return new ArgumentOutOfRangeException(paramName);
        }

        /// <summary>
        ///     The exception that is thrown when the author has yet to implement the logic at this point in the program. This can act as an exception based TODO tag.
        /// </summary>
        internal static Exception NotImplemented()
        {
            return new NotImplementedException();
        }

        /// <summary>
        ///     The exception that is thrown when an invoked method is not supported, or when there is an attempt to read, seek, or write to a stream that does not support the invoked functionality.
        /// </summary>
        internal static Exception NotSupported()
        {
            return new NotSupportedException();
        }
    }

    /// <summary>
    ///     AutoGenerated resource class. Usage:
    ///     string s = EntityRes.GetString(EntityRes.MyIdenfitier);
    /// </summary>
    [GeneratedCode("Resources.SqlServer.tt", "1.0.0.0")]
    internal sealed class EntityRes
    {
        internal const string ArgumentIsNullOrWhitespace = "ArgumentIsNullOrWhitespace";
        internal const string SqlProvider_GeographyValueNotSqlCompatible = "SqlProvider_GeographyValueNotSqlCompatible";
        internal const string SqlProvider_GeometryValueNotSqlCompatible = "SqlProvider_GeometryValueNotSqlCompatible";
        internal const string ProviderReturnedNullForGetDbInformation = "ProviderReturnedNullForGetDbInformation";
        internal const string ProviderDoesNotSupportType = "ProviderDoesNotSupportType";
        internal const string NoStoreTypeForEdmType = "NoStoreTypeForEdmType";
        internal const string Mapping_Provider_WrongManifestType = "Mapping_Provider_WrongManifestType";
        internal const string ADP_InternalProviderError = "ADP_InternalProviderError";
        internal const string UnableToDetermineStoreVersion = "UnableToDetermineStoreVersion";
        internal const string SqlProvider_NeedSqlDataReader = "SqlProvider_NeedSqlDataReader";
        internal const string SqlProvider_Sql2008RequiredForSpatial = "SqlProvider_Sql2008RequiredForSpatial";
        internal const string SqlProvider_SqlTypesAssemblyNotFound = "SqlProvider_SqlTypesAssemblyNotFound";
        internal const string SqlProvider_IncompleteCreateDatabase = "SqlProvider_IncompleteCreateDatabase";
        internal const string SqlProvider_IncompleteCreateDatabaseAggregate = "SqlProvider_IncompleteCreateDatabaseAggregate";
        internal const string SqlProvider_DdlGeneration_MissingInitialCatalog = "SqlProvider_DdlGeneration_MissingInitialCatalog";

        internal const string SqlProvider_DdlGeneration_CannotDeleteDatabaseNoInitialCatalog =
            "SqlProvider_DdlGeneration_CannotDeleteDatabaseNoInitialCatalog";

        internal const string SqlProvider_DdlGeneration_CannotTellIfDatabaseExists = "SqlProvider_DdlGeneration_CannotTellIfDatabaseExists";
        internal const string SqlProvider_CredentialsMissingForMasterConnection = "SqlProvider_CredentialsMissingForMasterConnection";
        internal const string SqlProvider_InvalidGeographyColumn = "SqlProvider_InvalidGeographyColumn";
        internal const string SqlProvider_InvalidGeometryColumn = "SqlProvider_InvalidGeometryColumn";
        internal const string Mapping_Provider_WrongConnectionType = "Mapping_Provider_WrongConnectionType";
        internal const string Update_NotSupportedServerGenKey = "Update_NotSupportedServerGenKey";
        internal const string Update_NotSupportedIdentityType = "Update_NotSupportedIdentityType";
        internal const string Update_SqlEntitySetWithoutDmlFunctions = "Update_SqlEntitySetWithoutDmlFunctions";
        internal const string Cqt_General_UnsupportedExpression = "Cqt_General_UnsupportedExpression";
        internal const string SqlGen_ApplyNotSupportedOnSql8 = "SqlGen_ApplyNotSupportedOnSql8";
        internal const string SqlGen_NiladicFunctionsCannotHaveParameters = "SqlGen_NiladicFunctionsCannotHaveParameters";
        internal const string SqlGen_InvalidDatePartArgumentExpression = "SqlGen_InvalidDatePartArgumentExpression";
        internal const string SqlGen_InvalidDatePartArgumentValue = "SqlGen_InvalidDatePartArgumentValue";
        internal const string SqlGen_TypedNaNNotSupported = "SqlGen_TypedNaNNotSupported";
        internal const string SqlGen_TypedPositiveInfinityNotSupported = "SqlGen_TypedPositiveInfinityNotSupported";
        internal const string SqlGen_TypedNegativeInfinityNotSupported = "SqlGen_TypedNegativeInfinityNotSupported";
        internal const string SqlGen_PrimitiveTypeNotSupportedPriorSql10 = "SqlGen_PrimitiveTypeNotSupportedPriorSql10";
        internal const string SqlGen_CanonicalFunctionNotSupportedPriorSql10 = "SqlGen_CanonicalFunctionNotSupportedPriorSql10";
        internal const string SqlGen_ParameterForLimitNotSupportedOnSql8 = "SqlGen_ParameterForLimitNotSupportedOnSql8";
        internal const string SqlGen_ParameterForSkipNotSupportedOnSql8 = "SqlGen_ParameterForSkipNotSupportedOnSql8";
        internal const string Spatial_WellKnownGeographyValueNotValid = "Spatial_WellKnownGeographyValueNotValid";
        internal const string Spatial_WellKnownGeometryValueNotValid = "Spatial_WellKnownGeometryValueNotValid";
        internal const string SqlSpatialServices_ProviderValueNotSqlType = "SqlSpatialServices_ProviderValueNotSqlType";

        internal const string SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoSrid =
            "SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoSrid";

        internal const string SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoWkbOrWkt =
            "SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoWkbOrWkt";

        internal const string SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoSrid =
            "SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoSrid";

        internal const string SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoWkbOrWkt =
            "SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoWkbOrWkt";

        private static EntityRes loader;
        private readonly ResourceManager resources;

        private EntityRes()
        {
            resources = new ResourceManager(
                "System.Data.Entity.SqlServer.Properties.Resources.SqlServer", typeof(SqlProviderServices).Assembly);
        }

        private static EntityRes GetLoader()
        {
            if (loader == null)
            {
                var sr = new EntityRes();
                Interlocked.CompareExchange(ref loader, sr, null);
            }
            return loader;
        }

        private static CultureInfo Culture
        {
            get { return null /*use ResourceManager default, CultureInfo.CurrentUICulture*/; }
        }

        public static ResourceManager Resources
        {
            get { return GetLoader().resources; }
        }

        public static string GetString(string name, params object[] args)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }
            var res = sys.resources.GetString(name, Culture);

            if (args != null
                && args.Length > 0)
            {
                for (var i = 0; i < args.Length; i ++)
                {
                    var value = args[i] as String;
                    if (value != null
                        && value.Length > 1024)
                    {
                        args[i] = value.Substring(0, 1024 - 3) + "...";
                    }
                }
                return String.Format(CultureInfo.CurrentCulture, res, args);
            }
            else
            {
                return res;
            }
        }

        public static string GetString(string name)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }
            return sys.resources.GetString(name, Culture);
        }

        public static string GetString(string name, out bool usedFallback)
        {
            // always false for this version of gensr
            usedFallback = false;
            return GetString(name);
        }

        public static object GetObject(string name)
        {
            var sys = GetLoader();
            if (sys == null)
            {
                return null;
            }
            return sys.resources.GetObject(name, Culture);
        }
    }
}
