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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// This is the response object from the DescribePipe operation.
    /// </summary>
    public partial class DescribePipeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the pipe was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentState. 
        /// <para>
        /// The state the pipe is in.
        /// </para>
        /// </summary>
        public PipeState CurrentState { get; set; }

        /// <summary>
        /// Checks to see if the CurrentState property is set.
        /// </summary>
        internal bool IsSetCurrentState() => this.CurrentState != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 512)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DesiredState. 
        /// <para>
        /// The state the pipe should be in.
        /// </para>
        /// </summary>
        public RequestedPipeStateDescribeResponse DesiredState { get; set; }

        /// <summary>
        /// Checks to see if the DesiredState property is set.
        /// </summary>
        internal bool IsSetDesiredState() => this.DesiredState != null;

        /// <summary>
        /// Gets and sets the property Enrichment. 
        /// <para>
        /// The ARN of the enrichment resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1600)]
        public string Enrichment { get; set; }

        /// <summary>
        /// Checks to see if the Enrichment property is set.
        /// </summary>
        internal bool IsSetEnrichment() => this.Enrichment != null;

        /// <summary>
        /// Gets and sets the property EnrichmentParameters. 
        /// <para>
        /// The parameters required to set up enrichment on your pipe.
        /// </para>
        /// </summary>
        public PipeEnrichmentParameters EnrichmentParameters { get; set; }

        /// <summary>
        /// Checks to see if the EnrichmentParameters property is set.
        /// </summary>
        internal bool IsSetEnrichmentParameters() => this.EnrichmentParameters != null;

        /// <summary>
        /// Gets and sets the property KmsKeyIdentifier. 
        /// <para>
        /// The identifier of the KMS customer managed key for EventBridge to use to encrypt pipe
        /// data, if one has been specified.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-encryption.html">Data
        /// encryption in EventBridge</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetKmsKeyIdentifier() => this.KmsKeyIdentifier != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the pipe was last updated, in <a href="https://www.w3.org/TR/NOTE-datetime">ISO-8601
        /// format</a> (YYYY-MM-DDThh:mm:ss.sTZD).
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LogConfiguration. 
        /// <para>
        /// The logging configuration settings for the pipe.
        /// </para>
        /// </summary>
        public PipeLogConfiguration LogConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LogConfiguration property is set.
        /// </summary>
        internal bool IsSetLogConfiguration() => this.LogConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the pipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that allows the pipe to send data to the target.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The ARN of the source resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property SourceParameters. 
        /// <para>
        /// The parameters required to set up a source for your pipe.
        /// </para>
        /// </summary>
        public PipeSourceParameters SourceParameters { get; set; }

        /// <summary>
        /// Checks to see if the SourceParameters property is set.
        /// </summary>
        internal bool IsSetSourceParameters() => this.SourceParameters != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason the pipe is in its current state.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value pairs to associate with the pipe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The ARN of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TargetParameters. 
        /// <para>
        /// The parameters required to set up a target for your pipe.
        /// </para>
        ///  
        /// <para>
        /// For more information about pipe target parameters, including how to use dynamic path
        /// parameters, see <a href="https://docs.aws.amazon.com/eventbridge/latest/userguide/eb-pipes-event-target.html">Target
        /// parameters</a> in the <i>Amazon EventBridge User Guide</i>.
        /// </para>
        /// </summary>
        public PipeTargetParameters TargetParameters { get; set; }

        /// <summary>
        /// Checks to see if the TargetParameters property is set.
        /// </summary>
        internal bool IsSetTargetParameters() => this.TargetParameters != null;
    }
}
