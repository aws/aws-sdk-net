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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the UpdateGuardrail operation.
    /// </summary>
    public partial class UpdateGuardrailResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// The ARN of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string GuardrailArn { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailArn property is set.
        /// </summary>
        internal bool IsSetGuardrailArn() => this.GuardrailArn != null;

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// The unique identifier of the guardrail
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 64)]
        public string GuardrailId { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailId property is set.
        /// </summary>
        internal bool IsSetGuardrailId() => this.GuardrailId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time at which the guardrail was updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 5)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
