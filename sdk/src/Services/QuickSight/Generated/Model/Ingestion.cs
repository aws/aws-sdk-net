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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Information about the SPICE ingestion for a dataset.
    /// </summary>
    public partial class Ingestion
    {
        private string _arn;
        private DateTime? _createdTime;
        private ErrorInfo _errorInfo;
        private string _ingestionId;
        private long? _ingestionSizeInBytes;
        private IngestionStatus _ingestionStatus;
        private long? _ingestionTimeInSeconds;
        private QueueInfo _queueInfo;
        private IngestionRequestSource _requestSource;
        private IngestionRequestType _requestType;
        private RowInfo _rowInfo;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this ingestion started.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error information for this ingestion.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo
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
        /// Gets and sets the property IngestionId. 
        /// <para>
        /// Ingestion ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IngestionId
        {
            get { return this._ingestionId; }
            set { this._ingestionId = value; }
        }

        // Check to see if IngestionId property is set
        internal bool IsSetIngestionId()
        {
            return this._ingestionId != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionSizeInBytes. 
        /// <para>
        /// The size of the data ingested, in bytes.
        /// </para>
        /// </summary>
        public long? IngestionSizeInBytes
        {
            get { return this._ingestionSizeInBytes; }
            set { this._ingestionSizeInBytes = value; }
        }

        // Check to see if IngestionSizeInBytes property is set
        internal bool IsSetIngestionSizeInBytes()
        {
            return this._ingestionSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestionStatus. 
        /// <para>
        /// Ingestion status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IngestionStatus IngestionStatus
        {
            get { return this._ingestionStatus; }
            set { this._ingestionStatus = value; }
        }

        // Check to see if IngestionStatus property is set
        internal bool IsSetIngestionStatus()
        {
            return this._ingestionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property IngestionTimeInSeconds. 
        /// <para>
        /// The time that this ingestion took, measured in seconds.
        /// </para>
        /// </summary>
        public long? IngestionTimeInSeconds
        {
            get { return this._ingestionTimeInSeconds; }
            set { this._ingestionTimeInSeconds = value; }
        }

        // Check to see if IngestionTimeInSeconds property is set
        internal bool IsSetIngestionTimeInSeconds()
        {
            return this._ingestionTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueueInfo.
        /// </summary>
        public QueueInfo QueueInfo
        {
            get { return this._queueInfo; }
            set { this._queueInfo = value; }
        }

        // Check to see if QueueInfo property is set
        internal bool IsSetQueueInfo()
        {
            return this._queueInfo != null;
        }

        /// <summary>
        /// Gets and sets the property RequestSource. 
        /// <para>
        /// Event source for this ingestion.
        /// </para>
        /// </summary>
        public IngestionRequestSource RequestSource
        {
            get { return this._requestSource; }
            set { this._requestSource = value; }
        }

        // Check to see if RequestSource property is set
        internal bool IsSetRequestSource()
        {
            return this._requestSource != null;
        }

        /// <summary>
        /// Gets and sets the property RequestType. 
        /// <para>
        /// Type of this ingestion.
        /// </para>
        /// </summary>
        public IngestionRequestType RequestType
        {
            get { return this._requestType; }
            set { this._requestType = value; }
        }

        // Check to see if RequestType property is set
        internal bool IsSetRequestType()
        {
            return this._requestType != null;
        }

        /// <summary>
        /// Gets and sets the property RowInfo.
        /// </summary>
        public RowInfo RowInfo
        {
            get { return this._rowInfo; }
            set { this._rowInfo = value; }
        }

        // Check to see if RowInfo property is set
        internal bool IsSetRowInfo()
        {
            return this._rowInfo != null;
        }

    }
}