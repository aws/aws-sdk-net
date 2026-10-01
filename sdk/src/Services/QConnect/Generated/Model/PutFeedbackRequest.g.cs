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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// Container for the parameters to the PutFeedback operation. Provides feedback against
    /// the specified assistant for the specified target. This API only supports generative
    /// targets.
    /// </summary>
    public partial class PutFeedbackRequest : AmazonQConnectRequest
    {
        /// <summary>
        /// Gets and sets the property AssistantId. 
        /// <para>
        /// The identifier of the Amazon Q in Connect assistant.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssistantId { get; set; }

        /// <summary>
        /// Checks to see if the AssistantId property is set.
        /// </summary>
        internal bool IsSetAssistantId() => this.AssistantId != null;

        /// <summary>
        /// Gets and sets the property ContentFeedback. 
        /// <para>
        /// Information about the feedback provided.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentFeedbackData ContentFeedback { get; set; }

        /// <summary>
        /// Checks to see if the ContentFeedback property is set.
        /// </summary>
        internal bool IsSetContentFeedback() => this.ContentFeedback != null;

        /// <summary>
        /// Gets and sets the property TargetId. 
        /// <para>
        /// The identifier of the feedback target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TargetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetId property is set.
        /// </summary>
        internal bool IsSetTargetId() => this.TargetId != null;

        /// <summary>
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of the feedback target.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}
