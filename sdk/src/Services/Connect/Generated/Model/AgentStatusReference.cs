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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the agent's status.
    /// </summary>
    public partial class AgentStatusReference
    {
        private string _statusArn;
        private string _statusName;
        private DateTime? _statusStartTimestamp;

        /// <summary>
        /// Gets and sets the property StatusArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the agent's status.
        /// </para>
        /// </summary>
        public string StatusArn
        {
            get { return this._statusArn; }
            set { this._statusArn = value; }
        }

        // Check to see if StatusArn property is set
        internal bool IsSetStatusArn()
        {
            return this._statusArn != null;
        }

        /// <summary>
        /// Gets and sets the property StatusName. 
        /// <para>
        /// The name of the agent status.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string StatusName
        {
            get { return this._statusName; }
            set { this._statusName = value; }
        }

        // Check to see if StatusName property is set
        internal bool IsSetStatusName()
        {
            return this._statusName != null;
        }

        /// <summary>
        /// Gets and sets the property StatusStartTimestamp. 
        /// <para>
        /// The start timestamp of the agent's status.
        /// </para>
        /// </summary>
        public DateTime StatusStartTimestamp
        {
            get { return this._statusStartTimestamp.GetValueOrDefault(); }
            set { this._statusStartTimestamp = value; }
        }

        // Check to see if StatusStartTimestamp property is set
        internal bool IsSetStatusStartTimestamp()
        {
            return this._statusStartTimestamp.HasValue; 
        }

    }
}