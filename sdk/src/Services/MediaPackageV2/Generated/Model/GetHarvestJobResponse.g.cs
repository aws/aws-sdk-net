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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// This is the response object from the GetHarvestJob operation.
    /// </summary>
    public partial class GetHarvestJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the harvest job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ChannelGroupName. 
        /// <para>
        /// The name of the channel group containing the channel associated with the harvest job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelGroupName property is set.
        /// </summary>
        internal bool IsSetChannelGroupName() => this.ChannelGroupName != null;

        /// <summary>
        /// Gets and sets the property ChannelName. 
        /// <para>
        /// The name of the channel associated with the harvest job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ChannelName { get; set; }

        /// <summary>
        /// Checks to see if the ChannelName property is set.
        /// </summary>
        internal bool IsSetChannelName() => this.ChannelName != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the harvest job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the harvest job, if provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The S3 destination where the harvested content is being placed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Destination Destination { get; set; }

        /// <summary>
        /// Checks to see if the Destination property is set.
        /// </summary>
        internal bool IsSetDestination() => this.Destination != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The current version of the harvest job. Used for concurrency control.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message if the harvest job encountered any issues.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property HarvestJobName. 
        /// <para>
        /// The name of the harvest job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string HarvestJobName { get; set; }

        /// <summary>
        /// Checks to see if the HarvestJobName property is set.
        /// </summary>
        internal bool IsSetHarvestJobName() => this.HarvestJobName != null;

        /// <summary>
        /// Gets and sets the property HarvestedManifests. 
        /// <para>
        /// A list of manifests that are being or have been harvested.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarvestedManifests HarvestedManifests { get; set; }

        /// <summary>
        /// Checks to see if the HarvestedManifests property is set.
        /// </summary>
        internal bool IsSetHarvestedManifests() => this.HarvestedManifests != null;

        /// <summary>
        /// Gets and sets the property ModifiedAt. 
        /// <para>
        /// The date and time when the harvest job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAt property is set.
        /// </summary>
        internal bool IsSetModifiedAt() => this.ModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property OriginEndpointName. 
        /// <para>
        /// The name of the origin endpoint associated with the harvest job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginEndpointName { get; set; }

        /// <summary>
        /// Checks to see if the OriginEndpointName property is set.
        /// </summary>
        internal bool IsSetOriginEndpointName() => this.OriginEndpointName != null;

        /// <summary>
        /// Gets and sets the property ScheduleConfiguration. 
        /// <para>
        /// The configuration for when the harvest job is scheduled to run, including start and
        /// end times.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarvesterScheduleConfiguration ScheduleConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleConfiguration property is set.
        /// </summary>
        internal bool IsSetScheduleConfiguration() => this.ScheduleConfiguration != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the harvest job (e.g., QUEUED, IN_PROGRESS, CANCELLED, COMPLETED,
        /// FAILED).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HarvestJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A collection of tags associated with the harvest job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
