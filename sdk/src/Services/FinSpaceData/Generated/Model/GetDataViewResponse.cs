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

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Response from retrieving a dataview, which includes details on the target database
    /// and table name
    /// </summary>
    public partial class GetDataViewResponse : AmazonWebServiceResponse
    {
        private long? _asOfTimestamp;
        private bool? _autoUpdate;
        private long? _createTime;
        private string _datasetId;
        private string _dataViewArn;
        private string _dataViewId;
        private DataViewDestinationTypeParams _destinationTypeParams;
        private DataViewErrorInfo _errorInfo;
        private long? _lastModifiedTime;
        private List<string> _partitionColumns = new List<string>();
        private List<string> _sortColumns = new List<string>();
        private DataViewStatus _status;

        /// <summary>
        /// Gets and sets the property AsOfTimestamp. 
        /// <para>
        /// Time range to use for the Dataview. The value is determined as epoch time in milliseconds.
        /// For example, the value for Monday, November 1, 2021 12:00:00 PM UTC is specified as
        /// 1635768000000.
        /// </para>
        /// </summary>
        public long AsOfTimestamp
        {
            get { return this._asOfTimestamp.GetValueOrDefault(); }
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
        public bool AutoUpdate
        {
            get { return this._autoUpdate.GetValueOrDefault(); }
            set { this._autoUpdate = value; }
        }

        // Check to see if AutoUpdate property is set
        internal bool IsSetAutoUpdate()
        {
            return this._autoUpdate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The timestamp at which the Dataview was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public long CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetId. 
        /// <para>
        /// The unique identifier for the Dataset used in the Dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
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
        /// Gets and sets the property DataViewArn. 
        /// <para>
        /// The ARN identifier of the Dataview.
        /// </para>
        /// </summary>
        public string DataViewArn
        {
            get { return this._dataViewArn; }
            set { this._dataViewArn = value; }
        }

        // Check to see if DataViewArn property is set
        internal bool IsSetDataViewArn()
        {
            return this._dataViewArn != null;
        }

        /// <summary>
        /// Gets and sets the property DataViewId. 
        /// <para>
        /// The unique identifier for the Dataview.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string DataViewId
        {
            get { return this._dataViewId; }
            set { this._dataViewId = value; }
        }

        // Check to see if DataViewId property is set
        internal bool IsSetDataViewId()
        {
            return this._dataViewId != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTypeParams. 
        /// <para>
        /// Options that define the destination type for the Dataview.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Information about an error that occurred for the Dataview.
        /// </para>
        /// </summary>
        public DataViewErrorInfo ErrorInfo
        {
            get { return this._errorInfo; }
            set { this._errorInfo = value; }
        }

        // Check to see if ErrorInfo property is set
        internal bool IsSetErrorInfo()
        {
            return this._errorInfo != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The last time that a Dataview was modified. The value is determined as epoch time
        /// in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00 PM UTC
        /// is specified as 1635768000000.
        /// </para>
        /// </summary>
        public long LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartitionColumns. 
        /// <para>
        /// Ordered set of column names used to partition data.
        /// </para>
        /// </summary>
        public List<string> PartitionColumns
        {
            get { return this._partitionColumns; }
            set { this._partitionColumns = value; }
        }

        // Check to see if PartitionColumns property is set
        internal bool IsSetPartitionColumns()
        {
            return this._partitionColumns != null && this._partitionColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SortColumns. 
        /// <para>
        /// Columns to be used for sorting the data.
        /// </para>
        /// </summary>
        public List<string> SortColumns
        {
            get { return this._sortColumns; }
            set { this._sortColumns = value; }
        }

        // Check to see if SortColumns property is set
        internal bool IsSetSortColumns()
        {
            return this._sortColumns != null && this._sortColumns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of a Dataview creation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>RUNNING</code> – Dataview creation is running.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>STARTING</code> – Dataview creation is starting.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> – Dataview creation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CANCELLED</code> – Dataview creation has been cancelled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TIMEOUT</code> – Dataview creation has timed out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCESS</code> – Dataview creation has succeeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code> – Dataview creation is pending.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED_CLEANUP_FAILED</code> – Dataview creation failed and resource cleanup
        /// failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DataViewStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}