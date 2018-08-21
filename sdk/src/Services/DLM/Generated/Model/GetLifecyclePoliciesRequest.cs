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
    /// Container for the parameters to the GetLifecyclePolicies operation.
    /// Gets summary information about all or the specified data lifecycle policies.
    /// 
    ///  
    /// <para>
    /// To get complete information about a policy, use <a>GetLifecyclePolicy</a>.
    /// </para>
    /// </summary>
    public partial class GetLifecyclePoliciesRequest : AmazonDLMRequest
    {
        private List<string> _policyIds = new List<string>();
        private List<string> _resourceTypes = new List<string>();
        private GettablePolicyStateValues _state;
        private List<string> _tagsToAdd = new List<string>();
        private List<string> _targetTags = new List<string>();

        /// <summary>
        /// Gets and sets the property PolicyIds. 
        /// <para>
        /// The identifiers of the data lifecycle policies.
        /// </para>
        /// </summary>
        public List<string> PolicyIds
        {
            get { return this._policyIds; }
            set { this._policyIds = value; }
        }

        // Check to see if PolicyIds property is set
        internal bool IsSetPolicyIds()
        {
            return this._policyIds != null && this._policyIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && this._resourceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The activation state.
        /// </para>
        /// </summary>
        public GettablePolicyStateValues State
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
        /// Gets and sets the property TagsToAdd. 
        /// <para>
        /// The tags to add to objects created by the policy.
        /// </para>
        ///  
        /// <para>
        /// Tags are strings in the format <code>key=value</code>.
        /// </para>
        ///  
        /// <para>
        /// These user-defined tags are added in addition to the AWS-added lifecycle tags.
        /// </para>
        /// </summary>
        public List<string> TagsToAdd
        {
            get { return this._tagsToAdd; }
            set { this._tagsToAdd = value; }
        }

        // Check to see if TagsToAdd property is set
        internal bool IsSetTagsToAdd()
        {
            return this._tagsToAdd != null && this._tagsToAdd.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetTags. 
        /// <para>
        /// The target tag for a policy.
        /// </para>
        ///  
        /// <para>
        /// Tags are strings in the format <code>key=value</code>.
        /// </para>
        /// </summary>
        public List<string> TargetTags
        {
            get { return this._targetTags; }
            set { this._targetTags = value; }
        }

        // Check to see if TargetTags property is set
        internal bool IsSetTargetTags()
        {
            return this._targetTags != null && this._targetTags.Count > 0; 
        }

    }
}