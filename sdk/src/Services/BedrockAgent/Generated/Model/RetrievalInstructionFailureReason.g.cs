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

namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// One reason the most recent create or update did not succeed. code drives programmatic
    /// branching (fix the text, fix the configuration, or retry); message carries the specific
    /// cause.
    /// </summary>
    public partial class RetrievalInstructionFailureReason
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// Stable, machine-readable classification by fault attribution. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CONTENT_REJECTED – The review rejected the named field's content; revise the text
        /// and resubmit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CLIENT_ERROR – The review could not run for a customer-side reason, for example the
        /// customer managed AWS KMS key could not be used; fix the configuration and resubmit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INTERNAL_ERROR – The review could not complete due to a service fault; retry the create
        /// or update.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// New values may be added over time; your client should tolerate values it does not
        /// recognize and treat them as a failure.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RetrievalInstructionFailureReasonCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The instruction field this entry is about. Present on review rejections of a specific
        /// field; absent when the failure applies to the whole review, because a client-side
        /// execution failure or a service fault has no single field.
        /// </para>
        /// </summary>
        public RetrievalInstructionFieldName FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Human-readable explanation of the specific cause. Never contains the customer's own
        /// text.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
