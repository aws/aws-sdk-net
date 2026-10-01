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

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The Secrets Manager secret that stores your stream credentials.
    /// </summary>
    public partial class SelfManagedKafkaAccessConfigurationCredentials
    {
        /// <summary>
        /// Gets and sets the property BasicAuth. 
        /// <para>
        /// The ARN of the Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string BasicAuth { get; set; }

        /// <summary>
        /// Checks to see if the BasicAuth property is set.
        /// </summary>
        internal bool IsSetBasicAuth() => this.BasicAuth != null;

        /// <summary>
        /// Gets and sets the property ClientCertificateTlsAuth. 
        /// <para>
        /// The ARN of the Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string ClientCertificateTlsAuth { get; set; }

        /// <summary>
        /// Checks to see if the ClientCertificateTlsAuth property is set.
        /// </summary>
        internal bool IsSetClientCertificateTlsAuth() => this.ClientCertificateTlsAuth != null;

        /// <summary>
        /// Gets and sets the property SaslScram256Auth. 
        /// <para>
        /// The ARN of the Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string SaslScram256Auth { get; set; }

        /// <summary>
        /// Checks to see if the SaslScram256Auth property is set.
        /// </summary>
        internal bool IsSetSaslScram256Auth() => this.SaslScram256Auth != null;

        /// <summary>
        /// Gets and sets the property SaslScram512Auth. 
        /// <para>
        /// The ARN of the Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string SaslScram512Auth { get; set; }

        /// <summary>
        /// Checks to see if the SaslScram512Auth property is set.
        /// </summary>
        internal bool IsSetSaslScram512Auth() => this.SaslScram512Auth != null;
    }
}
