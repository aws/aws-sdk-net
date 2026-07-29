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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains the version 1 policy for an intermediate table analysis rule.
    /// </summary>
    public partial class IntermediateTableAnalysisRulePolicyV1
    {
        private IntermediateTableAnalysisRuleCustom _custom;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// The custom analysis rule policy.
        /// </para>
        /// </summary>
        public IntermediateTableAnalysisRuleCustom Custom
        {
            get { return this._custom; }
            set { this._custom = value; }
        }

        // Check to see if Custom property is set
        internal bool IsSetCustom()
        {
            return this._custom != null;
        }

    }
}