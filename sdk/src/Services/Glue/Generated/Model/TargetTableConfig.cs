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
    /// Properties used by the target leg to partition the data on the target.
    /// </summary>
    public partial class TargetTableConfig
    {
        private List<IntegrationPartition> _partitionSpec = AWSConfigs.InitializeCollections ? new List<IntegrationPartition>() : null;
        private string _targetTableName;
        private UnnestSpec _unnestSpec;

        /// <summary>
        /// Gets and sets the property PartitionSpec. 
        /// <para>
        /// Determines the file layout on the target.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegrationPartition> PartitionSpec
        {
            get { return this._partitionSpec; }
            set { this._partitionSpec = value; }
        }

        // Check to see if PartitionSpec property is set
        internal bool IsSetPartitionSpec()
        {
            return this._partitionSpec != null && (this._partitionSpec.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetTableName. 
        /// <para>
        /// The optional name of a target table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string TargetTableName
        {
            get { return this._targetTableName; }
            set { this._targetTableName = value; }
        }

        // Check to see if TargetTableName property is set
        internal bool IsSetTargetTableName()
        {
            return this._targetTableName != null;
        }

        /// <summary>
        /// Gets and sets the property UnnestSpec. 
        /// <para>
        /// Specifies how nested objects are flattened to top-level elements. Valid values are:
        /// "TOPLEVEL", "FULL", or "NOUNNEST".
        /// </para>
        /// </summary>
        public UnnestSpec UnnestSpec
        {
            get { return this._unnestSpec; }
            set { this._unnestSpec = value; }
        }

        // Check to see if UnnestSpec property is set
        internal bool IsSetUnnestSpec()
        {
            return this._unnestSpec != null;
        }

    }
}