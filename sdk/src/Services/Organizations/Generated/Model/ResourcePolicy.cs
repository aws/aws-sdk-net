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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// A structure that contains details about a resource policy.
    /// </summary>
    public partial class ResourcePolicy
    {
        private string _content;
        private ResourcePolicySummary _resourcePolicySummary;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The policy text of the resource policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40000)]
        public string Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ResourcePolicySummary. 
        /// <para>
        /// A structure that contains resource policy ID and Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        public ResourcePolicySummary ResourcePolicySummary
        {
            get { return this._resourcePolicySummary; }
            set { this._resourcePolicySummary = value; }
        }

        // Check to see if ResourcePolicySummary property is set
        internal bool IsSetResourcePolicySummary()
        {
            return this._resourcePolicySummary != null;
        }

    }
}