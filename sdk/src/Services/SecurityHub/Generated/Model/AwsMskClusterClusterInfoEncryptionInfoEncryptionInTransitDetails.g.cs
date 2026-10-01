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
    /// The settings for encrypting data in transit.
    /// </summary>
    public partial class AwsMskClusterClusterInfoEncryptionInfoEncryptionInTransitDetails
    {
        /// <summary>
        /// Gets and sets the property ClientBroker. 
        /// <para>
        ///  Indicates the encryption setting for data in transit between clients and brokers.
        /// </para>
        /// </summary>
        public string ClientBroker { get; set; }

        /// <summary>
        /// Checks to see if the ClientBroker property is set.
        /// </summary>
        internal bool IsSetClientBroker() => this.ClientBroker != null;

        /// <summary>
        /// Gets and sets the property InCluster. 
        /// <para>
        ///  When set to <c>true</c>, it indicates that data communication among the broker nodes
        /// of the cluster is encrypted. When set to <c>false</c>, the communication happens in
        /// plain text. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? InCluster { get; set; }

        /// <summary>
        /// Checks to see if the InCluster property is set.
        /// </summary>
        internal bool IsSetInCluster() => this.InCluster.HasValue;
    }
}
