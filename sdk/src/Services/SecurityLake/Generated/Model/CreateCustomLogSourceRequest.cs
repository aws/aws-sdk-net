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
    /// Container for the parameters to the CreateCustomLogSource operation.
    /// Adds a third-party custom source in Amazon Security Lake, from the Amazon Web Services
    /// Region where you want to create a custom source. Security Lake can collect logs and
    /// events from third-party custom sources. After creating the appropriate IAM role to
    /// invoke Glue crawler, use this API to add a custom source name in Security Lake. This
    /// operation creates a partition in the Amazon S3 bucket for Security Lake as the target
    /// location for log files from the custom source. In addition, this operation also creates
    /// an associated Glue table and an Glue crawler.
    /// </summary>
    public partial class CreateCustomLogSourceRequest : AmazonSecurityLakeRequest
    {
        private CustomLogSourceConfiguration _configuration;
        private List<string> _eventClasses = new List<string>();
        private string _sourceName;
        private string _sourceVersion;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration for the third-party custom source.
        /// </para>
        /// </summary>
        public CustomLogSourceConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
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
        /// Specify the name for a third-party custom source. This must be a Regionally unique
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// Specify the source version for the third-party custom source, to limit log collection
        /// to a specific version of custom data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string SourceVersion
        {
            get { return this._sourceVersion; }
            set { this._sourceVersion = value; }
        }

        // Check to see if SourceVersion property is set
        internal bool IsSetSourceVersion()
        {
            return this._sourceVersion != null;
        }

    }
}