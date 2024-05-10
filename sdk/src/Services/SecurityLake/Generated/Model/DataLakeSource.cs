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

#pragma warning disable CS0612,CS0618,CS1570
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
        private List<string> _eventClasses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourceName;
        private List<DataLakeSourceStatus> _sourceStatuses = AWSConfigs.InitializeCollections ? new List<DataLakeSourceStatus>() : null;

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
        ///  <c>ACCESS_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FILE_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KERNEL_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KERNEL_EXTENSION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MEMORY_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MODULE_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROCESS_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGISTRY_KEY_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REGISTRY_VALUE_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESOURCE_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCHEDULED_JOB_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SECURITY_FINDING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCOUNT_CHANGE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTHENTICATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AUTHORIZATION</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENTITY_MANAGEMENT_AUDIT</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DHCP_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETWORK_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DNS_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FTP_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HTTP_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RDP_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SMB_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SSH_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONFIG_STATE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVENTORY_INFO</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EMAIL_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>API_ACTIVITY</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CLOUD_API</c> 
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
            return this._eventClasses != null && (this._eventClasses.Count > 0 || !AWSConfigs.InitializeCollections); 
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
            return this._sourceStatuses != null && (this._sourceStatuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}