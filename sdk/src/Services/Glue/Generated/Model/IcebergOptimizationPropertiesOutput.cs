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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// A structure that contains the output properties of Iceberg table optimization configuration
    /// for your catalog resource in the Glue Data Catalog.
    /// </summary>
    public partial class IcebergOptimizationPropertiesOutput
    {
        private Dictionary<string, string> _compaction = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private DateTime? _lastUpdatedTime;
        private Dictionary<string, string> _orphanFileDeletion = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Dictionary<string, string> _retention = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property Compaction. 
        /// <para>
        /// A map of key-value pairs that specify configuration parameters for Iceberg table compaction
        /// operations, which optimize the layout of data files to improve query performance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Compaction
        {
            get { return this._compaction; }
            set { this._compaction = value; }
        }

        // Check to see if Compaction property is set
        internal bool IsSetCompaction()
        {
            return this._compaction != null && (this._compaction.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the Iceberg optimization properties were last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrphanFileDeletion. 
        /// <para>
        /// A map of key-value pairs that specify configuration parameters for Iceberg orphan
        /// file deletion operations, which identify and remove files that are no longer referenced
        /// by the table metadata.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> OrphanFileDeletion
        {
            get { return this._orphanFileDeletion; }
            set { this._orphanFileDeletion = value; }
        }

        // Check to see if OrphanFileDeletion property is set
        internal bool IsSetOrphanFileDeletion()
        {
            return this._orphanFileDeletion != null && (this._orphanFileDeletion.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Retention. 
        /// <para>
        /// A map of key-value pairs that specify configuration parameters for Iceberg table retention
        /// operations, which manage the lifecycle of table snapshots to control storage costs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Retention
        {
            get { return this._retention; }
            set { this._retention = value; }
        }

        // Check to see if Retention property is set
        internal bool IsSetRetention()
        {
            return this._retention != null && (this._retention.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that is used to perform Iceberg table
        /// optimization operations.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}