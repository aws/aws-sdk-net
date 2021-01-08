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
    /// Container for the parameters to the CreateCustomKeyStore operation.
    /// Creates a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key store</a> that is associated with an <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/clusters.html">AWS
    /// CloudHSM cluster</a> that you own and manage.
    /// 
    ///  
    /// <para>
    /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
    /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
    /// integration of AWS KMS with the isolation and control of a single-tenant key store.
    /// </para>
    ///  
    /// <para>
    /// Before you create the custom key store, you must assemble the required elements, including
    /// an AWS CloudHSM cluster that fulfills the requirements for a custom key store. For
    /// details about the required elements, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/create-keystore.html#before-keystore">Assemble
    /// the Prerequisites</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// When the operation completes successfully, it returns the ID of the new custom key
    /// store. Before you can use your new custom key store, you need to use the <a>ConnectCustomKeyStore</a>
    /// operation to connect the new key store to its AWS CloudHSM cluster. Even if you are
    /// not going to use your custom key store immediately, you might want to connect it to
    /// verify that all settings are correct and then disconnect it until you are ready to
    /// use it.
    /// </para>
    ///  
    /// <para>
    /// For help with failures, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/fix-keystore.html">Troubleshooting
    /// a Custom Key Store</a> in the <i>AWS Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: No. You cannot perform this operation on a custom key store
    /// in a different AWS account.
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
    /// </summary>
    public partial class CreateCustomKeyStoreRequest : AmazonKeyManagementServiceRequest
    {
        private string _cloudHsmClusterId;
        private string _customKeyStoreName;
        private string _keyStorePassword;
        private string _trustAnchorCertificate;

        /// <summary>
        /// Gets and sets the property CloudHsmClusterId. 
        /// <para>
        /// Identifies the AWS CloudHSM cluster for the custom key store. Enter the cluster ID
        /// of any active AWS CloudHSM cluster that is not already associated with a custom key
        /// store. To find the cluster ID, use the <a href="https://docs.aws.amazon.com/cloudhsm/latest/APIReference/API_DescribeClusters.html">DescribeClusters</a>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=19, Max=24)]
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
        /// AWS account.
        /// </para>
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
        /// Gets and sets the property KeyStorePassword. 
        /// <para>
        /// Enter the password of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-store-concepts.html#concept-kmsuser">
        /// <code>kmsuser</code> crypto user (CU) account</a> in the specified AWS CloudHSM cluster.
        /// AWS KMS logs into the cluster as this user to manage key material on your behalf.
        /// </para>
        ///  
        /// <para>
        /// The password must be a string of 7 to 32 characters. Its value is case sensitive.
        /// </para>
        ///  
        /// <para>
        /// This parameter tells AWS KMS the <code>kmsuser</code> account password; it does not
        /// change the password in the AWS CloudHSM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=32)]
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
        /// Enter the content of the trust anchor certificate for the cluster. This is the content
        /// of the <code>customerCA.crt</code> file that you created when you <a href="https://docs.aws.amazon.com/cloudhsm/latest/userguide/initialize-cluster.html">initialized
        /// the cluster</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5000)]
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