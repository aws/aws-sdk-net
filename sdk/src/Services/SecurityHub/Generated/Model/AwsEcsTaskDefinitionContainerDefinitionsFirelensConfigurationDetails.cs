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
    /// The FireLens configuration for the container. The configuration specifies and configures
    /// a log router for container logs.
    /// </summary>
    public partial class AwsEcsTaskDefinitionContainerDefinitionsFirelensConfigurationDetails
    {
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private string _type;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options to use to configure the log router.
        /// </para>
        ///  
        /// <para>
        /// The valid option keys are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>enable-ecs-log-metadata</code>. The value can be <code>true</code> or <code>false</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>config-file-type</code>. The value can be <code>s3</code> or <code>file</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>config-file-value</code>. The value is either an S3 ARN or a file path.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The log router to use. Valid values are <code>fluentbit</code> or <code>fluentd</code>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}