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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDataView operation.
    /// Creates a Dataview for a Dataset.
    /// </summary>
    public partial class CreateDataViewRequest : AmazonFinSpaceDataRequest
    {
        private long? _asOfTimestamp;
        private bool? _autoUpdate;
        private string _clientToken;
        private string _datasetId;
        private DataViewDestinationTypeParams _destinationTypeParams;
        private List<string> _partitionColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sortColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AsOfTimestamp. 
        /// <para>
        /// Beginning time to use for the Dataview. The value is determined as epoch time in milliseconds.
        /// For example, the value for Monday, November 1, 2021 12:00:00 PM UTC is specified as
        /// 1635768000000.
        /// </para>
        /// </summary>
        public long? AsOfTimestamp
        {
            get { return this._asOfTimestamp; }
            set { this._asOfTimestamp = value; }
        }

        // Check to see if AsOfTimestamp property is set
        internal bool IsSetAsOfTimestamp()
        {
            return this._asOfTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// Flag to indicate Dataview should be updated automatically.
        /// </para>
        /// </summary>
        public bool? AutoUpdate
        {
            get { return this._autoUpdate; }
            set { this._autoUpdate = value; }
        }

        // Check to see if AutoUpdate property is set
        internal bool IsSetAutoUpdate()
        {
            return this._autoUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique Dataset identifier that is used to create a Dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
        public string DatasetId
        {
            get { return this._datasetId; }
            set { this._datasetId = value; }
        }

        // Check to see if DatasetId property is set
        internal bool IsSetDatasetId()
        {
            return this._datasetId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTypeParams. 
        /// <para>
        /// Options that define the destination type for the Dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataViewDestinationTypeParams DestinationTypeParams
        {
            get { return this._destinationTypeParams; }
            set { this._destinationTypeParams = value; }
        }

        // Check to see if DestinationTypeParams property is set
        internal bool IsSetDestinationTypeParams()
        {
            return this._destinationTypeParams != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionColumns. 
        /// <para>
        /// Ordered set of column names used to partition data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PartitionColumns
        {
            get { return this._partitionColumns; }
            set { this._partitionColumns = value; }
        }

        // Check to see if PartitionColumns property is set
        internal bool IsSetPartitionColumns()
        {
            return this._partitionColumns != null && (this._partitionColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SortColumns. 
        /// <para>
        /// Columns to be used for sorting the data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SortColumns
        {
            get { return this._sortColumns; }
            set { this._sortColumns = value; }
        }

        // Check to see if SortColumns property is set
        internal bool IsSetSortColumns()
        {
            return this._sortColumns != null && (this._sortColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}