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
    /// Container for the parameters to the GetTemporaryGluePartitionCredentials operation.
    /// This API is identical to <code>GetTemporaryTableCredentials</code> except that this
    /// is used when the target Data Catalog resource is of type Partition. Lake Formation
    /// restricts the permission of the vended credentials with the same scope down policy
    /// which restricts access to a single Amazon S3 prefix.
    /// </summary>
    public partial class GetTemporaryGluePartitionCredentialsRequest : AmazonLakeFormationRequest
    {
        private AuditContext _auditContext;
        private int? _durationSeconds;
        private PartitionValueList _partition;
        private List<string> _permissions = new List<string>();
        private List<string> _supportedPermissionTypes = new List<string>();
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
        public int DurationSeconds
        {
            get { return this._durationSeconds.GetValueOrDefault(); }
            set { this._durationSeconds = value; }
        }

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this._durationSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Partition. 
        /// <para>
        /// A list of partition values identifying a single partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PartitionValueList Partition
        {
            get { return this._partition; }
            set { this._partition = value; }
        }

        // Check to see if Partition property is set
        internal bool IsSetPartition()
        {
            return this._partition != null;
        }

        /// <summary>
        /// Gets and sets the property Permissions. 
        /// <para>
        /// Filters the request based on the user having been granted a list of specified permissions
        /// on the requested resource(s).
        /// </para>
        /// </summary>
        public List<string> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SupportedPermissionTypes. 
        /// <para>
        /// A list of supported permission types for the partition. Valid values are <code>COLUMN_PERMISSION</code>
        /// and <code>CELL_FILTER_PERMISSION</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public List<string> SupportedPermissionTypes
        {
            get { return this._supportedPermissionTypes; }
            set { this._supportedPermissionTypes = value; }
        }

        // Check to see if SupportedPermissionTypes property is set
        internal bool IsSetSupportedPermissionTypes()
        {
            return this._supportedPermissionTypes != null && this._supportedPermissionTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableArn. 
        /// <para>
        /// The ARN of the partitions' table.
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