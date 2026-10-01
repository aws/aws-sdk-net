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

namespace Amazon.PcaConnectorScep.Model
{
    /// <summary>
    /// Contains OpenID Connect (OIDC) parameters for use with Microsoft Intune. For more
    /// information about using Connector for SCEP for Microsoft Intune, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-intune.html">Using
    /// Connector for SCEP for Microsoft Intune</a>.
    /// </summary>
    public partial class OpenIdConfiguration
    {
        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        /// The audience value to copy into your Microsoft Entra app registration's OIDC.
        /// </para>
        /// </summary>
        public string Audience { get; set; }

        /// <summary>
        /// Checks to see if the Audience property is set.
        /// </summary>
        internal bool IsSetAudience() => this.Audience != null;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer value to copy into your Microsoft Entra app registration's OIDC.
        /// </para>
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Checks to see if the Issuer property is set.
        /// </summary>
        internal bool IsSetIssuer() => this.Issuer != null;

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The subject value to copy into your Microsoft Entra app registration's OIDC.
        /// </para>
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Checks to see if the Subject property is set.
        /// </summary>
        internal bool IsSetSubject() => this.Subject != null;
    }
}
