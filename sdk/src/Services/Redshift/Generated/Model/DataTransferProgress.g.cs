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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of a cluster while it is in the process of resizing with an incremental
    /// resize.
    /// </summary>
    public partial class DataTransferProgress
    {
        /// <summary>
        /// Gets and sets the property CurrentRateInMegaBytesPerSecond. 
        /// <para>
        /// Describes the data transfer rate in MB's per second.
        /// </para>
        /// </summary>
        public double? CurrentRateInMegaBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRateInMegaBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetCurrentRateInMegaBytesPerSecond() => this.CurrentRateInMegaBytesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property DataTransferredInMegaBytes. 
        /// <para>
        /// Describes the total amount of data that has been transfered in MB's.
        /// </para>
        /// </summary>
        public long? DataTransferredInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the DataTransferredInMegaBytes property is set.
        /// </summary>
        internal bool IsSetDataTransferredInMegaBytes() => this.DataTransferredInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// Describes the number of seconds that have elapsed during the data transfer.
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetElapsedTimeInSeconds() => this.ElapsedTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompletionInSeconds. 
        /// <para>
        /// Describes the estimated number of seconds remaining to complete the transfer.
        /// </para>
        /// </summary>
        public long? EstimatedTimeToCompletionInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeToCompletionInSeconds property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeToCompletionInSeconds() => this.EstimatedTimeToCompletionInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Describes the status of the cluster. While the transfer is in progress the status
        /// is <c>transferringdata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalDataInMegaBytes. 
        /// <para>
        /// Describes the total amount of data to be transfered in megabytes.
        /// </para>
        /// </summary>
        public long? TotalDataInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the TotalDataInMegaBytes property is set.
        /// </summary>
        internal bool IsSetTotalDataInMegaBytes() => this.TotalDataInMegaBytes.HasValue;
    }
}
