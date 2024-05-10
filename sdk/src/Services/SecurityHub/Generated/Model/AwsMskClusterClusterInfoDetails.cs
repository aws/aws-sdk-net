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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provide details about an Amazon Managed Streaming for Apache Kafka (Amazon MSK) cluster.
    /// </summary>
    public partial class AwsMskClusterClusterInfoDetails
    {
        private AwsMskClusterClusterInfoClientAuthenticationDetails _clientAuthentication;
        private string _clusterName;
        private string _currentVersion;
        private AwsMskClusterClusterInfoEncryptionInfoDetails _encryptionInfo;
        private string _enhancedMonitoring;
        private int? _numberOfBrokerNodes;

        /// <summary>
        /// Gets and sets the property ClientAuthentication. 
        /// <para>
        ///  Provides information for different modes of client authentication.
        /// </para>
        /// </summary>
        public AwsMskClusterClusterInfoClientAuthenticationDetails ClientAuthentication
        {
            get { return this._clientAuthentication; }
            set { this._clientAuthentication = value; }
        }

        // Check to see if ClientAuthentication property is set
        internal bool IsSetClientAuthentication()
        {
            return this._clientAuthentication != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        ///  The name of the cluster.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        ///  The current version of the cluster.
        /// </para>
        /// </summary>
        public string CurrentVersion
        {
            get { return this._currentVersion; }
            set { this._currentVersion = value; }
        }

        // Check to see if CurrentVersion property is set
        internal bool IsSetCurrentVersion()
        {
            return this._currentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionInfo. 
        /// <para>
        ///  Includes encryption-related information, such as the KMS key used for encrypting
        /// data at rest and whether you want Amazon MSK to encrypt your data in transit.
        /// </para>
        /// </summary>
        public AwsMskClusterClusterInfoEncryptionInfoDetails EncryptionInfo
        {
            get { return this._encryptionInfo; }
            set { this._encryptionInfo = value; }
        }

        // Check to see if EncryptionInfo property is set
        internal bool IsSetEncryptionInfo()
        {
            return this._encryptionInfo != null;
        }

        /// <summary>
        /// Gets and sets the property EnhancedMonitoring. 
        /// <para>
        ///  Specifies the level of monitoring for the cluster. 
        /// </para>
        /// </summary>
        public string EnhancedMonitoring
        {
            get { return this._enhancedMonitoring; }
            set { this._enhancedMonitoring = value; }
        }

        // Check to see if EnhancedMonitoring property is set
        internal bool IsSetEnhancedMonitoring()
        {
            return this._enhancedMonitoring != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBrokerNodes. 
        /// <para>
        ///  The number of broker nodes in the cluster.
        /// </para>
        /// </summary>
        public int? NumberOfBrokerNodes
        {
            get { return this._numberOfBrokerNodes; }
            set { this._numberOfBrokerNodes = value; }
        }

        // Check to see if NumberOfBrokerNodes property is set
        internal bool IsSetNumberOfBrokerNodes()
        {
            return this._numberOfBrokerNodes.HasValue; 
        }

    }
}