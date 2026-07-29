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
    /// The distribution data for a statistic.
    /// </summary>
    public partial class DistributionData
    {
        private List<string> _binEdges = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<int> _count = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private string _dataType;

        /// <summary>
        /// Gets and sets the property BinEdges. 
        /// <para>
        /// The bin edge values for the distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BinEdges
        {
            get { return this._binEdges; }
            set { this._binEdges = value; }
        }

        // Check to see if BinEdges property is set
        internal bool IsSetBinEdges()
        {
            return this._binEdges != null && (this._binEdges.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The frequency count for each bin in the distribution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count != null && (this._count.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The data type of the column for the distribution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DataType
        {
            get { return this._dataType; }
            set { this._dataType = value; }
        }

        // Check to see if DataType property is set
        internal bool IsSetDataType()
        {
            return this._dataType != null;
        }

    }
}