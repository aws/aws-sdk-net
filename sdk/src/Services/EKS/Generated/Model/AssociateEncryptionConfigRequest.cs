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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateEncryptionConfig operation.
    /// Associate encryption configuration to an existing cluster.
    /// 
    ///  
    /// <para>
    /// You can use this API to enable encryption on existing clusters which do not have encryption
    /// already enabled. This allows you to implement a defense-in-depth security strategy
    /// without migrating applications to new EKS clusters.
    /// </para>
    /// </summary>
    public partial class AssociateEncryptionConfigRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;
        private List<EncryptionConfig> _encryptionConfig = new List<EncryptionConfig>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The client request token you are using with the encryption configuration.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of the cluster that you are associating with encryption configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// The configuration you are using for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1)]
        public List<EncryptionConfig> EncryptionConfig
        {
            get { return this._encryptionConfig; }
            set { this._encryptionConfig = value; }
        }

        // Check to see if EncryptionConfig property is set
        internal bool IsSetEncryptionConfig()
        {
            return this._encryptionConfig != null && this._encryptionConfig.Count > 0; 
        }

    }
}