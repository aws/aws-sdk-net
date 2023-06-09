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
    /// Amazon Security Lake collects logs and events from supported Amazon Web Services and
    /// custom sources. For the list of supported Amazon Web Services, see the <a href="https://docs.aws.amazon.com/security-lake/latest/userguide/internal-sources.html">Amazon
    /// Security Lake User Guide</a>.
    /// </summary>
    public partial class DataLakeSource
    {
        private string _account;
        private List<string> _eventClasses = new List<string>();
        private string _sourceName;
        private List<DataLakeSourceStatus> _sourceStatuses = new List<DataLakeSourceStatus>();

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The ID of the Security Lake account for which logs are collected.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property EventClasses. 
        /// <para>
        /// The Open Cybersecurity Schema Framework (OCSF) event classes which describes the type
        /// of data that the custom source will send to Security Lake. The supported event classes
        /// are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACCESS_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FILE_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KERNEL_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KERNEL_EXTENSION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MEMORY_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MODULE_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PROCESS_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REGISTRY_KEY_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REGISTRY_VALUE_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RESOURCE_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SCHEDULED_JOB_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SECURITY_FINDING</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACCOUNT_CHANGE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AUTHENTICATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AUTHORIZATION</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ENTITY_MANAGEMENT_AUDIT</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DHCP_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NETWORK_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DNS_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FTP_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HTTP_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RDP_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SMB_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SSH_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CONFIG_STATE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INVENTORY_INFO</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EMAIL_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>API_ACTIVITY</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CLOUD_API</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<string> EventClasses
        {
            get { return this._eventClasses; }
            set { this._eventClasses = value; }
        }

        // Check to see if EventClasses property is set
        internal bool IsSetEventClasses()
        {
            return this._eventClasses != null && this._eventClasses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The supported Amazon Web Services from which logs and events are collected. Amazon
        /// Security Lake supports log and event collection for natively supported Amazon Web
        /// Services.
        /// </para>
        /// </summary>
        public string SourceName
        {
            get { return this._sourceName; }
            set { this._sourceName = value; }
        }

        // Check to see if SourceName property is set
        internal bool IsSetSourceName()
        {
            return this._sourceName != null;
        }

        /// <summary>
        /// Gets and sets the property SourceStatuses. 
        /// <para>
        /// The log status for the Security Lake account.
        /// </para>
        /// </summary>
        public List<DataLakeSourceStatus> SourceStatuses
        {
            get { return this._sourceStatuses; }
            set { this._sourceStatuses = value; }
        }

        // Check to see if SourceStatuses property is set
        internal bool IsSetSourceStatuses()
        {
            return this._sourceStatuses != null && this._sourceStatuses.Count > 0; 
        }

    }
}