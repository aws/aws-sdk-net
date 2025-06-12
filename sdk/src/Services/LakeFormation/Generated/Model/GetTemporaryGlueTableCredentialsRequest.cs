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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetTemporaryGlueTableCredentials operation.
    /// Allows a caller in a secure environment to assume a role with permission to access
    /// Amazon S3. In order to vend such credentials, Lake Formation assumes the role associated
    /// with a registered location, for example an Amazon S3 bucket, with a scope down policy
    /// which restricts the access to a single prefix.
    /// 
    ///  
    /// <para>
    /// To call this API, the role that the service assumes must have <c>lakeformation:GetDataAccess</c>
    /// permission on the resource.
    /// </para>
    /// </summary>
    public partial class GetTemporaryGlueTableCredentialsRequest : AmazonLakeFormationRequest
    {
        private AuditContext _auditContext;
        private int? _durationSeconds;
        private List<string> _permissions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private QuerySessionContext _querySessionContext;
        private string _s3Path;
        private List<string> _supportedPermissionTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tableArn;

        /// <summary>
        /// Gets and sets the property AuditContext. 
        /// <para>
        /// A structure representing context to access a resource (column names, query ID, etc).
        /// </para>
        /// </summary>
        public AuditContext AuditContext
        {
            get { return this._auditContext; }
            set { this._auditContext = value; }
        }

        // Check to see if AuditContext property is set
        internal bool IsSetAuditContext()
        {
            return this._auditContext != null;
        }

        /// <summary>
        /// Gets and sets the property DurationSeconds. 
        /// <para>
        /// The time period, between 900 and 21,600 seconds, for the timeout of the temporary
        /// credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=900, Max=43200)]
        public int? DurationSeconds
        {
            get { return this._durationSeconds; }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// Filters the request based on the user having been granted a list of specified permissions
        /// on the requested resource(s).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && (this._permissions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QuerySessionContext. 
        /// <para>
        /// A structure used as a protocol between query engines and Lake Formation or Glue. Contains
        /// both a Lake Formation generated authorization identifier and information from the
        /// request's authorization context.
        /// </para>
        /// </summary>
        public QuerySessionContext QuerySessionContext
        {
            get { return this._querySessionContext; }
            set { this._querySessionContext = value; }
        }

        // Check to see if QuerySessionContext property is set
        internal bool IsSetQuerySessionContext()
        {
            return this._querySessionContext != null;
        }

        /// <summary>
        /// Gets and sets the property S3Path. 
        /// <para>
        /// The Amazon S3 path for the table.
        /// </para>
        /// </summary>
        public string S3Path
        {
            get { return this._s3Path; }
            set { this._s3Path = value; }
        }

        // Check to see if S3Path property is set
        internal bool IsSetS3Path()
        {
            return this._s3Path != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedPermissionTypes. 
        /// <para>
        /// A list of supported permission types for the table. Valid values are <c>COLUMN_PERMISSION</c>
        /// and <c>CELL_FILTER_PERMISSION</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public List<string> SupportedPermissionTypes
        {
            get { return this._supportedPermissionTypes; }
            set { this._supportedPermissionTypes = value; }
        }

        // Check to see if SupportedPermissionTypes property is set
        internal bool IsSetSupportedPermissionTypes()
        {
            return this._supportedPermissionTypes != null && (this._supportedPermissionTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The ARN identifying a table in the Data Catalog for the temporary credentials request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TableArn
        {
            get { return this._tableArn; }
            set { this._tableArn = value; }
        }

        // Check to see if TableArn property is set
        internal bool IsSetTableArn()
        {
            return this._tableArn != null;
        }

    }
}