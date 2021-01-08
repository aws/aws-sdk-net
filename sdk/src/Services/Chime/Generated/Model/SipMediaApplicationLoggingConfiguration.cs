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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Logging configuration of the SIP media application.
    /// </summary>
    public partial class SipMediaApplicationLoggingConfiguration
    {
        private bool? _enableSipMediaApplicationMessageLogs;

        /// <summary>
        /// Gets and sets the property EnableSipMediaApplicationMessageLogs. 
        /// <para>
        /// Enables application message logs for the SIP media application.
        /// </para>
        /// </summary>
        public bool EnableSipMediaApplicationMessageLogs
        {
            get { return this._enableSipMediaApplicationMessageLogs.GetValueOrDefault(); }
            set { this._enableSipMediaApplicationMessageLogs = value; }
        }

        // Check to see if EnableSipMediaApplicationMessageLogs property is set
        internal bool IsSetEnableSipMediaApplicationMessageLogs()
        {
            return this._enableSipMediaApplicationMessageLogs.HasValue; 
        }

    }
}