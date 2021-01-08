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
    /// Container for the parameters to the DescribeScript operation.
    /// Retrieves properties for a Realtime script. 
    /// 
    ///  
    /// <para>
    /// To request a script record, specify the script ID. If successful, an object containing
    /// the script properties is returned.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
    /// GameLift Realtime Servers</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListScripts</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScript</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeScriptRequest : AmazonGameLiftRequest
    {
        private string _scriptId;

        /// <summary>
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// A unique identifier for a Realtime script to retrieve properties for. You can use
        /// either the script ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScriptId
        {
            get { return this._scriptId; }
            set { this._scriptId = value; }
        }

        // Check to see if ScriptId property is set
        internal bool IsSetScriptId()
        {
            return this._scriptId != null;
        }

    }
}