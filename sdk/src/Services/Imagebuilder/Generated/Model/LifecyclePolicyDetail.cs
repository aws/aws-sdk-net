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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// The configuration details for a lifecycle policy resource.
    /// </summary>
    public partial class LifecyclePolicyDetail
    {
        private LifecyclePolicyDetailAction _action;
        private LifecyclePolicyDetailExclusionRules _exclusionRules;
        private LifecyclePolicyDetailFilter _filter;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Configuration details for the policy action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecyclePolicyDetailAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ExclusionRules. 
        /// <para>
        /// Additional rules to specify resources that should be exempt from policy actions.
        /// </para>
        /// </summary>
        public LifecyclePolicyDetailExclusionRules ExclusionRules
        {
            get { return this._exclusionRules; }
            set { this._exclusionRules = value; }
        }

        // Check to see if ExclusionRules property is set
        internal bool IsSetExclusionRules()
        {
            return this._exclusionRules != null;
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// Specifies the resources that the lifecycle policy applies to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LifecyclePolicyDetailFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

    }
}