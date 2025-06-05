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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
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
namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomKeyStore operation.
    /// Creates a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-overview.html">custom
    /// key store</a> backed by a key store that you own and manage. When you use a KMS key
    /// in a custom key store for a cryptographic operation, the cryptographic operation is
    /// actually performed in your key store using your keys. KMS supports <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-cloudhsm.html">CloudHSM
    /// key stores</a> backed by an <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/clusters.html">CloudHSM
    /// cluster</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-external.html">external
    /// key stores</a> backed by an external key store proxy and external key manager outside
    /// of Amazon Web Services.
    /// 
    ///  
    /// <para>
    ///  This operation is part of the custom key stores feature in KMS, which combines the
    /// convenience and extensive integration of KMS with the isolation and control of a key
    /// store that you own and manage.
    /// </para>
    ///  
    /// <para>
    /// Before you create the custom key store, the required elements must be in place and
    /// operational. We recommend that you use the test tools that KMS provides to verify
    /// the configuration your external key store proxy. For details about the required elements
    /// and verification tests, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
    /// the prerequisites (for CloudHSM key stores)</a> or <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-xks-keystore.html#xks-requirements">Assemble
    /// the prerequisites (for external key stores)</a> in the <i>Key Management Service Developer
    /// Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To create a custom key store, use the following parameters.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create an CloudHSM key store, specify the <c>CustomKeyStoreName</c>, <c>CloudHsmClusterId</c>,
    /// <c>KeyStorePassword</c>, and <c>TrustAnchorCertificate</c>. The <c>CustomKeyStoreType</c>
    /// parameter is optional for CloudHSM key stores. If you include it, set it to the default
    /// value, <c>AWS_CLOUDHSM</c>. For help with failures, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
    /// an CloudHSM key store</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To create an external key store, specify the <c>CustomKeyStoreName</c> and a <c>CustomKeyStoreType</c>
    /// of <c>EXTERNAL_KEY_STORE</c>. Also, specify values for <c>XksProxyConnectivity</c>,
    /// <c>XksProxyAuthenticationCredential</c>, <c>XksProxyUriEndpoint</c>, and <c>XksProxyUriPath</c>.
    /// If your <c>XksProxyConnectivity</c> value is <c>VPC_ENDPOINT_SERVICE</c>, specify
    /// the <c>XksProxyVpcEndpointServiceName</c> parameter. For help with failures, see <a
    /// href="https://docs.aws.amazon.com/kms/latest/developerguide/xks-troubleshooting.html">Troubleshooting
    /// an external key store</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// For external key stores:
    /// </para>
    ///  
    /// <para>
    /// Some external key managers provide a simpler method for creating an external key store.
    /// For details, see your external key manager documentation.
    /// </para>
    ///  
    /// <para>
    /// When creating an external key store in the KMS console, you can upload a JSON-based
    /// proxy configuration file with the desired values. You cannot use a proxy configuration
    /// with the <c>CreateCustomKeyStore</c> operation. However, you can use the values in
    /// the file to help you determine the correct values for the <c>CreateCustomKeyStore</c>
    /// parameters.
    /// </para>
    ///  </note> 
    /// <para>
    /// When the operation completes successfully, it returns the ID of the new custom key
    /// store. Before you can use your new custom key store, you need to use the <a>ConnectCustomKeyStore</a>
    /// operation to connect a new CloudHSM key store to its CloudHSM cluster, or to connect
    /// a new external key store to the external key store proxy for your external key manager.
    /// Even if you are not going to use your custom key store immediately, you might want
    /// to connect it to verify that all settings are correct and then disconnect it until
    /// you are ready to use it.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
    /// in a different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:CreateCustomKeyStore</a>
    /// (IAM policy).
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ConnectCustomKeyStore</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteCustomKeyStore</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeCustomKeyStores</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisconnectCustomKeyStore</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateCustomKeyStore</a> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Eventual consistency</b>: The KMS API follows an eventual consistency model. For
    /// more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/accessing-kms.html#programming-eventual-consistency">KMS
    /// eventual consistency</a>.
    /// </para>
    /// </summary>
    public partial class CreateCustomKeyStoreRequest : AmazonKeyManagementServiceRequest
    {
        private string _cloudHsmClusterId;
        private string _customKeyStoreName;
        private CustomKeyStoreType _customKeyStoreType;
        private string _keyStorePassword;
        private string _trustAnchorCertificate;
        private XksProxyAuthenticationCredentialType _xksProxyAuthenticationCredential;
        private XksProxyConnectivityType _xksProxyConnectivity;
        private string _xksProxyUriEndpoint;
        private string _xksProxyUriPath;
        private string _xksProxyVpcEndpointServiceName;

        /// <summary>
        /// Gets and sets the property CloudHsmClusterId. 
        /// <para>
        /// Identifies the CloudHSM cluster for an CloudHSM key store. This parameter is required
        /// for custom key stores with <c>CustomKeyStoreType</c> of <c>AWS_CLOUDHSM</c>.
        /// </para>
        ///  
        /// <para>
        /// Enter the cluster ID of any active CloudHSM cluster that is not already associated
        /// with a custom key store. To find the cluster ID, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=24)]
        public string CloudHsmClusterId
        {
            get { return this._cloudHsmClusterId; }
            set { this._cloudHsmClusterId = value; }
        }

        // Check to see if CloudHsmClusterId property is set
        internal bool IsSetCloudHsmClusterId()
        {
            return this._cloudHsmClusterId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomKeyStoreName. 
        /// <para>
        /// Specifies a friendly name for the custom key store. The name must be unique in your
        /// Amazon Web Services account and Region. This parameter is required for all custom
        /// key stores.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include confidential or sensitive information in this field. This field may
        /// be displayed in plaintext in CloudTrail logs and other output.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string CustomKeyStoreName
        {
            get { return this._customKeyStoreName; }
            set { this._customKeyStoreName = value; }
        }

        // Check to see if CustomKeyStoreName property is set
        internal bool IsSetCustomKeyStoreName()
        {
            return this._customKeyStoreName != null;
        }

        /// <summary>
        /// Gets and sets the property CustomKeyStoreType. 
        /// <para>
        /// Specifies the type of custom key store. The default value is <c>AWS_CLOUDHSM</c>.
        /// </para>
        ///  
        /// <para>
        /// For a custom key store backed by an CloudHSM cluster, omit the parameter or enter
        /// <c>AWS_CLOUDHSM</c>. For a custom key store backed by an external key manager outside
        /// of Amazon Web Services, enter <c>EXTERNAL_KEY_STORE</c>. You cannot change this property
        /// after the key store is created.
        /// </para>
        /// </summary>
        public CustomKeyStoreType CustomKeyStoreType
        {
            get { return this._customKeyStoreType; }
            set { this._customKeyStoreType = value; }
        }

        // Check to see if CustomKeyStoreType property is set
        internal bool IsSetCustomKeyStoreType()
        {
            return this._customKeyStoreType != null;
        }

        /// <summary>
        /// Gets and sets the property KeyStorePassword. 
        /// <para>
        /// Specifies the <c>kmsuser</c> password for an CloudHSM key store. This parameter is
        /// required for custom key stores with a <c>CustomKeyStoreType</c> of <c>AWS_CLOUDHSM</c>.
        /// </para>
        ///  
        /// <para>
        /// Enter the password of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-cloudhsm.html#concept-kmsuser">
        /// <c>kmsuser</c> crypto user (CU) account</a> in the specified CloudHSM cluster. KMS
        /// logs into the cluster as this user to manage key material on your behalf.
        /// </para>
        ///  
        /// <para>
        /// The password must be a string of 7 to 32 characters. Its value is case sensitive.
        /// </para>
        ///  
        /// <para>
        /// This parameter tells KMS the <c>kmsuser</c> account password; it does not change the
        /// password in the CloudHSM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=7, Max=32)]
        public string KeyStorePassword
        {
            get { return this._keyStorePassword; }
            set { this._keyStorePassword = value; }
        }

        // Check to see if KeyStorePassword property is set
        internal bool IsSetKeyStorePassword()
        {
            return this._keyStorePassword != null;
        }

        /// <summary>
        /// Gets and sets the property TrustAnchorCertificate. 
        /// <para>
        /// Specifies the certificate for an CloudHSM key store. This parameter is required for
        /// custom key stores with a <c>CustomKeyStoreType</c> of <c>AWS_CLOUDHSM</c>.
        /// </para>
        ///  
        /// <para>
        /// Enter the content of the trust anchor certificate for the CloudHSM cluster. This is
        /// the content of the <c>customerCA.crt</c> file that you created when you <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html">initialized
        /// the cluster</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string TrustAnchorCertificate
        {
            get { return this._trustAnchorCertificate; }
            set { this._trustAnchorCertificate = value; }
        }

        // Check to see if TrustAnchorCertificate property is set
        internal bool IsSetTrustAnchorCertificate()
        {
            return this._trustAnchorCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property XksProxyAuthenticationCredential. 
        /// <para>
        /// Specifies an authentication credential for the external key store proxy (XKS proxy).
        /// This parameter is required for all custom key stores with a <c>CustomKeyStoreType</c>
        /// of <c>EXTERNAL_KEY_STORE</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>XksProxyAuthenticationCredential</c> has two required elements: <c>RawSecretAccessKey</c>,
        /// a secret key, and <c>AccessKeyId</c>, a unique identifier for the <c>RawSecretAccessKey</c>.
        /// For character requirements, see <a href="API_XksProxyAuthenticationCredentialType.html">XksProxyAuthenticationCredentialType</a>.
        /// </para>
        ///  
        /// <para>
        /// KMS uses this authentication credential to sign requests to the external key store
        /// proxy on your behalf. This credential is unrelated to Identity and Access Management
        /// (IAM) and Amazon Web Services credentials.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't set or change the authentication credentials on the XKS proxy.
        /// It just tells KMS the credential that you established on your external key store proxy.
        /// If you rotate your proxy authentication credential, use the <a>UpdateCustomKeyStore</a>
        /// operation to provide the new credential to KMS.
        /// </para>
        /// </summary>
        public XksProxyAuthenticationCredentialType XksProxyAuthenticationCredential
        {
            get { return this._xksProxyAuthenticationCredential; }
            set { this._xksProxyAuthenticationCredential = value; }
        }

        // Check to see if XksProxyAuthenticationCredential property is set
        internal bool IsSetXksProxyAuthenticationCredential()
        {
            return this._xksProxyAuthenticationCredential != null;
        }

        /// <summary>
        /// Gets and sets the property XksProxyConnectivity. 
        /// <para>
        /// Indicates how KMS communicates with the external key store proxy. This parameter is
        /// required for custom key stores with a <c>CustomKeyStoreType</c> of <c>EXTERNAL_KEY_STORE</c>.
        /// </para>
        ///  
        /// <para>
        /// If the external key store proxy uses a public endpoint, specify <c>PUBLIC_ENDPOINT</c>.
        /// If the external key store proxy uses a Amazon VPC endpoint service for communication
        /// with KMS, specify <c>VPC_ENDPOINT_SERVICE</c>. For help making this choice, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/choose-xks-connectivity.html">Choosing
        /// a connectivity option</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// An Amazon VPC endpoint service keeps your communication with KMS in a private address
        /// space entirely within Amazon Web Services, but it requires more configuration, including
        /// establishing a Amazon VPC with multiple subnets, a VPC endpoint service, a network
        /// load balancer, and a verified private DNS name. A public endpoint is simpler to set
        /// up, but it might be slower and might not fulfill your security requirements. You might
        /// consider testing with a public endpoint, and then establishing a VPC endpoint service
        /// for production tasks. Note that this choice does not determine the location of the
        /// external key store proxy. Even if you choose a VPC endpoint service, the proxy can
        /// be hosted within the VPC or outside of Amazon Web Services such as in your corporate
        /// data center.
        /// </para>
        /// </summary>
        public XksProxyConnectivityType XksProxyConnectivity
        {
            get { return this._xksProxyConnectivity; }
            set { this._xksProxyConnectivity = value; }
        }

        // Check to see if XksProxyConnectivity property is set
        internal bool IsSetXksProxyConnectivity()
        {
            return this._xksProxyConnectivity != null;
        }

        /// <summary>
        /// Gets and sets the property XksProxyUriEndpoint. 
        /// <para>
        /// Specifies the endpoint that KMS uses to send requests to the external key store proxy
        /// (XKS proxy). This parameter is required for custom key stores with a <c>CustomKeyStoreType</c>
        /// of <c>EXTERNAL_KEY_STORE</c>.
        /// </para>
        ///  
        /// <para>
        /// The protocol must be HTTPS. KMS communicates on port 443. Do not specify the port
        /// in the <c>XksProxyUriEndpoint</c> value.
        /// </para>
        ///  
        /// <para>
        /// For external key stores with <c>XksProxyConnectivity</c> value of <c>VPC_ENDPOINT_SERVICE</c>,
        /// specify <c>https://</c> followed by the private DNS name of the VPC endpoint service.
        /// </para>
        ///  
        /// <para>
        /// For external key stores with <c>PUBLIC_ENDPOINT</c> connectivity, this endpoint must
        /// be reachable before you create the custom key store. KMS connects to the external
        /// key store proxy while creating the custom key store. For external key stores with
        /// <c>VPC_ENDPOINT_SERVICE</c> connectivity, KMS connects when you call the <a>ConnectCustomKeyStore</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// The value of this parameter must begin with <c>https://</c>. The remainder can contain
        /// upper and lower case letters (A-Z and a-z), numbers (0-9), dots (<c>.</c>), and hyphens
        /// (<c>-</c>). Additional slashes (<c>/</c> and <c>\</c>) are not permitted.
        /// </para>
        ///  
        /// <para>
        ///  <b>Uniqueness requirements: </b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The combined <c>XksProxyUriEndpoint</c> and <c>XksProxyUriPath</c> values must be
        /// unique in the Amazon Web Services account and Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An external key store with <c>PUBLIC_ENDPOINT</c> connectivity cannot use the same
        /// <c>XksProxyUriEndpoint</c> value as an external key store with <c>VPC_ENDPOINT_SERVICE</c>
        /// connectivity in this Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each external key store with <c>VPC_ENDPOINT_SERVICE</c> connectivity must have its
        /// own private DNS name. The <c>XksProxyUriEndpoint</c> value for external key stores
        /// with <c>VPC_ENDPOINT_SERVICE</c> connectivity (private DNS name) must be unique in
        /// the Amazon Web Services account and Region.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=10, Max=128)]
        public string XksProxyUriEndpoint
        {
            get { return this._xksProxyUriEndpoint; }
            set { this._xksProxyUriEndpoint = value; }
        }

        // Check to see if XksProxyUriEndpoint property is set
        internal bool IsSetXksProxyUriEndpoint()
        {
            return this._xksProxyUriEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property XksProxyUriPath. 
        /// <para>
        /// Specifies the base path to the proxy APIs for this external key store. To find this
        /// value, see the documentation for your external key store proxy. This parameter is
        /// required for all custom key stores with a <c>CustomKeyStoreType</c> of <c>EXTERNAL_KEY_STORE</c>.
        /// </para>
        ///  
        /// <para>
        /// The value must start with <c>/</c> and must end with <c>/kms/xks/v1</c> where <c>v1</c>
        /// represents the version of the KMS external key store proxy API. This path can include
        /// an optional prefix between the required elements such as <c>/<i>prefix</i>/kms/xks/v1</c>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Uniqueness requirements: </b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The combined <c>XksProxyUriEndpoint</c> and <c>XksProxyUriPath</c> values must be
        /// unique in the Amazon Web Services account and Region.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=10, Max=128)]
        public string XksProxyUriPath
        {
            get { return this._xksProxyUriPath; }
            set { this._xksProxyUriPath = value; }
        }

        // Check to see if XksProxyUriPath property is set
        internal bool IsSetXksProxyUriPath()
        {
            return this._xksProxyUriPath != null;
        }

        /// <summary>
        /// Gets and sets the property XksProxyVpcEndpointServiceName. 
        /// <para>
        /// Specifies the name of the Amazon VPC endpoint service for interface endpoints that
        /// is used to communicate with your external key store proxy (XKS proxy). This parameter
        /// is required when the value of <c>CustomKeyStoreType</c> is <c>EXTERNAL_KEY_STORE</c>
        /// and the value of <c>XksProxyConnectivity</c> is <c>VPC_ENDPOINT_SERVICE</c>.
        /// </para>
        ///  
        /// <para>
        /// The Amazon VPC endpoint service must <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-xks-keystore.html#xks-requirements">fulfill
        /// all requirements</a> for use with an external key store. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Uniqueness requirements:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// External key stores with <c>VPC_ENDPOINT_SERVICE</c> connectivity can share an Amazon
        /// VPC, but each external key store must have its own VPC endpoint service and private
        /// DNS name.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=20, Max=64)]
        public string XksProxyVpcEndpointServiceName
        {
            get { return this._xksProxyVpcEndpointServiceName; }
            set { this._xksProxyVpcEndpointServiceName = value; }
        }

        // Check to see if XksProxyVpcEndpointServiceName property is set
        internal bool IsSetXksProxyVpcEndpointServiceName()
        {
            return this._xksProxyVpcEndpointServiceName != null;
        }

    }
}