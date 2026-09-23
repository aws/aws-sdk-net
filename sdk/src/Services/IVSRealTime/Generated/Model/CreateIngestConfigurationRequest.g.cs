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

namespace Amazon.IVSRealTime.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIngestConfiguration operation. Creates a
    /// new IngestConfiguration resource, used to specify the ingest protocol for a stage.
    /// </summary>
    public partial class CreateIngestConfigurationRequest : AmazonIVSRealTimeRequest
    {
        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Application-provided attributes to store in the IngestConfiguration and attach to
        /// a stage. Map keys and values can contain UTF-8 encoded text. The maximum length of
        /// this field is 1 KB total. <i>This field is exposed to all stage participants and should
        /// not be used for personally identifying, confidential, or sensitive information.</i>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Attributes property is set.
        /// </summary>
        internal bool IsSetAttributes() => this.Attributes != null && (this.Attributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IngestProtocol. 
        /// <para>
        /// Type of ingest protocol that the user employs to broadcast. If this is set to <c>RTMP</c>,
        /// <c>insecureIngest</c> must be set to <c>true</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngestProtocol IngestProtocol { get; set; }

        /// <summary>
        /// Checks to see if the IngestProtocol property is set.
        /// </summary>
        internal bool IsSetIngestProtocol() => this.IngestProtocol != null;

        /// <summary>
        /// Gets and sets the property InsecureIngest. 
        /// <para>
        /// Whether the stage allows insecure RTMP ingest. This must be set to <c>true</c>, if
        /// <c>ingestProtocol</c> is set to <c>RTMP</c>. Default: <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? InsecureIngest { get; set; }

        /// <summary>
        /// Checks to see if the InsecureIngest property is set.
        /// </summary>
        internal bool IsSetInsecureIngest() => this.InsecureIngest.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Optional name that can be specified for the IngestConfiguration being created.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RedundantIngest. 
        /// <para>
        /// Indicates whether redundant ingest is enabled for the ingest configuration. Default:
        /// <c>false</c>. 
        /// </para>
        /// </summary>
        public bool? RedundantIngest { get; set; }

        /// <summary>
        /// Checks to see if the RedundantIngest property is set.
        /// </summary>
        internal bool IsSetRedundantIngest() => this.RedundantIngest.HasValue;

        /// <summary>
        /// Gets and sets the property StageArn. 
        /// <para>
        /// ARN of the stage with which the IngestConfiguration is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string StageArn { get; set; }

        /// <summary>
        /// Checks to see if the StageArn property is set.
        /// </summary>
        internal bool IsSetStageArn() => this.StageArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the resource. Array of maps, each of the form <c>string:string (key:value)</c>.
        /// See <a href="https://docs.aws.amazon.com/tag-editor/latest/userguide/best-practices-and-strats.html">Best
        /// practices and strategies</a> in <i>Tagging AWS Resources and Tag Editor</i> for details,
        /// including restrictions that apply to tags and "Tag naming limits and requirements";
        /// Amazon IVS has no constraints on tags beyond what is documented there.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// Customer-assigned name to help identify the participant using the IngestConfiguration;
        /// this can be used to link a participant to a user in the customer’s own systems. This
        /// can be any UTF-8 encoded text. <i>This field is exposed to all stage participants
        /// and should not be used for personally identifying, confidential, or sensitive information.</i>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
