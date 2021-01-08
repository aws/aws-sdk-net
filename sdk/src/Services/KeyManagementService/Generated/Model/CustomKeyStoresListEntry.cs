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
        private string _trustAnchorCertificate;

        /// <summary>
        /// Gets and sets the property CloudHsmClusterId. 
        /// <para>
        /// A unique identifier for the AWS CloudHSM cluster that is associated with the custom
        /// key store.
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
        /// Describes the connection error. This field appears in the response only when the <code>ConnectionState</code>
        /// is <code>FAILED</code>. For help resolving these errors, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-failed">How
        /// to Fix a Connection Failure</a> in <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CLUSTER_NOT_FOUND</code> - AWS KMS cannot find the AWS CloudHSM cluster with
        /// the specified cluster ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INSUFFICIENT_CLOUDHSM_HSMS</code> - The associated AWS CloudHSM cluster does
        /// not contain any active HSMs. To connect a custom key store to its AWS CloudHSM cluster,
        /// the cluster must contain at least one active HSM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INTERNAL_ERROR</code> - AWS KMS could not complete the request due to an internal
        /// error. Retry the request. For <code>ConnectCustomKeyStore</code> requests, disconnect
        /// the custom key store before trying to connect again.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>INVALID_CREDENTIALS</code> - AWS KMS does not have the correct password for
        /// the <code>kmsuser</code> crypto user in the AWS CloudHSM cluster. Before you can connect
        /// your custom key store to its AWS CloudHSM cluster, you must change the <code>kmsuser</code>
        /// account password and update the key store password value for the custom key store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NETWORK_ERRORS</code> - Network errors are preventing AWS KMS from connecting
        /// to the custom key store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUBNET_NOT_FOUND</code> - A subnet in the AWS CloudHSM cluster configuration
        /// was deleted. If AWS KMS cannot find all of the subnets in the cluster configuration,
        /// attempts to connect the custom key store to the AWS CloudHSM cluster fail. To fix
        /// this error, create a cluster from a recent backup and associate it with your custom
        /// key store. (This process creates a new cluster configuration with a VPC and private
        /// subnets.) For details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#fix-keystore-failed">How
        /// to Fix a Connection Failure</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>USER_LOCKED_OUT</code> - The <code>kmsuser</code> CU account is locked out
        /// of the associated AWS CloudHSM cluster due to too many failed password attempts. Before
        /// you can connect your custom key store to its AWS CloudHSM cluster, you must change
        /// the <code>kmsuser</code> account password and update the key store password value
        /// for the custom key store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>USER_LOGGED_IN</code> - The <code>kmsuser</code> CU account is logged into
        /// the the associated AWS CloudHSM cluster. This prevents AWS KMS from rotating the <code>kmsuser</code>
        /// account password and logging into the cluster. Before you can connect your custom
        /// key store to its AWS CloudHSM cluster, you must log the <code>kmsuser</code> CU out
        /// of the cluster. If you changed the <code>kmsuser</code> password to log into the cluster,
        /// you must also and update the key store password value for the custom key store. For
        /// help, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html#login-kmsuser-2">How
        /// to Log Out and Reconnect</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>USER_NOT_FOUND</code> - AWS KMS cannot find a <code>kmsuser</code> CU account
        /// in the associated AWS CloudHSM cluster. Before you can connect your custom key store
        /// to its AWS CloudHSM cluster, you must create a <code>kmsuser</code> CU account in
        /// the cluster, and then update the key store password value for the custom key store.
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
        /// Indicates whether the custom key store is connected to its AWS CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        /// You can create and use CMKs in your custom key stores only when its connection state
        /// is <code>CONNECTED</code>.
        /// </para>
        ///  
        /// <para>
        /// The value is <code>DISCONNECTED</code> if the key store has never been connected or
        /// you use the <a>DisconnectCustomKeyStore</a> operation to disconnect it. If the value
        /// is <code>CONNECTED</code> but you are having trouble using the custom key store, make
        /// sure that its associated AWS CloudHSM cluster is active and contains at least one
        /// active HSM.
        /// </para>
        ///  
        /// <para>
        /// A value of <code>FAILED</code> indicates that an attempt to connect was unsuccessful.
        /// The <code>ConnectionErrorCode</code> field in the response indicates the cause of
        /// the failure. For help resolving a connection failure, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
        /// a Custom Key Store</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
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
        /// Gets and sets the property TrustAnchorCertificate. 
        /// <para>
        /// The trust anchor certificate of the associated AWS CloudHSM cluster. When you <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html#sign-csr">initialize
        /// the cluster</a>, you create this certificate and save it in the <code>customerCA.crt</code>
        /// file.
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

    }
}