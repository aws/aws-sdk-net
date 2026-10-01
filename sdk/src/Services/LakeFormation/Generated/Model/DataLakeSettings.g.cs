/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure representing a list of Lake Formation principals designated as data lake
    /// administrators and lists of principal permission entries for default create database
    /// and default create table permissions.
    /// </summary>
    public partial class DataLakeSettings
    {
        /// <summary>
        /// Gets and sets the property AllowExternalDataFiltering. 
        /// <para>
        /// Whether to allow Amazon EMR clusters to access data managed by Lake Formation. 
        /// </para>
        ///  
        /// <para>
        /// If true, you allow Amazon EMR clusters to access data in Amazon S3 locations that
        /// are registered with Lake Formation.
        /// </para>
        ///  
        /// <para>
        /// If false or null, no Amazon EMR clusters will be able to access data in Amazon S3
        /// locations that are registered with Lake Formation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/initial-LF-setup.html#external-data-filter">(Optional)
        /// Allow external data filtering</a>.
        /// </para>
        /// </summary>
        public bool? AllowExternalDataFiltering { get; set; }

        /// <summary>
        /// Checks to see if the AllowExternalDataFiltering property is set.
        /// </summary>
        internal bool IsSetAllowExternalDataFiltering() => this.AllowExternalDataFiltering.HasValue;

        /// <summary>
        /// Gets and sets the property AllowFullTableExternalDataAccess. 
        /// <para>
        /// Whether to allow a third-party query engine to get data access credentials without
        /// session tags when a caller has full data access permissions.
        /// </para>
        /// </summary>
        public bool? AllowFullTableExternalDataAccess { get; set; }

        /// <summary>
        /// Checks to see if the AllowFullTableExternalDataAccess property is set.
        /// </summary>
        internal bool IsSetAllowFullTableExternalDataAccess() => this.AllowFullTableExternalDataAccess.HasValue;

        /// <summary>
        /// Gets and sets the property AuthorizedSessionTagValueList. 
        /// <para>
        /// Lake Formation relies on a privileged process secured by Amazon EMR or the third party
        /// integrator to tag the user's role while assuming it. Lake Formation will publish the
        /// acceptable key-value pair, for example key = "LakeFormationTrustedCaller" and value
        /// = "TRUE" and the third party integrator must properly tag the temporary security credentials
        /// that will be used to call Lake Formation's administrative APIs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AuthorizedSessionTagValueList { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AuthorizedSessionTagValueList property is set.
        /// </summary>
        internal bool IsSetAuthorizedSessionTagValueList() => this.AuthorizedSessionTagValueList != null && (this.AuthorizedSessionTagValueList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateDatabaseDefaultPermissions. 
        /// <para>
        /// Specifies whether access control on newly created database is managed by Lake Formation
        /// permissions or exclusively by IAM permissions.
        /// </para>
        ///  
        /// <para>
        /// A null value indicates access control by Lake Formation permissions. A value that
        /// assigns ALL to IAM_ALLOWED_PRINCIPALS indicates access control by IAM permissions.
        /// This is referred to as the setting "Use only IAM access control," and is for backward
        /// compatibility with the Glue permission model implemented by IAM permissions.
        /// </para>
        ///  
        /// <para>
        /// The only permitted values are an empty array or an array that contains a single JSON
        /// object that grants ALL to IAM_ALLOWED_PRINCIPALS.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/change-settings.html">Changing
        /// the Default Security Settings for Your Data Lake</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrincipalPermissions> CreateDatabaseDefaultPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;

        /// <summary>
        /// Checks to see if the CreateDatabaseDefaultPermissions property is set.
        /// </summary>
        internal bool IsSetCreateDatabaseDefaultPermissions() => this.CreateDatabaseDefaultPermissions != null && (this.CreateDatabaseDefaultPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreateTableDefaultPermissions. 
        /// <para>
        /// Specifies whether access control on newly created table is managed by Lake Formation
        /// permissions or exclusively by IAM permissions.
        /// </para>
        ///  
        /// <para>
        /// A null value indicates access control by Lake Formation permissions. A value that
        /// assigns ALL to IAM_ALLOWED_PRINCIPALS indicates access control by IAM permissions.
        /// This is referred to as the setting "Use only IAM access control," and is for backward
        /// compatibility with the Glue permission model implemented by IAM permissions.
        /// </para>
        ///  
        /// <para>
        /// The only permitted values are an empty array or an array that contains a single JSON
        /// object that grants ALL to IAM_ALLOWED_PRINCIPALS.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/change-settings.html">Changing
        /// the Default Security Settings for Your Data Lake</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PrincipalPermissions> CreateTableDefaultPermissions { get; set; } = AWSConfigs.InitializeCollections ? new List<PrincipalPermissions>() : null;

        /// <summary>
        /// Checks to see if the CreateTableDefaultPermissions property is set.
        /// </summary>
        internal bool IsSetCreateTableDefaultPermissions() => this.CreateTableDefaultPermissions != null && (this.CreateTableDefaultPermissions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DataLakeAdmins. 
        /// <para>
        /// A list of Lake Formation principals. Supported principals are IAM users or IAM roles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<DataLakePrincipal> DataLakeAdmins { get; set; } = AWSConfigs.InitializeCollections ? new List<DataLakePrincipal>() : null;

        /// <summary>
        /// Checks to see if the DataLakeAdmins property is set.
        /// </summary>
        internal bool IsSetDataLakeAdmins() => this.DataLakeAdmins != null && (this.DataLakeAdmins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExternalDataFilteringAllowList. 
        /// <para>
        /// A list of the account IDs of Amazon Web Services accounts with Amazon EMR clusters
        /// that are to perform data filtering.>
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<DataLakePrincipal> ExternalDataFilteringAllowList { get; set; } = AWSConfigs.InitializeCollections ? new List<DataLakePrincipal>() : null;

        /// <summary>
        /// Checks to see if the ExternalDataFilteringAllowList property is set.
        /// </summary>
        internal bool IsSetExternalDataFilteringAllowList() => this.ExternalDataFilteringAllowList != null && (this.ExternalDataFilteringAllowList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A key-value map that provides an additional configuration on your data lake. The following
        /// key-value pairs are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CROSS_ACCOUNT_VERSION</c> - Accepted values are 1, 2, 3, 4, and 5.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SET_SOURCE_IDENTITY</c> - Accepted values are <c>TRUE</c> and <c>FALSE</c>. When
        /// set to <c>TRUE</c>, Lake Formation includes the IAM role identifier that was used
        /// to query in the S3 data event CloudTrail logs for <c>s3:GetObject</c> calls. For more
        /// information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/cloudtrail-logging.html#source-identity-cloudtrail">Tracking
        /// query engine IAM roles in S3 data events</a>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReadOnlyAdmins. 
        /// <para>
        /// A list of Lake Formation principals with only view access to the resources, without
        /// the ability to make changes. Supported principals are IAM users or IAM roles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 30)]
        public List<DataLakePrincipal> ReadOnlyAdmins { get; set; } = AWSConfigs.InitializeCollections ? new List<DataLakePrincipal>() : null;

        /// <summary>
        /// Checks to see if the ReadOnlyAdmins property is set.
        /// </summary>
        internal bool IsSetReadOnlyAdmins() => this.ReadOnlyAdmins != null && (this.ReadOnlyAdmins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrustedResourceOwners. 
        /// <para>
        /// A list of the resource-owning account IDs that the caller's account can use to share
        /// their user access details (user ARNs). The user ARNs can be logged in the resource
        /// owner's CloudTrail log.
        /// </para>
        ///  
        /// <para>
        /// You may want to specify this property when you are in a high-trust boundary, such
        /// as the same team or company. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TrustedResourceOwners { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TrustedResourceOwners property is set.
        /// </summary>
        internal bool IsSetTrustedResourceOwners() => this.TrustedResourceOwners != null && (this.TrustedResourceOwners.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
