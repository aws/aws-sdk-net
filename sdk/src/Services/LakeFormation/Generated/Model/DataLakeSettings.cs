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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure representing a list of Lake Formation principals designated as data lake
    /// administrators and lists of principal permission entries for default create database
    /// and default create table permissions.
    /// </summary>
    public partial class DataLakeSettings
    {
        private bool? _allowExternalDataFiltering;
        private List<string> _authorizedSessionTagValueList = new List<string>();
        private List<PrincipalPermissions> _createDatabaseDefaultPermissions = new List<PrincipalPermissions>();
        private List<PrincipalPermissions> _createTableDefaultPermissions = new List<PrincipalPermissions>();
        private List<DataLakePrincipal> _dataLakeAdmins = new List<DataLakePrincipal>();
        private List<DataLakePrincipal> _externalDataFilteringAllowList = new List<DataLakePrincipal>();
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private List<string> _trustedResourceOwners = new List<string>();

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
        /// For more information, see <a href="https://docs-aws.amazon.com/lake-formation/latest/dg/getting-started-setup.html#emr-switch">(Optional)
        /// Allow Data Filtering on Amazon EMR</a>.
        /// </para>
        /// </summary>
        public bool AllowExternalDataFiltering
        {
            get { return this._allowExternalDataFiltering.GetValueOrDefault(); }
            set { this._allowExternalDataFiltering = value; }
        }

        // Check to see if AllowExternalDataFiltering property is set
        internal bool IsSetAllowExternalDataFiltering()
        {
            return this._allowExternalDataFiltering.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AuthorizedSessionTagValueList. 
        /// <para>
        /// Lake Formation relies on a privileged process secured by Amazon EMR or the third party
        /// integrator to tag the user's role while assuming it. Lake Formation will publish the
        /// acceptable key-value pair, for example key = "LakeFormationTrustedCaller" and value
        /// = "TRUE" and the third party integrator must properly tag the temporary security credentials
        /// that will be used to call Lake Formation's administrative APIs.
        /// </para>
        /// </summary>
        public List<string> AuthorizedSessionTagValueList
        {
            get { return this._authorizedSessionTagValueList; }
            set { this._authorizedSessionTagValueList = value; }
        }

        // Check to see if AuthorizedSessionTagValueList property is set
        internal bool IsSetAuthorizedSessionTagValueList()
        {
            return this._authorizedSessionTagValueList != null && this._authorizedSessionTagValueList.Count > 0; 
        }

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
        /// </summary>
        public List<PrincipalPermissions> CreateDatabaseDefaultPermissions
        {
            get { return this._createDatabaseDefaultPermissions; }
            set { this._createDatabaseDefaultPermissions = value; }
        }

        // Check to see if CreateDatabaseDefaultPermissions property is set
        internal bool IsSetCreateDatabaseDefaultPermissions()
        {
            return this._createDatabaseDefaultPermissions != null && this._createDatabaseDefaultPermissions.Count > 0; 
        }

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
        /// </summary>
        public List<PrincipalPermissions> CreateTableDefaultPermissions
        {
            get { return this._createTableDefaultPermissions; }
            set { this._createTableDefaultPermissions = value; }
        }

        // Check to see if CreateTableDefaultPermissions property is set
        internal bool IsSetCreateTableDefaultPermissions()
        {
            return this._createTableDefaultPermissions != null && this._createTableDefaultPermissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DataLakeAdmins. 
        /// <para>
        /// A list of Lake Formation principals. Supported principals are IAM users or IAM roles.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<DataLakePrincipal> DataLakeAdmins
        {
            get { return this._dataLakeAdmins; }
            set { this._dataLakeAdmins = value; }
        }

        // Check to see if DataLakeAdmins property is set
        internal bool IsSetDataLakeAdmins()
        {
            return this._dataLakeAdmins != null && this._dataLakeAdmins.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ExternalDataFilteringAllowList. 
        /// <para>
        /// A list of the account IDs of Amazon Web Services accounts with Amazon EMR clusters
        /// that are to perform data filtering.&gt;
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public List<DataLakePrincipal> ExternalDataFilteringAllowList
        {
            get { return this._externalDataFilteringAllowList; }
            set { this._externalDataFilteringAllowList = value; }
        }

        // Check to see if ExternalDataFilteringAllowList property is set
        internal bool IsSetExternalDataFilteringAllowList()
        {
            return this._externalDataFilteringAllowList != null && this._externalDataFilteringAllowList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A key-value map that provides an additional configuration on your data lake. CrossAccountVersion
        /// is the key you can configure in the Parameters field. Accepted values for the CrossAccountVersion
        /// key are 1, 2, and 3.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

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
        /// </summary>
        public List<string> TrustedResourceOwners
        {
            get { return this._trustedResourceOwners; }
            set { this._trustedResourceOwners = value; }
        }

        // Check to see if TrustedResourceOwners property is set
        internal bool IsSetTrustedResourceOwners()
        {
            return this._trustedResourceOwners != null && this._trustedResourceOwners.Count > 0; 
        }

    }
}