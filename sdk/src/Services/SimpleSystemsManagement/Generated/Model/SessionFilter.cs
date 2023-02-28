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
    /// Describes a filter for Session Manager information.
    /// </summary>
    public partial class SessionFilter
    {
        private SessionFilterKey _key;
        private string _value;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SessionFilterKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The filter value. Valid values for each filter key are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// InvokedAfter: Specify a timestamp to limit your results. For example, specify 2018-08-29T00:00:00Z
        /// to see sessions that started August 29, 2018, and later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// InvokedBefore: Specify a timestamp to limit your results. For example, specify 2018-08-29T00:00:00Z
        /// to see sessions that started before August 29, 2018.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Target: Specify a managed node to which session connections have been made.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Owner: Specify an Amazon Web Services user to see a list of sessions started by that
        /// user.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status: Specify a valid session status to see a list of all sessions with that status.
        /// Status values you can specify include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Connected
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Connecting
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Disconnected
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Terminated
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Terminating
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Failed
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// SessionId: Specify a session ID to return details about the session.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=400)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}