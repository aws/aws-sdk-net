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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCustomKeyStore operation.
    /// Changes the properties of a custom key store. You can use this operation to change
    /// the properties of an CloudHSM key store or an external key store.
    /// 
    ///  
    /// <para>
    /// Use the required <code>CustomKeyStoreId</code> parameter to identify the custom key
    /// store. Use the remaining optional parameters to change its properties. This operation
    /// does not return any property values. To verify the updated property values, use the
    /// <a>DescribeCustomKeyStores</a> operation.
    /// </para>
    ///  
    /// <para>
    ///  This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key stores</a> feature in KMS, which combines the convenience and extensive integration
    /// of KMS with the isolation and control of a key store that you own and manage.
    /// </para>
    ///  <important> 
    /// <para>
    /// When updating the properties of an external key store, verify that the updated settings
    /// connect your key store, via the external key store proxy, to the same external key
    /// manager as the previous settings, or to a backup or snapshot of the external key manager
    /// with the same cryptographic keys. If the updated connection settings fail, you can
    /// fix them and retry, although an extended delay might disrupt Amazon Web Services services.
    /// However, if KMS permanently loses its access to cryptographic keys, ciphertext encrypted
    /// under those keys is unrecoverable.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// For external key stores:
    /// </para>
    ///  
    /// <para>
    /// Some external key managers provide a simpler method for updating an external key store.
    /// For details, see your external key manager documentation.
    /// </para>
    ///  
    /// <para>
    /// When updating an external key store in the KMS console, you can upload a JSON-based
    /// proxy configuration file with the desired values. You cannot upload the proxy configuration
    /// file to the <code>UpdateCustomKeyStore</code> operation. However, you can use the
    /// file to help you determine the correct values for the <code>UpdateCustomKeyStore</code>
    /// parameters.
    /// </para>
    ///  </note> 
    /// <para>
    /// For an CloudHSM key store, you can use this operation to change the custom key store
    /// friendly name (<code>NewCustomKeyStoreName</code>), to tell KMS about a change to
    /// the <code>kmsuser</code> crypto user password (<code>KeyStorePassword</code>), or
    /// to associate the custom key store with a different, but related, CloudHSM cluster
    /// (<code>CloudHsmClusterId</code>). To update any property of an CloudHSM key store,
    /// the <code>ConnectionState</code> of the CloudHSM key store must be <code>DISCONNECTED</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// For an external key store, you can use this operation to change the custom key store
    /// friendly name (<code>NewCustomKeyStoreName</code>), or to tell KMS about a change
    /// to the external key store proxy authentication credentials (<code>XksProxyAuthenticationCredential</code>),
    /// connection method (<code>XksProxyConnectivity</code>), external proxy endpoint (<code>XksProxyUriEndpoint</code>)
    /// and path (<code>XksProxyUriPath</code>). For external key stores with an <code>XksProxyConnectivity</code>
    /// of <code>VPC_ENDPOINT_SERVICE</code>, you can also update the Amazon VPC endpoint
    /// service name (<code>XksProxyVpcEndpointServiceName</code>). To update most properties
    /// of an external key store, the <code>ConnectionState</code> of the external key store
    /// must be <code>DISCONNECTED</code>. However, you can update the <code>CustomKeyStoreName</code>,
    /// <code>XksProxyAuthenticationCredential</code>, and <code>XksProxyUriPath</code> of
    /// an external key store when it is in the CONNECTED or DISCONNECTED state. 
    /// </para>
    ///  
    /// <para>
    /// If your update requires a <code>DISCONNECTED</code> state, before using <code>UpdateCustomKeyStore</code>,
    /// use the <a>DisconnectCustomKeyStore</a> operation to disconnect the custom key store.
    /// After the <code>UpdateCustomKeyStore</code> operation completes, use the <a>ConnectCustomKeyStore</a>
    /// to reconnect the custom key store. To find the <code>ConnectionState</code> of the
    /// custom key store, use the <a>DescribeCustomKeyStores</a> operation. 
    /// </para>
    ///  
    /// <para>
    ///  
    /// </para>
    ///  
    /// <para>
    /// Before updating the custom key store, verify that the new values allow KMS to connect
    /// the custom key store to its backing key store. For example, before you change the
    /// <code>XksProxyUriPath</code> value, verify that the external key store proxy is reachable
    /// at the new path.
    /// </para>
    ///  
    /// <para>
    /// If the operation succeeds, it returns a JSON object with no properties.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
    /// in a different Amazon Web Services account.
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:UpdateCustomKeyStore</a>
    /// (IAM policy)
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
    ///  <a>CreateCustomKeyStore</a> 
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
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateCustomKeyStoreRequest : AmazonKeyManagementServiceRequest
    {
        private string _cloudHsmClusterId;
        private string _customKeyStoreId;
        private string _keyStorePassword;
        private string _newCustomKeyStoreName;
        private XksProxyAuthenticationCredentialType _xksProxyAuthenticationCredential;
        private XksProxyConnectivityType _xksProxyConnectivity;
        private string _xksProxyUriEndpoint;
        private string _xksProxyUriPath;
        private string _xksProxyVpcEndpointServiceName;

        /// <summary>
        /// Gets and sets the property CloudHsmClusterId. 
        /// <para>
        /// Associates the custom key store with a related CloudHSM cluster. This parameter is
        /// valid only for custom key stores with a <code>CustomKeyStoreType</code> of <code>AWS_CLOUDHSM</code>.
        /// </para>
        ///  
        /// <para>
        /// Enter the cluster ID of the cluster that you used to create the custom key store or
        /// a cluster that shares a backup history and has the same cluster certificate as the
        /// original cluster. You cannot use this parameter to associate a custom key store with
        /// an unrelated cluster. In addition, the replacement cluster must <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">fulfill
        /// the requirements</a> for a cluster associated with a custom key store. To view the
        /// cluster certificate of a cluster, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// To change this value, the CloudHSM key store must be disconnected.
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
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Identifies the custom key store that you want to update. Enter the ID of the custom
        /// key store. To find the ID of a custom key store, use the <a>DescribeCustomKeyStores</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property KeyStorePassword. 
        /// <para>
        /// Enter the current password of the <code>kmsuser</code> crypto user (CU) in the CloudHSM
        /// cluster that is associated with the custom key store. This parameter is valid only
        /// for custom key stores with a <code>CustomKeyStoreType</code> of <code>AWS_CLOUDHSM</code>.
        /// </para>
        ///  
        /// <para>
        /// This parameter tells KMS the current password of the <code>kmsuser</code> crypto user
        /// (CU). It does not set or change the password of any users in the CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        /// To change this value, the CloudHSM key store must be disconnected.
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
        /// Gets and sets the property NewCustomKeyStoreName. 
        /// <para>
        /// Changes the friendly name of the custom key store to the value that you specify. The
        /// custom key store name must be unique in the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// To change this value, an CloudHSM key store must be disconnected. An external key
        /// store can be connected or disconnected.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NewCustomKeyStoreName
        {
            get { return this._newCustomKeyStoreName; }
            set { this._newCustomKeyStoreName = value; }
        }

        // Check to see if NewCustomKeyStoreName property is set
        internal bool IsSetNewCustomKeyStoreName()
        {
            return this._newCustomKeyStoreName != null;
        }

        /// <summary>
        /// Gets and sets the property XksProxyAuthenticationCredential. 
        /// <para>
        /// Changes the credentials that KMS uses to sign requests to the external key store proxy
        /// (XKS proxy). This parameter is valid only for custom key stores with a <code>CustomKeyStoreType</code>
        /// of <code>EXTERNAL_KEY_STORE</code>.
        /// </para>
        ///  
        /// <para>
        /// You must specify both the <code>AccessKeyId</code> and <code>SecretAccessKey</code>
        /// value in the authentication credential, even if you are only updating one value.
        /// </para>
        ///  
        /// <para>
        /// This parameter doesn't establish or change your authentication credentials on the
        /// proxy. It just tells KMS the credential that you established with your external key
        /// store proxy. For example, if you rotate the credential on your external key store
        /// proxy, you can use this parameter to update the credential in KMS.
        /// </para>
        ///  
        /// <para>
        /// You can change this value when the external key store is connected or disconnected.
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
        /// Changes the connectivity setting for the external key store. To indicate that the
        /// external key store proxy uses a Amazon VPC endpoint service to communicate with KMS,
        /// specify <code>VPC_ENDPOINT_SERVICE</code>. Otherwise, specify <code>PUBLIC_ENDPOINT</code>.
        /// </para>
        ///  
        /// <para>
        /// If you change the <code>XksProxyConnectivity</code> to <code>VPC_ENDPOINT_SERVICE</code>,
        /// you must also change the <code>XksProxyUriEndpoint</code> and add an <code>XksProxyVpcEndpointServiceName</code>
        /// value. 
        /// </para>
        ///  
        /// <para>
        /// If you change the <code>XksProxyConnectivity</code> to <code>PUBLIC_ENDPOINT</code>,
        /// you must also change the <code>XksProxyUriEndpoint</code> and specify a null or empty
        /// string for the <code>XksProxyVpcEndpointServiceName</code> value.
        /// </para>
        ///  
        /// <para>
        /// To change this value, the external key store must be disconnected.
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
        /// Changes the URI endpoint that KMS uses to connect to your external key store proxy
        /// (XKS proxy). This parameter is valid only for custom key stores with a <code>CustomKeyStoreType</code>
        /// of <code>EXTERNAL_KEY_STORE</code>.
        /// </para>
        ///  
        /// <para>
        /// For external key stores with an <code>XksProxyConnectivity</code> value of <code>PUBLIC_ENDPOINT</code>,
        /// the protocol must be HTTPS.
        /// </para>
        ///  
        /// <para>
        /// For external key stores with an <code>XksProxyConnectivity</code> value of <code>VPC_ENDPOINT_SERVICE</code>,
        /// specify <code>https://</code> followed by the private DNS name associated with the
        /// VPC endpoint service. Each external key store must use a different private DNS name.
        /// </para>
        ///  
        /// <para>
        /// The combined <code>XksProxyUriEndpoint</code> and <code>XksProxyUriPath</code> values
        /// must be unique in the Amazon Web Services account and Region.
        /// </para>
        ///  
        /// <para>
        /// To change this value, the external key store must be disconnected.
        /// </para>
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
        /// Changes the base path to the proxy APIs for this external key store. To find this
        /// value, see the documentation for your external key manager and external key store
        /// proxy (XKS proxy). This parameter is valid only for custom key stores with a <code>CustomKeyStoreType</code>
        /// of <code>EXTERNAL_KEY_STORE</code>.
        /// </para>
        ///  
        /// <para>
        /// The value must start with <code>/</code> and must end with <code>/kms/xks/v1</code>,
        /// where <code>v1</code> represents the version of the KMS external key store proxy API.
        /// You can include an optional prefix between the required elements such as <code>/<i>example</i>/kms/xks/v1</code>.
        /// </para>
        ///  
        /// <para>
        /// The combined <code>XksProxyUriEndpoint</code> and <code>XksProxyUriPath</code> values
        /// must be unique in the Amazon Web Services account and Region.
        /// </para>
        ///  
        /// <para>
        /// You can change this value when the external key store is connected or disconnected.
        /// </para>
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
        /// Changes the name that KMS uses to identify the Amazon VPC endpoint service for your
        /// external key store proxy (XKS proxy). This parameter is valid when the <code>CustomKeyStoreType</code>
        /// is <code>EXTERNAL_KEY_STORE</code> and the <code>XksProxyConnectivity</code> is <code>VPC_ENDPOINT_SERVICE</code>.
        /// </para>
        ///  
        /// <para>
        /// To change this value, the external key store must be disconnected.
        /// </para>
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