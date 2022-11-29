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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Security Lake can collect logs and events from supported Amazon Web Services services
    /// and custom sources.
    /// </summary>
    public partial class AccountSources
    {
        private string _account;
        private OcsfEventClass _eventClass;
        private List<LogsStatus> _logsStatus = new List<LogsStatus>();
        private string _sourceType;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// Account ID of the Security Lake account for which logs are collected.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property EventClass. 
        /// <para>
        /// Initializes a new instance of the Event class.
        /// </para>
        /// </summary>
        public OcsfEventClass EventClass
        {
            get { return this._eventClass; }
            set { this._eventClass = value; }
        }

        // Check to see if EventClass property is set
        internal bool IsSetEventClass()
        {
            return this._eventClass != null;
        }

        /// <summary>
        /// Gets and sets the property LogsStatus. 
        /// <para>
        /// Log status for the Security Lake account.
        /// </para>
        /// </summary>
        public List<LogsStatus> LogsStatus
        {
            get { return this._logsStatus; }
            set { this._logsStatus = value; }
        }

        // Check to see if LogsStatus property is set
        internal bool IsSetLogsStatus()
        {
            return this._logsStatus != null && this._logsStatus.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The supported Amazon Web Services services from which logs and events are collected.
        /// Amazon Security Lake supports logs and events collection for natively-supported Amazon
        /// Web Services services. For more information, see the Amazon Security Lake User Guide.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}