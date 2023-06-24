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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The log configuration specification for the container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetails
    {
        private string _logDriver;
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private List<AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationSecretOptionsDetails> _secretOptions = new List<AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationSecretOptionsDetails>();

        /// <summary>
        /// Gets and sets the property LogDriver. 
        /// <para>
        /// The log driver to use for the container.
        /// </para>
        ///  
        /// <para>
        /// Valid values on Fargate are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>awsfirelens</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>awslogs</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>splunk</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid values on Amazon EC2 are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>awsfirelens</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>awslogs</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>fluentd</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>gelf</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>journald</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>json-file</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>logentries</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>splunk</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>syslog</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string LogDriver
        {
            get { return this._logDriver; }
            set { this._logDriver = value; }
        }

        // Check to see if LogDriver property is set
        internal bool IsSetLogDriver()
        {
            return this._logDriver != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The configuration options to send to the log driver. Requires version 1.19 of the
        /// Docker Remote API or greater on your container instance.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecretOptions. 
        /// <para>
        /// The secrets to pass to the log configuration.
        /// </para>
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationSecretOptionsDetails> SecretOptions
        {
            get { return this._secretOptions; }
            set { this._secretOptions = value; }
        }

        // Check to see if SecretOptions property is set
        internal bool IsSetSecretOptions()
        {
            return this._secretOptions != null && this._secretOptions.Count > 0; 
        }

    }
}