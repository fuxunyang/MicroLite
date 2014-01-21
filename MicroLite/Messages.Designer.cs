﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MicroLite {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Messages {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Messages() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MicroLite.Messages", typeof(Messages).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Encryption algorithm is missing, please add the following value to app.settings: &lt;add key=&quot;MicroLite.DbEncryptedString.SymmetricAlgorithm&quot; value=&quot;AesManaged&quot; /&gt; (see http://msdn.microsoft.com/en-us/library/System.Security.Cryptography.SymmetricAlgorithm(v=vs.110).aspx for the fully supported list of values).
        /// </summary>
        internal static string AppSettingSymmetricAlgorithmProvider_MissingAlgorithm {
            get {
                return ResourceManager.GetString("AppSettingSymmetricAlgorithmProvider_MissingAlgorithm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Encryption key is missing, please add the following value to app.settings: &lt;add key=&quot;MicroLite.DbEncryptedString.EncryptionKey&quot; value=&quot;replace-with-your-encryption-key&quot; /&gt;.
        /// </summary>
        internal static string AppSettingSymmetricAlgorithmProvider_MissingKey {
            get {
                return ResourceManager.GetString("AppSettingSymmetricAlgorithmProvider_MissingKey", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object cannot be inserted as it does not have an identifier value set and the identifier strategy specifies that it should be assigned before being inserted..
        /// </summary>
        internal static string AssignedListener_IdentifierNotSetForInsert {
            get {
                return ResourceManager.GetString("AssignedListener_IdentifierNotSetForInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}.{1}&apos; will not be mapped by MicroLite as it has no ColumnAttribute.
        /// </summary>
        internal static string AttributeMappingConvention_IgnoringProperty {
            get {
                return ResourceManager.GetString("AttributeMappingConvention_IgnoringProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; cannot be used by MicroLite as is not decorated with a TableAttribute.
        /// </summary>
        internal static string AttributeMappingConvention_NoTableAttribute {
            get {
                return ResourceManager.GetString("AttributeMappingConvention_NoTableAttribute", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Closing the database connection.
        /// </summary>
        internal static string ClosingConnection {
            get {
                return ResourceManager.GetString("ClosingConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Using mapping convention &apos;{0}&apos;.
        /// </summary>
        internal static string ConfigureExtensions_UsingMappingConvention {
            get {
                return ResourceManager.GetString("ConfigureExtensions_UsingMappingConvention", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}.{1}&apos; will not be mapped by MicroLite as the convention settings have specified it is ignored.
        /// </summary>
        internal static string ConventionMappingConvention_IgnoringProperty {
            get {
                return ResourceManager.GetString("ConventionMappingConvention_IgnoringProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The cipher text is invalid, it should contain 2 parts separated by an &apos;@&apos;.
        /// </summary>
        internal static string DbEncryptedStringTypeConverter_CipherTextInvalid {
            get {
                return ResourceManager.GetString("DbEncryptedStringTypeConverter_CipherTextInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;dynamic&apos; type can only be used for queries where an SqlQuery is supplied, it cannot be used for select by identifier, insert, update or delete..
        /// </summary>
        internal static string ExpandoObjectInfo_NotSupportedReason {
            get {
                return ResourceManager.GetString("ExpandoObjectInfo_NotSupportedReason", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connection was found in the app.config with the name &apos;{0}&apos;.
        /// </summary>
        internal static string FluentConfiguration_ConnectionNotFound {
            get {
                return ResourceManager.GetString("FluentConfiguration_ConnectionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a session factory for connection named &apos;{0}&apos;.
        /// </summary>
        internal static string FluentConfiguration_CreatingSessionFactory {
            get {
                return ResourceManager.GetString("FluentConfiguration_CreatingSessionFactory", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object does not have an identifier value set so it cannot be deleted.
        /// </summary>
        internal static string IListener_IdentifierNotSetForDelete {
            get {
                return ResourceManager.GetString("IListener_IdentifierNotSetForDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object does not have an identifier value set so it cannot be updated.
        /// </summary>
        internal static string IListener_IdentifierNotSetForUpdate {
            get {
                return ResourceManager.GetString("IListener_IdentifierNotSetForUpdate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object already has an identifier value so it cannot be inserted.
        /// </summary>
        internal static string IListener_IdentifierSetForInsert {
            get {
                return ResourceManager.GetString("IListener_IdentifierSetForInsert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting the identifier value for an instance of the type &apos;{0}&apos; to &apos;{1}&apos;.
        /// </summary>
        internal static string IListener_SettingIdentifierValue {
            get {
                return ResourceManager.GetString("IListener_SettingIdentifierValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The scalar query should return a single row with a single column.
        /// </summary>
        internal static string IncludeScalar_MultipleColumns {
            get {
                return ResourceManager.GetString("IncludeScalar_MultipleColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There are multiple records returned in the results list, the single query should return a single row only.
        /// </summary>
        internal static string IncludeSingle_SingleResultExpected {
            get {
                return ResourceManager.GetString("IncludeSingle_SingleResultExpected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping the property &apos;{0}.{1}&apos; to the column &apos;{2}&apos;.
        /// </summary>
        internal static string MappingConvention_MappingColumnToProperty {
            get {
                return ResourceManager.GetString("MappingConvention_MappingColumnToProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping the type &apos;{0}&apos; to the table &apos;{1}.{2}&apos;.
        /// </summary>
        internal static string MappingConvention_MappingTypeToTable {
            get {
                return ResourceManager.GetString("MappingConvention_MappingTypeToTable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The property &apos;{0}.{1}&apos; will not be mapped by MicroLite as it does not have a public getter and setter..
        /// </summary>
        internal static string MappingConvention_PropertyNotGetAndSet {
            get {
                return ResourceManager.GetString("MappingConvention_PropertyNotGetAndSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The column {0} is not mapped to a property on the {1} class.
        /// </summary>
        internal static string ObjectInfo_ColumnNotMapped {
            get {
                return ResourceManager.GetString("ObjectInfo_ColumnNotMapped", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new instance of &apos;{0}&apos;.
        /// </summary>
        internal static string ObjectInfo_CreatingInstance {
            get {
                return ResourceManager.GetString("ObjectInfo_CreatingInstance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating the ObjectInfo for the type &apos;{0}&apos;.
        /// </summary>
        internal static string ObjectInfo_CreatingObjectInfo {
            get {
                return ResourceManager.GetString("ObjectInfo_CreatingObjectInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Getting the value of &apos;{0}.{1}&apos; for the &apos;{2}&apos; column.
        /// </summary>
        internal static string ObjectInfo_GettingPropertyValueForColumn {
            get {
                return ResourceManager.GetString("ObjectInfo_GettingPropertyValueForColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retrieving the ObjectInfo for &apos;{0}&apos;.
        /// </summary>
        internal static string ObjectInfo_RetrievingObjectInfo {
            get {
                return ResourceManager.GetString("ObjectInfo_RetrievingObjectInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Setting the property value of &apos;{0}.{1}&apos;.
        /// </summary>
        internal static string ObjectInfo_SettingPropertyValue {
            get {
                return ResourceManager.GetString("ObjectInfo_SettingPropertyValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type of the object {0} does not match the type for the ObjectInfo {1}.
        /// </summary>
        internal static string ObjectInfo_TypeMismatch {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is not a class and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustBeClass {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustBeClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; has no default (parameterless) constructor and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustHaveDefaultConstructor {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustHaveDefaultConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; is abstract and therefore cannot be used by the MicroLite ORM Framework.
        /// </summary>
        internal static string ObjectInfo_TypeMustNotBeAbstract {
            get {
                return ResourceManager.GetString("ObjectInfo_TypeMustNotBeAbstract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; does not have a property mapped to the column name &apos;{1}&apos;.
        /// </summary>
        internal static string ObjectInfo_UnknownColumn {
            get {
                return ResourceManager.GetString("ObjectInfo_UnknownColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Opening the database connection.
        /// </summary>
        internal static string OpeningConnection {
            get {
                return ResourceManager.GetString("OpeningConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The first page which can be requested is page 1.
        /// </summary>
        internal static string PagingOptions_PagesMustBeAtleastOne {
            get {
                return ResourceManager.GetString("PagingOptions_PagesMustBeAtleastOne", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There must be at least 1 result per page.
        /// </summary>
        internal static string PagingOptions_ResultsPerPageMustBeAtLeast1 {
            get {
                return ResourceManager.GetString("PagingOptions_ResultsPerPageMustBeAtLeast1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It is not possible to skip less than 0 results.
        /// </summary>
        internal static string PagingOptions_SkipMustBeZeroOrAbove {
            get {
                return ResourceManager.GetString("PagingOptions_SkipMustBeZeroOrAbove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least 1 result must be returned.
        /// </summary>
        internal static string PagingOptions_TakeMustBeZeroOrAbove {
            get {
                return ResourceManager.GetString("PagingOptions_TakeMustBeZeroOrAbove", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Executing &apos;{0}&apos; queries.
        /// </summary>
        internal static string Session_ExecutingQueries {
            get {
                return ResourceManager.GetString("Session_ExecutingQueries", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The paging options must contain a count and offset, use the PagingOptions.ForPage or PagingOptions.SkipTake methods to specify the values.
        /// </summary>
        internal static string Session_PagingOptionsMustNotBeNone {
            get {
                return ResourceManager.GetString("Session_PagingOptionsMustNotBeNone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new read only session for connection &apos;{0}&apos; using &apos;{1}&apos;.
        /// </summary>
        internal static string SessionFactory_CreatingReadOnlySession {
            get {
                return ResourceManager.GetString("SessionFactory_CreatingReadOnlySession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Creating a new session for connection &apos;{0}&apos; using &apos;{1}&apos;.
        /// </summary>
        internal static string SessionFactory_CreatingSession {
            get {
                return ResourceManager.GetString("SessionFactory_CreatingSession", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The number of parameters in the SQL statement and the number of specified parameter arguments should match. However &apos;{0}&apos; parameters used in the SQL statement and &apos;{1}&apos; parameter arguments were specified..
        /// </summary>
        internal static string SqlDialect_ArgumentsCountMismatch {
            get {
                return ResourceManager.GetString("SqlDialect_ArgumentsCountMismatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The sql dialect does not support the creation of an SqlQuery for the given statement type.
        /// </summary>
        internal static string SqlDialect_StatementTypeNotSupported {
            get {
                return ResourceManager.GetString("SqlDialect_StatementTypeNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The column &apos;{0}&apos; has been mapped multiple times, this usually occurs if multiple properties have the same column name specified in the column attribute.
        /// </summary>
        internal static string TableInfo_ColumnMappedMultipleTimes {
            get {
                return ResourceManager.GetString("TableInfo_ColumnMappedMultipleTimes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Multiple columns have been mapped as the identifier for the table &apos;{0}.{1}&apos;.
        /// </summary>
        internal static string TableInfo_MultipleIdentifierColumns {
            get {
                return ResourceManager.GetString("TableInfo_MultipleIdentifierColumns", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No column has been mapped as the identifier for the table &apos;{0}.{1}&apos;.
        /// </summary>
        internal static string TableInfo_NoIdentifierColumn {
            get {
                return ResourceManager.GetString("TableInfo_NoIdentifierColumn", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction has been completed.
        /// </summary>
        internal static string Transaction_AlreadyCompleted {
            get {
                return ResourceManager.GetString("Transaction_AlreadyCompleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Beginning a new Transaction with the IsolationLevel &apos;{0}&apos;..
        /// </summary>
        internal static string Transaction_BeginTransactionWithIsolationLevel {
            get {
                return ResourceManager.GetString("Transaction_BeginTransactionWithIsolationLevel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction has successfully committed changes.
        /// </summary>
        internal static string Transaction_Committed {
            get {
                return ResourceManager.GetString("Transaction_Committed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction is committing changes.
        /// </summary>
        internal static string Transaction_Committing {
            get {
                return ResourceManager.GetString("Transaction_Committing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction has been disposed of.
        /// </summary>
        internal static string Transaction_Disposed {
            get {
                return ResourceManager.GetString("Transaction_Disposed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction is being disposed with uncommitted changes, they will be automatically rolled back.
        /// </summary>
        internal static string Transaction_DisposedUncommitted {
            get {
                return ResourceManager.GetString("Transaction_DisposedUncommitted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction has rolled back changes.
        /// </summary>
        internal static string Transaction_RolledBack {
            get {
                return ResourceManager.GetString("Transaction_RolledBack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Transaction is rolling back changes.
        /// </summary>
        internal static string Transaction_RollingBack {
            get {
                return ResourceManager.GetString("Transaction_RollingBack", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Transaction rolling back changes from failed commit.
        /// </summary>
        internal static string Transaction_RollingBackFailedCommit {
            get {
                return ResourceManager.GetString("Transaction_RollingBackFailedCommit", resourceCulture);
            }
        }
    }
}
