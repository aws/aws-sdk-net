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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// This is the response object from the CreateFeed operation.
    /// </summary>
    public partial class CreateFeedResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that you specified in the request. This property is absent if you didn't specify an
        /// IAM role. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 255)]
        public string AccessRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the AccessRoleArn property is set.
        /// </summary>
        internal bool IsSetAccessRoleArn() => this.AccessRoleArn != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// A unique ARN that Elemental Inference assigns to the feed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Association. 
        /// <para>
        /// The association for this feed. When you create the feed, this property is empty. You
        /// must associate a resource with the feed using AssociateFeed or UpdateFeed. 
        /// </para>
        /// </summary>
        public FeedAssociation Association { get; set; }

        /// <summary>
        /// Checks to see if the Association property is set.
        /// </summary>
        internal bool IsSetAssociation() => this.Association != null;

        /// <summary>
        /// Gets and sets the property DataEndpoints. 
        /// <para>
        /// An array of endpoints for the feed. Typically, there is only one endpoint. The feed
        /// receives source media at this endpoint (when the calling application calls PutMedia)
        /// and returns the resulting metadata to this endpoint (when the calling application
        /// calls GetMetadata). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> DataEndpoints { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DataEndpoints property is set.
        /// </summary>
        internal bool IsSetDataEndpoints() => this.DataEndpoints != null && (this.DataEndpoints.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique ID that Elemental Inference assigns to the feed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name that you specified in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Outputs. 
        /// <para>
        /// Repeats the outputs that you specified in the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<GetOutput> Outputs { get; set; } = AWSConfigs.InitializeCollections ? new List<GetOutput>() : null;

        /// <summary>
        /// Checks to see if the Outputs property is set.
        /// </summary>
        internal bool IsSetOutputs() => this.Outputs != null && (this.Outputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the feed. After creation of the feed has succeeded, the status
        /// will be AVAILABLE. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FeedStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags that you included when you created the feed.
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
