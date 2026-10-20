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
    /// This is the response object from the DescribeChannel operation.
    /// </summary>
    public partial class DescribeChannelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) assigned to the Channel.
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. The date and time the Channel was created.
        /// </summary>
        public string CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt != null;

        /// <summary>
        /// Gets and sets the property Description. A short text description of the Channel.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EgressAccessLogs.
        /// </summary>
        public EgressAccessLogs EgressAccessLogs { get; set; }

        /// <summary>
        /// Checks to see if the EgressAccessLogs property is set.
        /// </summary>
        internal bool IsSetEgressAccessLogs() => this.EgressAccessLogs != null;

        /// <summary>
        /// Gets and sets the property HlsIngest.
        /// </summary>
        public HlsIngest HlsIngest { get; set; }

        /// <summary>
        /// Checks to see if the HlsIngest property is set.
        /// </summary>
        internal bool IsSetHlsIngest() => this.HlsIngest != null;

        /// <summary>
        /// Gets and sets the property Id. The ID of the Channel.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IngressAccessLogs.
        /// </summary>
        public IngressAccessLogs IngressAccessLogs { get; set; }

        /// <summary>
        /// Checks to see if the IngressAccessLogs property is set.
        /// </summary>
        internal bool IsSetIngressAccessLogs() => this.IngressAccessLogs != null;

        /// <summary>
        /// Gets and sets the property Tags.
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
