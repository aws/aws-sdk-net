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
    /// Container for the parameters to the CreateConnector operation. Creates a SCEP connector.
    /// A SCEP connector links Amazon Web Services Private Certificate Authority to your SCEP-compatible
    /// devices and mobile device management (MDM) systems. Before you create a connector,
    /// you must complete a set of prerequisites, including creation of a private certificate
    /// authority (CA) to use with this connector. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-prerequisites.html">Connector
    /// for SCEP prerequisites</a>.
    /// </summary>
    public partial class CreateConnectorRequest : AmazonPcaConnectorScepRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateAuthorityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Private Certificate Authority
        /// certificate authority to use with this connector. Due to security vulnerabilities
        /// present in the SCEP protocol, we recommend using a private CA that's dedicated for
        /// use with the connector.
        /// </para>
        ///  
        /// <para>
        /// To retrieve the private CAs associated with your account, you can call <a href="https://docs.aws.amazon.com/privateca/latest/APIReference/API_ListCertificateAuthorities.html">ListCertificateAuthorities</a>
        /// using the Amazon Web Services Private CA API.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 5, Max = 200)]
        public string CertificateAuthorityArn { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthorityArn property is set.
        /// </summary>
        internal bool IsSetCertificateAuthorityArn() => this.CertificateAuthorityArn != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Custom string that can be used to distinguish between calls to the <a href="https://docs.aws.amazon.com/pca-connector-scep/latest/APIReference/API_CreateChallenge.html">CreateChallenge</a>
        /// action. Client tokens for <c>CreateChallenge</c> time out after five minutes. Therefore,
        /// if you call <c>CreateChallenge</c> multiple times with the same client token within
        /// five minutes, Connector for SCEP recognizes that you are requesting only one challenge
        /// and will only respond with one. If you change the client token for each call, Connector
        /// for SCEP recognizes that you are requesting multiple challenge passwords.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property MobileDeviceManagement. 
        /// <para>
        /// If you don't supply a value, by default Connector for SCEP creates a connector for
        /// general-purpose use. A general-purpose connector is designed to work with clients
        /// or endpoints that support the SCEP protocol, except Connector for SCEP for Microsoft
        /// Intune. With connectors for general-purpose use, you manage SCEP challenge passwords
        /// using Connector for SCEP. For information about considerations and limitations with
        /// using Connector for SCEP, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlc4scep-considerations-limitations.html">Considerations
        /// and Limitations</a>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an <c>IntuneConfiguration</c>, Connector for SCEP creates a connector
        /// for use with Microsoft Intune, and you manage the challenge passwords using Microsoft
        /// Intune. For more information, see <a href="https://docs.aws.amazon.com/privateca/latest/userguide/scep-connector.htmlconnector-for-scep-intune.html">Using
        /// Connector for SCEP for Microsoft Intune</a>.
        /// </para>
        /// </summary>
        public MobileDeviceManagement MobileDeviceManagement { get; set; }

        /// <summary>
        /// Checks to see if the MobileDeviceManagement property is set.
        /// </summary>
        internal bool IsSetMobileDeviceManagement() => this.MobileDeviceManagement != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs to associate with the resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// If you don't supply a value, by default Connector for SCEP creates a connector accessible
        /// over the public internet. If you provide a VPC endpoint ID, creates a connector accessible
        /// only through that specific VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 13, Max = 22)]
        public string VpcEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the VpcEndpointId property is set.
        /// </summary>
        internal bool IsSetVpcEndpointId() => this.VpcEndpointId != null;
    }
}
