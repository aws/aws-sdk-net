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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Describes SAML options for an OpenSearch Serverless security configuration in the
    /// form of a key-value map.
    /// </summary>
    public partial class SamlConfigOptions
    {
        private string _groupAttribute;
        private string _metadata;
        private int? _sessionTimeout;
        private string _userAttribute;

        /// <summary>
        /// Gets and sets the property GroupAttribute. 
        /// <para>
        /// The group attribute for this SAML integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string GroupAttribute
        {
            get { return this._groupAttribute; }
            set { this._groupAttribute = value; }
        }

        // Check to see if GroupAttribute property is set
        internal bool IsSetGroupAttribute()
        {
            return this._groupAttribute != null;
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The XML IdP metadata file generated from your identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20480)]
        public string Metadata
        {
            get { return this._metadata; }
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null;
        }

        /// <summary>
        /// Gets and sets the property SessionTimeout. 
        /// <para>
        /// The session timeout, in minutes. Default is 60 minutes (12 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=720)]
        public int SessionTimeout
        {
            get { return this._sessionTimeout.GetValueOrDefault(); }
            set { this._sessionTimeout = value; }
        }

        // Check to see if SessionTimeout property is set
        internal bool IsSetSessionTimeout()
        {
            return this._sessionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// A user attribute for this SAML integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string UserAttribute
        {
            get { return this._userAttribute; }
            set { this._userAttribute = value; }
        }

        // Check to see if UserAttribute property is set
        internal bool IsSetUserAttribute()
        {
            return this._userAttribute != null;
        }

    }
}