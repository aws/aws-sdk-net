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
        private List<string> _eventClasses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _sourceName;
        private string _sourceVersion;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration for the third-party custom source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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