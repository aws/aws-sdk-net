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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Information about the SPICE ingestion for a dataset.
    /// </summary>
    public partial class Ingestion
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The time that this ingestion started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorInfo. 
        /// <para>
        /// Error information for this ingestion.
        /// </para>
        /// </summary>
        public ErrorInfo ErrorInfo { get; set; }

        /// <summary>
        /// Checks to see if the ErrorInfo property is set.
        /// </summary>
        internal bool IsSetErrorInfo() => this.ErrorInfo != null;

        /// <summary>
        /// Gets and sets the property IngestionId. 
        /// <para>
        /// Ingestion ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string IngestionId { get; set; }

        /// <summary>
        /// Checks to see if the IngestionId property is set.
        /// </summary>
        internal bool IsSetIngestionId() => this.IngestionId != null;

        /// <summary>
        /// Gets and sets the property IngestionSizeInBytes. 
        /// <para>
        /// The size of the data ingested, in bytes.
        /// </para>
        /// </summary>
        public long? IngestionSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the IngestionSizeInBytes property is set.
        /// </summary>
        internal bool IsSetIngestionSizeInBytes() => this.IngestionSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property IngestionStatus. 
        /// <para>
        /// Ingestion status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngestionStatus IngestionStatus { get; set; }

        /// <summary>
        /// Checks to see if the IngestionStatus property is set.
        /// </summary>
        internal bool IsSetIngestionStatus() => this.IngestionStatus != null;

        /// <summary>
        /// Gets and sets the property IngestionTimeInSeconds. 
        /// <para>
        /// The time that this ingestion took, measured in seconds.
        /// </para>
        /// </summary>
        public long? IngestionTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the IngestionTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetIngestionTimeInSeconds() => this.IngestionTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property QueueInfo.
        /// </summary>
        public QueueInfo QueueInfo { get; set; }

        /// <summary>
        /// Checks to see if the QueueInfo property is set.
        /// </summary>
        internal bool IsSetQueueInfo() => this.QueueInfo != null;

        /// <summary>
        /// Gets and sets the property RequestSource. 
        /// <para>
        /// Event source for this ingestion.
        /// </para>
        /// </summary>
        public IngestionRequestSource RequestSource { get; set; }

        /// <summary>
        /// Checks to see if the RequestSource property is set.
        /// </summary>
        internal bool IsSetRequestSource() => this.RequestSource != null;

        /// <summary>
        /// Gets and sets the property RequestType. 
        /// <para>
        /// Type of this ingestion.
        /// </para>
        /// </summary>
        public IngestionRequestType RequestType { get; set; }

        /// <summary>
        /// Checks to see if the RequestType property is set.
        /// </summary>
        internal bool IsSetRequestType() => this.RequestType != null;

        /// <summary>
        /// Gets and sets the property RowInfo.
        /// </summary>
        public RowInfo RowInfo { get; set; }

        /// <summary>
        /// Checks to see if the RowInfo property is set.
        /// </summary>
        internal bool IsSetRowInfo() => this.RowInfo != null;
    }
}
