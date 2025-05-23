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
    /// Contains information about each custom key store in the custom key store list.
    /// </summary>
    public partial class CustomKeyStoresListEntry
    {
        private string _cloudHsmClusterId;
        private ConnectionErrorCodeType _connectionErrorCode;
        private ConnectionStateType _connectionState;
        private DateTime? _creationDate;
        private string _customKeyStoreId;
        private string _customKeyStoreName;
        private CustomKeyStoreType _customKeyStoreType;
        private string _trustAnchorCertificate;
        private XksProxyConfigurationType _xksProxyConfiguration;

        /// <summary>
        /// Gets and sets the property CloudHsmClusterId. 
        /// <para>
        /// A unique identifier for the CloudHSM cluster that is associated with an CloudHSM key
        /// store. This field appears only when the <c>CustomKeyStoreType</c> is <c>AWS_CLOUDHSM</c>.
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
        /// Gets and sets the property ConnectionErrorCode. 
        /// <para>
        /// Describes the connection error. This field appears in the response only when the <c>ConnectionState</c>
        /// is <c>FAILED</c>.
        /// </para>
        ///  
        /// <para>
        /// Many failures can be resolved by updating the properties of the custom key store.
        /// To update a custom key store, disconnect it (<a>DisconnectCustomKeyStore</a>), correct
        /// the errors (<a>UpdateCustomKeyStore</a>), and try to connect again (<a>ConnectCustomKeyStore</a>).
        /// For additional help resolving these errors, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-failed">How
        /// to Fix a Connection Failure</a> in <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>All custom key stores:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INTERNAL_ERROR</c> — KMS could not complete the request due to an internal error.
        /// Retry the request. For <c>ConnectCustomKeyStore</c> requests, disconnect the custom
        /// key store before trying to connect again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NETWORK_ERRORS</c> — Network errors are preventing KMS from connecting the custom
        /// key store to its backing key store.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>CloudHSM key stores:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLUSTER_NOT_FOUND</c> — KMS cannot find the CloudHSM cluster with the specified
        /// cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_CLOUDHSM_HSMS</c> — The associated CloudHSM cluster does not contain
        /// any active HSMs. To connect a custom key store to its CloudHSM cluster, the cluster
        /// must contain at least one active HSM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_FREE_ADDRESSES_IN_SUBNET</c> — At least one private subnet associated
        /// with the CloudHSM cluster doesn't have any available IP addresses. A CloudHSM key
        /// store connection requires one free IP address in each of the associated private subnets,
        /// although two are preferable. For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-failed">How
        /// to Fix a Connection Failure</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INVALID_CREDENTIALS</c> — The <c>KeyStorePassword</c> for the custom key store
        /// doesn't match the current password of the <c>kmsuser</c> crypto user in the CloudHSM
        /// cluster. Before you can connect your custom key store to its CloudHSM cluster, you
        /// must change the <c>kmsuser</c> account password and update the <c>KeyStorePassword</c>
        /// value for the custom key store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUBNET_NOT_FOUND</c> — A subnet in the CloudHSM cluster configuration was deleted.
        /// If KMS cannot find all of the subnets in the cluster configuration, attempts to connect
        /// the custom key store to the CloudHSM cluster fail. To fix this error, create a cluster
        /// from a recent backup and associate it with your custom key store. (This process creates
        /// a new cluster configuration with a VPC and private subnets.) For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-failed">How
        /// to Fix a Connection Failure</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USER_LOCKED_OUT</c> — The <c>kmsuser</c> CU account is locked out of the associated
        /// CloudHSM cluster due to too many failed password attempts. Before you can connect
        /// your custom key store to its CloudHSM cluster, you must change the <c>kmsuser</c>
        /// account password and update the key store password value for the custom key store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USER_LOGGED_IN</c> — The <c>kmsuser</c> CU account is logged into the associated
        /// CloudHSM cluster. This prevents KMS from rotating the <c>kmsuser</c> account password
        /// and logging into the cluster. Before you can connect your custom key store to its
        /// CloudHSM cluster, you must log the <c>kmsuser</c> CU out of the cluster. If you changed
        /// the <c>kmsuser</c> password to log into the cluster, you must also and update the
        /// key store password value for the custom key store. For help, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#login-kmsuser-2">How
        /// to Log Out and Reconnect</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>USER_NOT_FOUND</c> — KMS cannot find a <c>kmsuser</c> CU account in the associated
        /// CloudHSM cluster. Before you can connect your custom key store to its CloudHSM cluster,
        /// you must create a <c>kmsuser</c> CU account in the cluster, and then update the key
        /// store password value for the custom key store.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>External key stores:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INVALID_CREDENTIALS</c> — One or both of the <c>XksProxyAuthenticationCredential</c>
        /// values is not valid on the specified external key store proxy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XKS_PROXY_ACCESS_DENIED</c> — KMS requests are denied access to the external key
        /// store proxy. If the external key store proxy has authorization rules, verify that
        /// they permit KMS to communicate with the proxy on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XKS_PROXY_INVALID_CONFIGURATION</c> — A configuration error is preventing the
        /// external key store from connecting to its proxy. Verify the value of the <c>XksProxyUriPath</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XKS_PROXY_INVALID_RESPONSE</c> — KMS cannot interpret the response from the external
        /// key store proxy. If you see this connection error code repeatedly, notify your external
        /// key store proxy vendor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XKS_PROXY_INVALID_TLS_CONFIGURATION</c> — KMS cannot connect to the external key
        /// store proxy because the TLS configuration is invalid. Verify that the XKS proxy supports
        /// TLS 1.2 or 1.3. Also, verify that the TLS certificate is not expired, and that it
        /// matches the hostname in the <c>XksProxyUriEndpoint</c> value, and that it is signed
        /// by a certificate authority included in the <a href="https://github.com/aws/aws-kms-xksproxy-api-spec/blob/main/TrustedCertificateAuthorities">Trusted
        /// Certificate Authorities</a> list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XKS_PROXY_NOT_REACHABLE</c> — KMS can't communicate with your external key store
        /// proxy. Verify that the <c>XksProxyUriEndpoint</c> and <c>XksProxyUriPath</c> are correct.
        /// Use the tools for your external key store proxy to verify that the proxy is active
        /// and available on its network. Also, verify that your external key manager instances
        /// are operating properly. Connection attempts fail with this connection error code if
        /// the proxy reports that all external key manager instances are unavailable.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XKS_PROXY_TIMED_OUT</c> — KMS can connect to the external key store proxy, but
        /// the proxy does not respond to KMS in the time allotted. If you see this connection
        /// error code repeatedly, notify your external key store proxy vendor.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>XKS_VPC_ENDPOINT_SERVICE_INVALID_CONFIGURATION</c> — The Amazon VPC endpoint service
        /// configuration doesn't conform to the requirements for an KMS external key store.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The VPC endpoint service must be an endpoint service for interface endpoints in the
        /// caller's Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It must have a network load balancer (NLB) connected to at least two subnets, each
        /// in a different Availability Zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Allow principals</c> list must include the KMS service principal for the Region,
        /// <c>cks.kms.&lt;region&gt;.amazonaws.com</c>, such as <c>cks.kms.us-east-1.amazonaws.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It must <i>not</i> require <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/create-endpoint-service.html">acceptance</a>
        /// of connection requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It must have a private DNS name. The private DNS name for an external key store with
        /// <c>VPC_ENDPOINT_SERVICE</c> connectivity must be unique in its Amazon Web Services
        /// Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The domain of the private DNS name must have a <a href="https://docs.aws.amazon.com/vpc/latest/privatelink/verify-domains.html">verification
        /// status</a> of <c>verified</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/create-tls-listener.html">TLS
        /// certificate</a> specifies the private DNS hostname at which the endpoint is reachable.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>XKS_VPC_ENDPOINT_SERVICE_NOT_FOUND</c> — KMS can't find the VPC endpoint service
        /// that it uses to communicate with the external key store proxy. Verify that the <c>XksProxyVpcEndpointServiceName</c>
        /// is correct and the KMS service principal has service consumer permissions on the Amazon
        /// VPC endpoint service.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ConnectionErrorCodeType ConnectionErrorCode
        {
            get { return this._connectionErrorCode; }
            set { this._connectionErrorCode = value; }
        }

        // Check to see if ConnectionErrorCode property is set
        internal bool IsSetConnectionErrorCode()
        {
            return this._connectionErrorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionState. 
        /// <para>
        /// Indicates whether the custom key store is connected to its backing key store. For
        /// an CloudHSM key store, the <c>ConnectionState</c> indicates whether it is connected
        /// to its CloudHSM cluster. For an external key store, the <c>ConnectionState</c> indicates
        /// whether it is connected to the external key store proxy that communicates with your
        /// external key manager.
        /// </para>
        ///  
        /// <para>
        /// You can create and use KMS keys in your custom key stores only when its <c>ConnectionState</c>
        /// is <c>CONNECTED</c>.
        /// </para>
        ///  
        /// <para>
        /// The <c>ConnectionState</c> value is <c>DISCONNECTED</c> only if the key store has
        /// never been connected or you use the <a>DisconnectCustomKeyStore</a> operation to disconnect
        /// it. If the value is <c>CONNECTED</c> but you are having trouble using the custom key
        /// store, make sure that the backing key store is reachable and active. For an CloudHSM
        /// key store, verify that its associated CloudHSM cluster is active and contains at least
        /// one active HSM. For an external key store, verify that the external key store proxy
        /// and external key manager are connected and enabled.
        /// </para>
        ///  
        /// <para>
        /// A value of <c>FAILED</c> indicates that an attempt to connect was unsuccessful. The
        /// <c>ConnectionErrorCode</c> field in the response indicates the cause of the failure.
        /// For help resolving a connection failure, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a custom key store</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public ConnectionStateType ConnectionState
        {
            get { return this._connectionState; }
            set { this._connectionState = value; }
        }

        // Check to see if ConnectionState property is set
        internal bool IsSetConnectionState()
        {
            return this._connectionState != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the custom key store was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// A unique identifier for the custom key store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomKeyStoreId
        {
            get { return this._customKeyStoreId; }
            set { this._customKeyStoreId = value; }
        }

        // Check to see if CustomKeyStoreId property is set
        internal bool IsSetCustomKeyStoreId()
        {
            return this._customKeyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomKeyStoreName. 
        /// <para>
        /// The user-specified friendly name for the custom key store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Indicates the type of the custom key store. <c>AWS_CLOUDHSM</c> indicates a custom
        /// key store backed by an CloudHSM cluster. <c>EXTERNAL_KEY_STORE</c> indicates a custom
        /// key store backed by an external key store proxy and external key manager outside of
        /// Amazon Web Services.
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
        /// Gets and sets the property TrustAnchorCertificate. 
        /// <para>
        /// The trust anchor certificate of the CloudHSM cluster associated with an CloudHSM key
        /// store. When you <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html#sign-csr">initialize
        /// the cluster</a>, you create this certificate and save it in the <c>customerCA.crt</c>
        /// file.
        /// </para>
        ///  
        /// <para>
        /// This field appears only when the <c>CustomKeyStoreType</c> is <c>AWS_CLOUDHSM</c>.
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
        /// Gets and sets the property XksProxyConfiguration. 
        /// <para>
        /// Configuration settings for the external key store proxy (XKS proxy). The external
        /// key store proxy translates KMS requests into a format that your external key manager
        /// can understand. The proxy configuration includes connection information that KMS requires.
        /// </para>
        ///  
        /// <para>
        /// This field appears only when the <c>CustomKeyStoreType</c> is <c>EXTERNAL_KEY_STORE</c>.
        /// </para>
        /// </summary>
        public XksProxyConfigurationType XksProxyConfiguration
        {
            get { return this._xksProxyConfiguration; }
            set { this._xksProxyConfiguration = value; }
        }

        // Check to see if XksProxyConfiguration property is set
        internal bool IsSetXksProxyConfiguration()
        {
            return this._xksProxyConfiguration != null;
        }

    }
}