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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
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
namespace Amazon.DLM.Model
{
    /// <summary>
    /// Container for the parameters to the GetLifecyclePolicies operation.
    /// Gets summary information about all or the specified data lifecycle policies.
    /// 
    ///  
    /// <para>
    /// To get complete information about a policy, use <a href="https://docs.aws.amazon.com/dlm/latest/APIReference/API_GetLifecyclePolicy.html">GetLifecyclePolicy</a>.
    /// </para>
    /// </summary>
    public partial class GetLifecyclePoliciesRequest : AmazonDLMRequest
    {
        private DefaultPoliciesTypeValues _defaultPolicyType;
        private List<string> _policyIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private GettablePolicyStateValues _state;
        private List<string> _tagsToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _targetTags = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DefaultPolicyType. 
        /// <para>
        ///  <b>[Default policies only]</b> Specifies the type of default policy to get. Specify
        /// one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>VOLUME</c> - To get only the default policy for EBS snapshots
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSTANCE</c> - To get only the default policy for EBS-backed AMIs
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c> - To get all default policies
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DefaultPoliciesTypeValues DefaultPolicyType
        {
            get { return this._defaultPolicyType; }
            set { this._defaultPolicyType = value; }
        }

        // Check to see if DefaultPolicyType property is set
        internal bool IsSetDefaultPolicyType()
        {
            return this._defaultPolicyType != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyIds. 
        /// <para>
        /// The identifiers of the data lifecycle policies.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PolicyIds
        {
            get { return this._policyIds; }
            set { this._policyIds = value; }
        }

        // Check to see if PolicyIds property is set
        internal bool IsSetPolicyIds()
        {
            return this._policyIds != null && (this._policyIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The resource type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Tags are strings in the format <c>key=value</c>.
        /// </para>
        ///  
        /// <para>
        /// These user-defined tags are added in addition to the Amazon Web Services-added lifecycle
        /// tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> TagsToAdd
        {
            get { return this._tagsToAdd; }
            set { this._tagsToAdd = value; }
        }

        // Check to see if TagsToAdd property is set
        internal bool IsSetTagsToAdd()
        {
            return this._tagsToAdd != null && (this._tagsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetTags. 
        /// <para>
        /// The target tag for a policy.
        /// </para>
        ///  
        /// <para>
        /// Tags are strings in the format <c>key=value</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> TargetTags
        {
            get { return this._targetTags; }
            set { this._targetTags = value; }
        }

        // Check to see if TargetTags property is set
        internal bool IsSetTargetTags()
        {
            return this._targetTags != null && (this._targetTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}