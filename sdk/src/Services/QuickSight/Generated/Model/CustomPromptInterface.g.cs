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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The custom prompt interface configuration that defines how an agent's prompt is configured.
    /// </summary>
    public partial class CustomPromptInterface
    {
        /// <summary>
        /// Gets and sets the property CustomInstructions. 
        /// <para>
        /// Custom instructions for the agent's behavior.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 350000)]
        public string CustomInstructions { get; set; }

        /// <summary>
        /// Checks to see if the CustomInstructions property is set.
        /// </summary>
        internal bool IsSetCustomInstructions() => this.CustomInstructions != null;

        /// <summary>
        /// Gets and sets the property Identity. 
        /// <para>
        /// Instructions that define the agent's identity and persona.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 350000)]
        public string Identity { get; set; }

        /// <summary>
        /// Checks to see if the Identity property is set.
        /// </summary>
        internal bool IsSetIdentity() => this.Identity != null;

        /// <summary>
        /// Gets and sets the property ModelProfileId. 
        /// <para>
        /// The identifier of the model profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string ModelProfileId { get; set; }

        /// <summary>
        /// Checks to see if the ModelProfileId property is set.
        /// </summary>
        internal bool IsSetModelProfileId() => this.ModelProfileId != null;

        /// <summary>
        /// Gets and sets the property OutputStyle. 
        /// <para>
        /// Instructions for the desired output style.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 350000)]
        public string OutputStyle { get; set; }

        /// <summary>
        /// Checks to see if the OutputStyle property is set.
        /// </summary>
        internal bool IsSetOutputStyle() => this.OutputStyle != null;

        /// <summary>
        /// Gets and sets the property PromptSummary. 
        /// <para>
        /// A summary of the custom prompt configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PromptSummary { get; set; }

        /// <summary>
        /// Checks to see if the PromptSummary property is set.
        /// </summary>
        internal bool IsSetPromptSummary() => this.PromptSummary != null;

        /// <summary>
        /// Gets and sets the property QbsAwsAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the Q Business service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 15, Max = 15)]
        public string QbsAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the QbsAwsAccountId property is set.
        /// </summary>
        internal bool IsSetQbsAwsAccountId() => this.QbsAwsAccountId != null;

        /// <summary>
        /// Gets and sets the property ResponseLength. 
        /// <para>
        /// Instructions for the desired response length.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 350000)]
        public string ResponseLength { get; set; }

        /// <summary>
        /// Checks to see if the ResponseLength property is set.
        /// </summary>
        internal bool IsSetResponseLength() => this.ResponseLength != null;

        /// <summary>
        /// Gets and sets the property SubscriptionId. 
        /// <para>
        /// The subscription identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 32)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Checks to see if the SubscriptionId property is set.
        /// </summary>
        internal bool IsSetSubscriptionId() => this.SubscriptionId != null;

        /// <summary>
        /// Gets and sets the property Tone. 
        /// <para>
        /// Instructions for the desired tone of responses.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 5, Max = 350000)]
        public string Tone { get; set; }

        /// <summary>
        /// Checks to see if the Tone property is set.
        /// </summary>
        internal bool IsSetTone() => this.Tone != null;
    }
}
