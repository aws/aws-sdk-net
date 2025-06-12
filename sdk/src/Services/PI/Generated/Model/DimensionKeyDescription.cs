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
 * Do not modify this file. This file is generated from the pi-2018-02-27.normal.json service model.
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
namespace Amazon.PI.Model
{
    /// <summary>
    /// An object that includes the requested dimension key values and aggregated metric values
    /// within a dimension group.
    /// </summary>
    public partial class DimensionKeyDescription
    {
        private Dictionary<string, double> _additionalMetrics = AWSConfigs.InitializeCollections ? new Dictionary<string, double>() : null;
        private Dictionary<string, string> _dimensions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<double> _partitions = AWSConfigs.InitializeCollections ? new List<double>() : null;
        private double? _total;

        /// <summary>
        /// Gets and sets the property AdditionalMetrics. 
        /// <para>
        /// A map that contains the value for each additional metric.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, double> AdditionalMetrics
        {
            get { return this._additionalMetrics; }
            set { this._additionalMetrics = value; }
        }

        // Check to see if AdditionalMetrics property is set
        internal bool IsSetAdditionalMetrics()
        {
            return this._additionalMetrics != null && (this._additionalMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// A map of name-value pairs for the dimensions in the group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && (this._dimensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Partitions. 
        /// <para>
        /// If <c>PartitionBy</c> was specified, <c>PartitionKeys</c> contains the dimensions
        /// that were.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<double> Partitions
        {
            get { return this._partitions; }
            set { this._partitions = value; }
        }

        // Check to see if Partitions property is set
        internal bool IsSetPartitions()
        {
            return this._partitions != null && (this._partitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Total. 
        /// <para>
        /// The aggregated metric value for the dimensions, over the requested time range.
        /// </para>
        /// </summary>
        public double? Total
        {
            get { return this._total; }
            set { this._total = value; }
        }

        // Check to see if Total property is set
        internal bool IsSetTotal()
        {
            return this._total.HasValue; 
        }

    }
}