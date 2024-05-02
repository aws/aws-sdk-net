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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// The settings for encrypting data in transit.
    /// </summary>
    public partial class EncryptionInTransit
    {
        private ClientBroker _clientBroker;
        private bool? _inCluster;

        /// <summary>
        /// Gets and sets the property ClientBroker.             
        /// <para>
        /// Indicates the encryption setting for data in transit between clients and brokers.
        /// The following are the possible values.
        /// </para>
        ///             
        /// <para>
        ///                TLS means that client-broker communication is enabled with TLS only.
        /// </para>
        ///             
        /// <para>
        ///                TLS_PLAINTEXT means that client-broker communication is enabled for
        /// both TLS-encrypted, as well as plaintext data.
        /// </para>
        ///             
        /// <para>
        ///                PLAINTEXT means that client-broker communication is enabled in plaintext
        /// only.
        /// </para>
        ///             
        /// <para>
        /// The default value is TLS_PLAINTEXT.
        /// </para>
        /// </summary>
        public ClientBroker ClientBroker
        {
            get { return this._clientBroker; }
            set { this._clientBroker = value; }
        }

        // Check to see if ClientBroker property is set
        internal bool IsSetClientBroker()
        {
            return this._clientBroker != null;
        }

        /// <summary>
        /// Gets and sets the property InCluster.             
        /// <para>
        /// When set to true, it indicates that data communication among the broker nodes of the
        /// cluster is encrypted. When set to false, the communication happens in plaintext.
        /// </para>
        ///             
        /// <para>
        /// The default value is true.
        /// </para>
        /// </summary>
        public bool? InCluster
        {
            get { return this._inCluster; }
            set { this._inCluster = value; }
        }

        // Check to see if InCluster property is set
        internal bool IsSetInCluster()
        {
            return this._inCluster.HasValue; 
        }

    }
}