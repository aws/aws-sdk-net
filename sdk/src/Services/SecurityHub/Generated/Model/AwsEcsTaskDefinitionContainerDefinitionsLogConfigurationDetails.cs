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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The log configuration specification for the container.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationDetails
    {
        private string _logDriver;
        private Dictionary<string, string> _options = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationSecretOptionsDetails> _secretOptions = AWSConfigs.InitializeCollections ? new List<AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationSecretOptionsDetails>() : null;

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
        ///  <c>awsfirelens</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>awslogs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>splunk</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Valid values on Amazon EC2 are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>awsfirelens</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>awslogs</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>fluentd</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>gelf</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>journald</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>json-file</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>logentries</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>splunk</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>syslog</c> 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecretOptions. 
        /// <para>
        /// The secrets to pass to the log configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEcsTaskDefinitionContainerDefinitionsLogConfigurationSecretOptionsDetails> SecretOptions
        {
            get { return this._secretOptions; }
            set { this._secretOptions = value; }
        }

        // Check to see if SecretOptions property is set
        internal bool IsSetSecretOptions()
        {
            return this._secretOptions != null && (this._secretOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}