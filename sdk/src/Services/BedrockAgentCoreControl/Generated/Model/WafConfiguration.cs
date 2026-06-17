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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The Amazon Web Services WAF configuration for the gateway. This configuration controls
    /// how the gateway behaves when the associated web ACL cannot be evaluated.
    /// </summary>
    public partial class WafConfiguration
    {
        private WafFailureMode _failureMode;

        /// <summary>
        /// Gets and sets the property FailureMode. 
        /// <para>
        /// The failure mode that determines how the gateway handles requests when Amazon Web
        /// Services WAF is unreachable or times out. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FAIL_CLOSE</c> - The gateway blocks requests when Amazon Web Services WAF cannot
        /// be evaluated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAIL_OPEN</c> - The gateway allows requests when Amazon Web Services WAF cannot
        /// be evaluated.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public WafFailureMode FailureMode
        {
            get { return this._failureMode; }
            set { this._failureMode = value; }
        }

        // Check to see if FailureMode property is set
        internal bool IsSetFailureMode()
        {
            return this._failureMode != null;
        }

    }
}