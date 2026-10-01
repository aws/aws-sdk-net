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

namespace Amazon.DSQL.Model
{
    /// <summary>
    /// This is the response object from the GetStream operation.
    /// </summary>
    public partial class GetStreamResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the retrieved stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property ClusterIdentifier. 
        /// <para>
        /// The ID of the cluster for the retrieved stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetClusterIdentifier() => this.ClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the stream was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Format. 
        /// <para>
        /// The format of the stream records.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamFormat Format { get; set; }

        /// <summary>
        /// Checks to see if the Format property is set.
        /// </summary>
        internal bool IsSetFormat() => this.Format != null;

        /// <summary>
        /// Gets and sets the property Ordering. 
        /// <para>
        /// The ordering mode of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamOrdering Ordering { get; set; }

        /// <summary>
        /// Checks to see if the Ordering property is set.
        /// </summary>
        internal bool IsSetOrdering() => this.Ordering != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the retrieved stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StreamStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Stream status reason with error code and timestamp (if applicable).
        /// </para>
        /// </summary>
        public StatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property StreamIdentifier. 
        /// <para>
        /// The ID of the retrieved stream.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string StreamIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the StreamIdentifier property is set.
        /// </summary>
        internal bool IsSetStreamIdentifier() => this.StreamIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tags associated with the stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TargetDefinition. 
        /// <para>
        /// The target definition for the stream destination.
        /// </para>
        /// </summary>
        public TargetDefinition TargetDefinition { get; set; }

        /// <summary>
        /// Checks to see if the TargetDefinition property is set.
        /// </summary>
        internal bool IsSetTargetDefinition() => this.TargetDefinition != null;
    }
}
