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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Contains rules to be applied to the affected accounts. Policies can be attached directly
    /// to accounts, or to roots and OUs to affect all accounts in those hierarchies.
    /// </summary>
    public partial class Policy
    {
        private string _content;
        private PolicySummary _policySummary;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The text content of the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property PolicySummary. 
        /// <para>
        /// A structure that contains additional details about the policy.
        /// </para>
        /// </summary>
        public PolicySummary PolicySummary
        {
            get { return this._policySummary; }
            set { this._policySummary = value; }
        }

        // Check to see if PolicySummary property is set
        internal bool IsSetPolicySummary()
        {
            return this._policySummary != null;
        }

    }
}