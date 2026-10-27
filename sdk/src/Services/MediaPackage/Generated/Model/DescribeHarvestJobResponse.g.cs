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

namespace Amazon.MediaPackage.Model
{
    /// <summary>
    /// This is the response object from the DescribeHarvestJob operation.
    /// </summary>
    public partial class DescribeHarvestJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) assigned to the HarvestJob.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChannelId. The ID of the Channel that the HarvestJob will
        /// harvest from.
        /// </summary>
        public string ChannelId { get; set; }

        /// <summary>
        /// Checks to see if the ChannelId property is set.
        /// </summary>
        internal bool IsSetChannelId() => this.ChannelId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time the HarvestJob was submitted.
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property EndTime. The end of the time-window which will be harvested.
        /// </summary>
        public string EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime != null;

        /// <summary>
        /// Gets and sets the property Id. The ID of the HarvestJob. The ID must be unique within
        /// the region and it cannot be changed after the HarvestJob is submitted.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property OriginEndpointId. The ID of the OriginEndpoint that the
        /// HarvestJob will harvest from. This cannot be changed after the HarvestJob is submitted.
        /// </summary>
        public string OriginEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the OriginEndpointId property is set.
        /// </summary>
        internal bool IsSetOriginEndpointId() => this.OriginEndpointId != null;

        /// <summary>
        /// Gets and sets the property S3Destination.
        /// </summary>
        public S3Destination S3Destination { get; set; }

        /// <summary>
        /// Checks to see if the S3Destination property is set.
        /// </summary>
        internal bool IsSetS3Destination() => this.S3Destination != null;

        /// <summary>
        /// Gets and sets the property StartTime. The start of the time-window which will be harvested.
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Status. The current status of the HarvestJob. Consider
        /// setting up a CloudWatch Event to listen for HarvestJobs as they succeed or fail. In
        /// the event of failure, the CloudWatch Event will include an explanation of why the
        /// HarvestJob failed.
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
