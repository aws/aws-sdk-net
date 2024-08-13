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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of a cluster while it is in the process of resizing with an incremental
    /// resize.
    /// </summary>
    public partial class DataTransferProgress
    {
        private double? _currentRateInMegaBytesPerSecond;
        private long? _dataTransferredInMegaBytes;
        private long? _elapsedTimeInSeconds;
        private long? _estimatedTimeToCompletionInSeconds;
        private string _status;
        private long? _totalDataInMegaBytes;

        /// <summary>
        /// Gets and sets the property CurrentRateInMegaBytesPerSecond. 
        /// <para>
        /// Describes the data transfer rate in MB's per second.
        /// </para>
        /// </summary>
        public double? CurrentRateInMegaBytesPerSecond
        {
            get { return this._currentRateInMegaBytesPerSecond; }
            set { this._currentRateInMegaBytesPerSecond = value; }
        }

        // Check to see if CurrentRateInMegaBytesPerSecond property is set
        internal bool IsSetCurrentRateInMegaBytesPerSecond()
        {
            return this._currentRateInMegaBytesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataTransferredInMegaBytes. 
        /// <para>
        /// Describes the total amount of data that has been transfered in MB's.
        /// </para>
        /// </summary>
        public long? DataTransferredInMegaBytes
        {
            get { return this._dataTransferredInMegaBytes; }
            set { this._dataTransferredInMegaBytes = value; }
        }

        // Check to see if DataTransferredInMegaBytes property is set
        internal bool IsSetDataTransferredInMegaBytes()
        {
            return this._dataTransferredInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// Describes the number of seconds that have elapsed during the data transfer.
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds
        {
            get { return this._elapsedTimeInSeconds; }
            set { this._elapsedTimeInSeconds = value; }
        }

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this._elapsedTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompletionInSeconds. 
        /// <para>
        /// Describes the estimated number of seconds remaining to complete the transfer.
        /// </para>
        /// </summary>
        public long? EstimatedTimeToCompletionInSeconds
        {
            get { return this._estimatedTimeToCompletionInSeconds; }
            set { this._estimatedTimeToCompletionInSeconds = value; }
        }

        // Check to see if EstimatedTimeToCompletionInSeconds property is set
        internal bool IsSetEstimatedTimeToCompletionInSeconds()
        {
            return this._estimatedTimeToCompletionInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes the status of the cluster. While the transfer is in progress the status
        /// is <c>transferringdata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2147483647)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property TotalDataInMegaBytes. 
        /// <para>
        /// Describes the total amount of data to be transfered in megabytes.
        /// </para>
        /// </summary>
        public long? TotalDataInMegaBytes
        {
            get { return this._totalDataInMegaBytes; }
            set { this._totalDataInMegaBytes = value; }
        }

        // Check to see if TotalDataInMegaBytes property is set
        internal bool IsSetTotalDataInMegaBytes()
        {
            return this._totalDataInMegaBytes.HasValue; 
        }

    }
}