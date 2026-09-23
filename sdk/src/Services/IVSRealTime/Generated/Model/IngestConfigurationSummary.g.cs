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
    /// Summary information about an IngestConfiguration.
    /// </summary>
    public partial class IngestConfigurationSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Ingest configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property IngestProtocol. 
        /// <para>
        /// Type of ingest protocol that the user employs for broadcasting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngestProtocol IngestProtocol { get; set; }

        /// <summary>
        /// Checks to see if the IngestProtocol property is set.
        /// </summary>
        internal bool IsSetIngestProtocol() => this.IngestProtocol != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Ingest name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParticipantId. 
        /// <para>
        /// ID of the participant within the stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 64)]
        public string ParticipantId { get; set; }

        /// <summary>
        /// Checks to see if the ParticipantId property is set.
        /// </summary>
        internal bool IsSetParticipantId() => this.ParticipantId != null;

        /// <summary>
        /// Gets and sets the property RedundantIngest. 
        /// <para>
        /// Indicates whether redundant ingest is enabled for the ingest configuration.
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
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string StageArn { get; set; }

        /// <summary>
        /// Checks to see if the StageArn property is set.
        /// </summary>
        internal bool IsSetStageArn() => this.StageArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// State of the ingest configuration. It is <c>ACTIVE</c> if a publisher currently is
        /// publishing to the stage associated with the ingest configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public IngestConfigurationState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

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
