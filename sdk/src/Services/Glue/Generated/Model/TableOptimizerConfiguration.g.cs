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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains details on the configuration of a table optimizer. You pass this configuration
    /// when creating or updating a table optimizer.
    /// </summary>
    public partial class TableOptimizerConfiguration
    {
        /// <summary>
        /// Gets and sets the property CompactionConfiguration. 
        /// <para>
        /// The configuration for a compaction optimizer. This configuration defines how data
        /// files in your table will be compacted to improve query performance and reduce storage
        /// costs.
        /// </para>
        /// </summary>
        public CompactionConfiguration CompactionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CompactionConfiguration property is set.
        /// </summary>
        internal bool IsSetCompactionConfiguration() => this.CompactionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Whether table optimization is enabled.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property OrphanFileDeletionConfiguration. 
        /// <para>
        /// The configuration for an orphan file deletion optimizer.
        /// </para>
        /// </summary>
        public OrphanFileDeletionConfiguration OrphanFileDeletionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OrphanFileDeletionConfiguration property is set.
        /// </summary>
        internal bool IsSetOrphanFileDeletionConfiguration() => this.OrphanFileDeletionConfiguration != null;

        /// <summary>
        /// Gets and sets the property RetentionConfiguration. 
        /// <para>
        /// The configuration for a snapshot retention optimizer.
        /// </para>
        /// </summary>
        public RetentionConfiguration RetentionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the RetentionConfiguration property is set.
        /// </summary>
        internal bool IsSetRetentionConfiguration() => this.RetentionConfiguration != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// A role passed by the caller which gives the service permission to update the resources
        /// associated with the optimizer on the caller's behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

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
        public TableOptimizerVpcConfiguration VpcConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfiguration property is set.
        /// </summary>
        internal bool IsSetVpcConfiguration() => this.VpcConfiguration != null;
    }
}
