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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppConfig.Model
{
    /// <summary>
    /// This is the response object from the GetConfiguration operation.
    /// </summary>
    public partial class GetConfigurationResponse : AmazonWebServiceResponse
    {
        private string _configurationVersion;
        private MemoryStream _content;
        private string _contentType;

        /// <summary>
        /// Gets and sets the property ConfigurationVersion. 
        /// <para>
        /// The configuration version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ConfigurationVersion
        {
            get { return this._configurationVersion; }
            set { this._configurationVersion = value; }
        }

        // Check to see if ConfigurationVersion property is set
        internal bool IsSetConfigurationVersion()
        {
            return this._configurationVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the configuration or the configuration data.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <code>Content</code> attribute only contains data if the system finds new or updated
        /// configuration data. If there is no new or updated data and <code>ClientConfigurationVersion</code>
        /// matches the version of the current configuration, AppConfig returns a <code>204 No
        /// Content</code> HTTP response code and the <code>Content</code> value will be empty.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public MemoryStream Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type describing the format of the configuration content. For more
        /// information, see <a href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17">Content-Type</a>.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

    }
}