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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// This is the response object from the DescribePublishingDestination operation.
    /// </summary>
    public partial class DescribePublishingDestinationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DestinationId. 
        /// <para>
        /// The ID of the publishing destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationId property is set.
        /// </summary>
        internal bool IsSetDestinationId() => this.DestinationId != null;

        /// <summary>
        /// Gets and sets the property DestinationProperties. 
        /// <para>
        /// A <c>DestinationProperties</c> object that includes the <c>DestinationArn</c> and
        /// <c>KmsKeyArn</c> of the publishing destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DestinationProperties DestinationProperties { get; set; }

        /// <summary>
        /// Checks to see if the DestinationProperties property is set.
        /// </summary>
        internal bool IsSetDestinationProperties() => this.DestinationProperties != null;

        /// <summary>
        /// Gets and sets the property DestinationType. 
        /// <para>
        /// The type of publishing destination. Currently, only Amazon S3 buckets are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public DestinationType DestinationType { get; set; }

        /// <summary>
        /// Checks to see if the DestinationType property is set.
        /// </summary>
        internal bool IsSetDestinationType() => this.DestinationType != null;

        /// <summary>
        /// Gets and sets the property PublishingFailureStartTimestamp. 
        /// <para>
        /// The time, in epoch millisecond format, at which GuardDuty was first unable to publish
        /// findings to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? PublishingFailureStartTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the PublishingFailureStartTimestamp property is set.
        /// </summary>
        internal bool IsSetPublishingFailureStartTimestamp() => this.PublishingFailureStartTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the publishing destination.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 300)]
        public PublishingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags of the publishing destination resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
