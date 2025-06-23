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
    /// Contains details on the configuration of a table optimizer. You pass this configuration
    /// when creating or updating a table optimizer.
    /// </summary>
    public partial class TableOptimizerConfiguration
    {
        private CompactionConfiguration _compactionConfiguration;
        private bool? _enabled;
        private OrphanFileDeletionConfiguration _orphanFileDeletionConfiguration;
        private RetentionConfiguration _retentionConfiguration;
        private string _roleArn;
        private TableOptimizerVpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property CompactionConfiguration. 
        /// <para>
        /// The configuration for a compaction optimizer. This configuration defines how data
        /// files in your table will be compacted to improve query performance and reduce storage
        /// costs.
        /// </para>
        /// </summary>
        public CompactionConfiguration CompactionConfiguration
        {
            get { return this._compactionConfiguration; }
            set { this._compactionConfiguration = value; }
        }

        // Check to see if CompactionConfiguration property is set
        internal bool IsSetCompactionConfiguration()
        {
            return this._compactionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether table optimization is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OrphanFileDeletionConfiguration. 
        /// <para>
        /// The configuration for an orphan file deletion optimizer.
        /// </para>
        /// </summary>
        public OrphanFileDeletionConfiguration OrphanFileDeletionConfiguration
        {
            get { return this._orphanFileDeletionConfiguration; }
            set { this._orphanFileDeletionConfiguration = value; }
        }

        // Check to see if OrphanFileDeletionConfiguration property is set
        internal bool IsSetOrphanFileDeletionConfiguration()
        {
            return this._orphanFileDeletionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionConfiguration. 
        /// <para>
        /// The configuration for a snapshot retention optimizer.
        /// </para>
        /// </summary>
        public RetentionConfiguration RetentionConfiguration
        {
            get { return this._retentionConfiguration; }
            set { this._retentionConfiguration = value; }
        }

        // Check to see if RetentionConfiguration property is set
        internal bool IsSetRetentionConfiguration()
        {
            return this._retentionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A role passed by the caller which gives the service permission to update the resources
        /// associated with the optimizer on the caller's behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// A <c>TableOptimizerVpcConfiguration</c> object representing the VPC configuration
        /// for a table optimizer.
        /// </para>
        ///  
        /// <para>
        /// This configuration is necessary to perform optimization on tables that are in a customer
        /// VPC.
        /// </para>
        /// </summary>
        public TableOptimizerVpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}