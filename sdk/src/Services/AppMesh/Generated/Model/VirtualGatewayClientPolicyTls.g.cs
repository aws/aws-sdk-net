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

namespace Amazon.AppMesh.Model
{
    /// <summary>
    /// An object that represents a Transport Layer Security (TLS) client policy.
    /// </summary>
    public partial class VirtualGatewayClientPolicyTls
    {
        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// A reference to an object that represents a virtual gateway's client's Transport Layer
        /// Security (TLS) certificate.
        /// </para>
        /// </summary>
        public VirtualGatewayClientTlsCertificate Certificate { get; set; }

        /// <summary>
        /// Checks to see if the Certificate property is set.
        /// </summary>
        internal bool IsSetCertificate() => this.Certificate != null;

        /// <summary>
        /// Gets and sets the property Enforce. 
        /// <para>
        /// Whether the policy is enforced. The default is <c>True</c>, if a value isn't specified.
        /// </para>
        /// </summary>
        public bool? Enforce { get; set; }

        /// <summary>
        /// Checks to see if the Enforce property is set.
        /// </summary>
        internal bool IsSetEnforce() => this.Enforce.HasValue;

        /// <summary>
        /// Gets and sets the property Ports. 
        /// <para>
        /// One or more ports that the policy is enforced for.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Ports { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Ports property is set.
        /// </summary>
        internal bool IsSetPorts() => this.Ports != null && (this.Ports.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Validation. 
        /// <para>
        /// A reference to an object that represents a Transport Layer Security (TLS) validation
        /// context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VirtualGatewayTlsValidationContext Validation { get; set; }

        /// <summary>
        /// Checks to see if the Validation property is set.
        /// </summary>
        internal bool IsSetValidation() => this.Validation != null;
    }
}
