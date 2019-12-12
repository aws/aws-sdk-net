/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DLM.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLifecyclePolicy operation.
    /// Creates a policy to manage the lifecycle of the specified AWS resources. You can create
    /// up to 100 lifecycle policies.
    /// </summary>
    public partial class CreateLifecyclePolicyRequest : AmazonDLMRequest
    {
        private string _description;
        private string _executionRoleArn;
        private PolicyDetails _policyDetails;
        private SettablePolicyStateValues _state;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the lifecycle policy. The characters ^[0-9A-Za-z _-]+$ are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=500)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used to run the operations specified
        /// by the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyDetails. 
        /// <para>
        /// The configuration details of the lifecycle policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PolicyDetails PolicyDetails
        {
            get { return this._policyDetails; }
            set { this._policyDetails = value; }
        }

        // Check to see if PolicyDetails property is set
        internal bool IsSetPolicyDetails()
        {
            return this._policyDetails != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The desired activation state of the lifecycle policy after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SettablePolicyStateValues State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the lifecycle policy during creation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}