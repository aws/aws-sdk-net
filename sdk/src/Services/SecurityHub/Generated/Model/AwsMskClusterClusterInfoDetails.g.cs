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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provide details about an Amazon Managed Streaming for Apache Kafka (Amazon MSK) cluster.
    /// </summary>
    public partial class AwsMskClusterClusterInfoDetails
    {
        /// <summary>
        /// Gets and sets the property ClientAuthentication. 
        /// <para>
        ///  Provides information for different modes of client authentication.
        /// </para>
        /// </summary>
        public AwsMskClusterClusterInfoClientAuthenticationDetails ClientAuthentication { get; set; }

        /// <summary>
        /// Checks to see if the ClientAuthentication property is set.
        /// </summary>
        internal bool IsSetClientAuthentication() => this.ClientAuthentication != null;

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        ///  The name of the cluster.
        /// </para>
        /// </summary>
        public string ClusterName { get; set; }

        /// <summary>
        /// Checks to see if the ClusterName property is set.
        /// </summary>
        internal bool IsSetClusterName() => this.ClusterName != null;

        /// <summary>
        /// Gets and sets the property CurrentVersion. 
        /// <para>
        ///  The current version of the cluster.
        /// </para>
        /// </summary>
        public string CurrentVersion { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersion property is set.
        /// </summary>
        internal bool IsSetCurrentVersion() => this.CurrentVersion != null;

        /// <summary>
        /// Gets and sets the property EncryptionInfo. 
        /// <para>
        ///  Includes encryption-related information, such as the KMS key used for encrypting
        /// data at rest and whether you want Amazon MSK to encrypt your data in transit.
        /// </para>
        /// </summary>
        public AwsMskClusterClusterInfoEncryptionInfoDetails EncryptionInfo { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionInfo property is set.
        /// </summary>
        internal bool IsSetEncryptionInfo() => this.EncryptionInfo != null;

        /// <summary>
        /// Gets and sets the property EnhancedMonitoring. 
        /// <para>
        ///  Specifies the level of monitoring for the cluster. 
        /// </para>
        /// </summary>
        public string EnhancedMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the EnhancedMonitoring property is set.
        /// </summary>
        internal bool IsSetEnhancedMonitoring() => this.EnhancedMonitoring != null;

        /// <summary>
        /// Gets and sets the property NumberOfBrokerNodes. 
        /// <para>
        ///  The number of broker nodes in the cluster.
        /// </para>
        /// </summary>
        public int? NumberOfBrokerNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfBrokerNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfBrokerNodes() => this.NumberOfBrokerNodes.HasValue;
    }
}
