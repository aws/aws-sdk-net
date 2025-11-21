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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
        private string _configId;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _guardrailArn;
        private string _guardrailId;
        private string _guardrailVersion;
        private InputTags _inputTags;
        private ConfigurationOwner _owner;
        private DateTime? _updatedAt;
        private string _updatedBy;

        /// <summary>
        /// Gets and sets the property ConfigId. 
        /// <para>
        /// Unique ID for the account enforced configuration.
        /// </para>
        /// </summary>
        public string ConfigId
        {
            get { return this._configId; }
            set { this._configId = value; }
        }

        // Check to see if ConfigId property is set
        internal bool IsSetConfigId()
        {
            return this._configId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The ARN of the role used to update the configuration.
        /// </para>
        /// </summary>
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailArn. 
        /// <para>
        /// ARN representation for the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string GuardrailArn
        {
            get { return this._guardrailArn; }
            set { this._guardrailArn = value; }
        }

        // Check to see if GuardrailArn property is set
        internal bool IsSetGuardrailArn()
        {
            return this._guardrailArn != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailId. 
        /// <para>
        /// Unique ID for the guardrail.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string GuardrailId
        {
            get { return this._guardrailId; }
            set { this._guardrailId = value; }
        }

        // Check to see if GuardrailId property is set
        internal bool IsSetGuardrailId()
        {
            return this._guardrailId != null;
        }

        /// <summary>
        /// Gets and sets the property GuardrailVersion. 
        /// <para>
        /// Numerical guardrail version.
        /// </para>
        /// </summary>
        public string GuardrailVersion
        {
            get { return this._guardrailVersion; }
            set { this._guardrailVersion = value; }
        }

        // Check to see if GuardrailVersion property is set
        internal bool IsSetGuardrailVersion()
        {
            return this._guardrailVersion != null;
        }

        /// <summary>
        /// Gets and sets the property InputTags. 
        /// <para>
        /// Whether to honor or ignore input tags at runtime.
        /// </para>
        /// </summary>
        public InputTags InputTags
        {
            get { return this._inputTags; }
            set { this._inputTags = value; }
        }

        // Check to see if InputTags property is set
        internal bool IsSetInputTags()
        {
            return this._inputTags != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// Configuration owner type.
        /// </para>
        /// </summary>
        public ConfigurationOwner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Timestamp.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedBy. 
        /// <para>
        /// The ARN of the role used to update the configuration.
        /// </para>
        /// </summary>
        public string UpdatedBy
        {
            get { return this._updatedBy; }
            set { this._updatedBy = value; }
        }

        // Check to see if UpdatedBy property is set
        internal bool IsSetUpdatedBy()
        {
            return this._updatedBy != null;
        }

    }
}