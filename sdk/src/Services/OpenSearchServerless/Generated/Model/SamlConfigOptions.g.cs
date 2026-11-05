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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Describes SAML options for an OpenSearch Serverless security configuration in the
    /// form of a key-value map.
    /// </summary>
    public partial class SamlConfigOptions
    {
        /// <summary>
        /// Gets and sets the property GroupAttribute. 
        /// <para>
        /// The group attribute for this SAML integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string GroupAttribute { get; set; }

        /// <summary>
        /// Checks to see if the GroupAttribute property is set.
        /// </summary>
        internal bool IsSetGroupAttribute() => this.GroupAttribute != null;

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// The XML IdP metadata file generated from your identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 51200)]
        public string Metadata { get; set; }

        /// <summary>
        /// Checks to see if the Metadata property is set.
        /// </summary>
        internal bool IsSetMetadata() => this.Metadata != null;

        /// <summary>
        /// Gets and sets the property OpenSearchServerlessEntityId. 
        /// <para>
        /// Custom entity ID attribute to override the default entity ID for this SAML integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string OpenSearchServerlessEntityId { get; set; }

        /// <summary>
        /// Checks to see if the OpenSearchServerlessEntityId property is set.
        /// </summary>
        internal bool IsSetOpenSearchServerlessEntityId() => this.OpenSearchServerlessEntityId != null;

        /// <summary>
        /// Gets and sets the property SessionTimeout. 
        /// <para>
        /// The session timeout, in minutes. Default is 60 minutes (12 hours).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 720)]
        public int? SessionTimeout { get; set; }

        /// <summary>
        /// Checks to see if the SessionTimeout property is set.
        /// </summary>
        internal bool IsSetSessionTimeout() => this.SessionTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property UserAttribute. 
        /// <para>
        /// A user attribute for this SAML integration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string UserAttribute { get; set; }

        /// <summary>
        /// Checks to see if the UserAttribute property is set.
        /// </summary>
        internal bool IsSetUserAttribute() => this.UserAttribute != null;
    }
}
