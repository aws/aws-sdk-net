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
    /// Account enforced guardrail output configuration.
    /// </summary>
    public partial class AccountEnforcedGuardrailOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// Unique ID for the account enforced configuration.
        /// </para>
        /// </summary>
        public string ConfigId { get; set; }

        /// <summary>
        /// Checks to see if the ConfigId property is set.
        /// </summary>
        internal bool IsSetConfigId() => this.ConfigId != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The ARN of the role used to update the configuration.
        /// </para>
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// ARN representation for the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string GuardrailArn { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailArn property is set.
        /// </summary>
        internal bool IsSetGuardrailArn() => this.GuardrailArn != null;

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// Unique ID for the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 64)]
        public string GuardrailId { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailId property is set.
        /// </summary>
        internal bool IsSetGuardrailId() => this.GuardrailId != null;

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// Numerical guardrail version.
        /// </para>
        /// </summary>
        public string GuardrailVersion { get; set; }

        /// <summary>
        /// Checks to see if the GuardrailVersion property is set.
        /// </summary>
        internal bool IsSetGuardrailVersion() => this.GuardrailVersion != null;

        /// <summary>
        /// Gets and sets the property InputTags. 
        /// <para>
        /// Whether to honor or ignore input tags at runtime.
        /// </para>
        /// </summary>
        [Obsolete("This field is being deprecated and will be removed once customers transition their existing policies to the new schema.")]
        public InputTags InputTags { get; set; }

        /// <summary>
        /// Checks to see if the InputTags property is set.
        /// </summary>
        internal bool IsSetInputTags() => this.InputTags != null;

        /// <summary>
        /// Gets and sets the property ModelEnforcement. 
        /// <para>
        /// Model-specific information for the enforced guardrail configuration.
        /// </para>
        /// </summary>
        public ModelEnforcement ModelEnforcement { get; set; }

        /// <summary>
        /// Checks to see if the ModelEnforcement property is set.
        /// </summary>
        internal bool IsSetModelEnforcement() => this.ModelEnforcement != null;

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Configuration owner type.
        /// </para>
        /// </summary>
        public ConfigurationOwner Owner { get; set; }

        /// <summary>
        /// Checks to see if the Owner property is set.
        /// </summary>
        internal bool IsSetOwner() => this.Owner != null;

        /// <summary>
        /// Gets and sets the property SelectiveContentGuarding. 
        /// <para>
        /// Selective content guarding controls for enforced guardrails.
        /// </para>
        /// </summary>
        public SelectiveContentGuarding SelectiveContentGuarding { get; set; }

        /// <summary>
        /// Checks to see if the SelectiveContentGuarding property is set.
        /// </summary>
        internal bool IsSetSelectiveContentGuarding() => this.SelectiveContentGuarding != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The ARN of the role used to update the configuration.
        /// </para>
        /// </summary>
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedBy property is set.
        /// </summary>
        internal bool IsSetUpdatedBy() => this.UpdatedBy != null;
    }
}
