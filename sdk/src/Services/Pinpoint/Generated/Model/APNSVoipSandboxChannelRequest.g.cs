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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the status and settings of the APNs (Apple Push Notification service) VoIP
    /// sandbox channel for an application.
    /// </summary>
    public partial class APNSVoipSandboxChannelRequest
    {
        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle identifier that's assigned to your iOS app. This identifier is used for
        /// APNs tokens.
        /// </para>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The APNs client certificate that you received from Apple, if you want Amazon Pinpoint
        /// to communicate with the APNs sandbox environment by using an APNs certificate.
        /// </para>
        /// </summary>
        public string Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property DefaultAuthenticationMethod. 
        /// <para>
        /// The default authentication method that you want Amazon Pinpoint to use when authenticating
        /// with the APNs sandbox environment for this channel, key or certificate.
        /// </para>
        /// </summary>
        public string DefaultAuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the DefaultAuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetDefaultAuthenticationMethod() => this.DefaultAuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether the APNs VoIP sandbox channel is enabled for the application.
        /// </para>
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// Checks to see if the Enabled property is set.
        /// </summary>
        internal bool IsSetEnabled() => this.Enabled.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// The private key for the APNs client certificate that you want Amazon Pinpoint to use
        /// to communicate with the APNs sandbox environment.
        /// </para>
        /// </summary>
        public string PrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the PrivateKey property is set.
        /// </summary>
        internal bool IsSetPrivateKey() => this.PrivateKey != null;

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The identifier that's assigned to your Apple developer account team. This identifier
        /// is used for APNs tokens.
        /// </para>
        /// </summary>
        public string TeamId { get; set; }

        /// <summary>
        /// Checks to see if the TeamId property is set.
        /// </summary>
        internal bool IsSetTeamId() => this.TeamId != null;

        /// <summary>
        /// Gets and sets the property TokenKey. 
        /// <para>
        /// The authentication key to use for APNs tokens.
        /// </para>
        /// </summary>
        public string TokenKey { get; set; }

        /// <summary>
        /// Checks to see if the TokenKey property is set.
        /// </summary>
        internal bool IsSetTokenKey() => this.TokenKey != null;

        /// <summary>
        /// Gets and sets the property TokenKeyId. 
        /// <para>
        /// The key identifier that's assigned to your APNs signing key, if you want Amazon Pinpoint
        /// to communicate with the APNs sandbox environment by using APNs tokens.
        /// </para>
        /// </summary>
        public string TokenKeyId { get; set; }

        /// <summary>
        /// Checks to see if the TokenKeyId property is set.
        /// </summary>
        internal bool IsSetTokenKeyId() => this.TokenKeyId != null;
    }
}
