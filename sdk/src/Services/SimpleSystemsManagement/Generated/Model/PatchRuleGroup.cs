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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// A set of rules defining the approval rules for a patch baseline.
    /// </summary>
    public partial class PatchRuleGroup
    {
        private List<PatchRule> _patchRules = new List<PatchRule>();

        /// <summary>
        /// Gets and sets the property PatchRules. 
        /// <para>
        /// The rules that make up the rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<PatchRule> PatchRules
        {
            get { return this._patchRules; }
            set { this._patchRules = value; }
        }

        // Check to see if PatchRules property is set
        internal bool IsSetPatchRules()
        {
            return this._patchRules != null && this._patchRules.Count > 0; 
        }

    }
}