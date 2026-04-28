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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Network traffic filtering rule
    /// </summary>
    public partial class NetworkTrafficRule
    {
        private NetworkTrafficRuleEffect _effect;
        private NetworkTrafficRuleType _networkTrafficRuleType;
        private string _pattern;

        /// <summary>
        /// Gets and sets the property Effect. 
        /// <para>
        /// Action to take when the rule matches
        /// </para>
        /// </summary>
        public NetworkTrafficRuleEffect Effect
        {
            get { return this._effect; }
            set { this._effect = value; }
        }

        // Check to see if Effect property is set
        internal bool IsSetEffect()
        {
            return this._effect != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkTrafficRuleType. 
        /// <para>
        /// Type of network traffic rule
        /// </para>
        /// </summary>
        public NetworkTrafficRuleType NetworkTrafficRuleType
        {
            get { return this._networkTrafficRuleType; }
            set { this._networkTrafficRuleType = value; }
        }

        // Check to see if NetworkTrafficRuleType property is set
        internal bool IsSetNetworkTrafficRuleType()
        {
            return this._networkTrafficRuleType != null;
        }

        /// <summary>
        /// Gets and sets the property Pattern. 
        /// <para>
        /// Pattern to match against
        /// </para>
        /// </summary>
        public string Pattern
        {
            get { return this._pattern; }
            set { this._pattern = value; }
        }

        // Check to see if Pattern property is set
        internal bool IsSetPattern()
        {
            return this._pattern != null;
        }

    }
}