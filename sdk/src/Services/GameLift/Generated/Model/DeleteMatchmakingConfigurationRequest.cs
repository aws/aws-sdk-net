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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteMatchmakingConfiguration operation.
    /// Permanently removes a FlexMatch matchmaking configuration. To delete, specify the
    /// configuration name. A matchmaking configuration cannot be deleted if it is being used
    /// in any active matchmaking tickets.
    /// 
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateMatchmakingConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMatchmakingConfigurations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateMatchmakingConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteMatchmakingConfiguration</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateMatchmakingRuleSet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMatchmakingRuleSets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ValidateMatchmakingRuleSet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteMatchmakingRuleSet</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteMatchmakingConfigurationRequest : AmazonGameLiftRequest
    {
        private string _name;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier for a matchmaking configuration. You can use either the configuration
        /// name or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}