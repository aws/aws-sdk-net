/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCustomKeyStore operation.
    /// Changes the properties of a custom key store. Use the <code>CustomKeyStoreId</code>
    /// parameter to identify the custom key store you want to edit. Use the remaining parameters
    /// to change the properties of the custom key store.
    /// 
    ///  
    /// <para>
    /// You can only update a custom key store that is disconnected. To disconnect the custom
    /// key store, use <a>DisconnectCustomKeyStore</a>. To reconnect the custom key store
    /// after the update completes, use <a>ConnectCustomKeyStore</a>. To find the connection
    /// state of a custom key store, use the <a>DescribeCustomKeyStores</a> operation.
    /// </para>
    ///  
    /// <para>
    /// Use the <code>NewCustomKeyStoreName</code> parameter to change the friendly name of
    /// the custom key store to the value that you specify.
    /// </para>
    ///  
    /// <para>
    /// Use the <code>KeyStorePassword</code> parameter tell AWS KMS the current password
    /// of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
    /// <code>kmsuser</code> crypto user (CU)</a> in the associated AWS CloudHSM cluster.
    /// You can use this parameter to fix connection failures that occur when AWS KMS cannot
    /// log into the associated cluster because the <code>kmsuser</code> password has changed.
    /// This value does not change the password in the AWS CloudHSM cluster.
    /// </para>
    ///  
    /// <para>
    /// Use the <code>CloudHsmClusterId</code> parameter to associate the custom key store
    /// with a related AWS CloudHSM cluster, that is, a cluster that shares a backup history
    /// with the original cluster. You can use this parameter to repair a custom key store
    /// if its AWS CloudHSM cluster becomes corrupted or is deleted, or when you need to create
    /// or restore a cluster from a backup.
    /// </para>
    ///  
    /// <para>
    /// The cluster ID must identify a AWS CloudHSM cluster with the following requirements.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The cluster must be active and be in the same AWS account and Region as the custom
    /// key store.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The cluster must have the same cluster certificate as the original cluster. You cannot
    /// use this parameter to associate the custom key store with an unrelated cluster. To
    /// view the cluster certificate, use the AWS CloudHSM <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
    /// operation. Clusters that share a backup history have the same cluster certificate.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The cluster must be configured with subnets in at least two different Availability
    /// Zones in the Region. Because AWS CloudHSM is not supported in all Availability Zones,
    /// we recommend that the cluster have subnets in all Availability Zones in the Region.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The cluster must contain at least two active HSMs, each in a different Availability
    /// Zone.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the operation succeeds, it returns a JSON object with no properties.
    /// </para>
    ///  
    /// <para>
    /// This operation is part of the <a href="http://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
    /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
    /// integration of AWS KMS with the isolation and control of a single-tenant key store.
    /// </para>
    /// </summary>
    public partial class UpdateCustomKeyStoreRequest : AmazonKeyManagementServiceRequest
    {
        private string _cloudHsmClusterId;
        private string _customKeyStoreId;
        private string _keyStorePassword;
        private string _newCustomKeyStoreName;

        /// <summary>
        /// Gets and sets the property CloudHsmClusterId. 
        /// <para>
        /// Associates the custom key store with a related AWS CloudHSM cluster. 
        /// </para>
        ///  
        /// <para>
        /// Enter the cluster ID of the cluster that you used to create the custom key store or
        /// a cluster that shares a backup history with the original cluster. You cannot use this
        /// parameter to associate a custom key store with a different cluster.
        /// </para>
        ///  
        /// <para>
        /// Clusters that share a backup history have the same cluster certificate. To view the
        /// cluster certificate of a cluster, use the <a href="http://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </summary>
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
        /// Enter the current password of the <code>kmsuser</code> crypto user (CU) in the AWS
        /// CloudHSM cluster that is associated with the custom key store.
        /// </para>
        ///  
        /// <para>
        /// This parameter tells AWS KMS the current password of the <code>kmsuser</code> crypto
        /// user (CU). It does not set or change the password of any users in the AWS CloudHSM
        /// cluster.
        /// </para>
        /// </summary>
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
        /// custom key store name must be unique in the AWS account.
        /// </para>
        /// </summary>
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

    }
}