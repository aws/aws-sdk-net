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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Use this to specify the Amazon Web Services Key Management Service (KMS) Key ID, or
    /// <c>KMSKeyId</c>, for at rest data encryption. You can turn <c>OnlineStore</c> on or
    /// off by specifying the <c>EnableOnlineStore</c> flag at General Assembly.
    /// 
    ///  
    /// <para>
    /// The default value is <c>False</c>.
    /// </para>
    /// </summary>
    public partial class OnlineStoreConfig
    {
        /// <summary>
        /// Gets and sets the property EnableOnlineStore. 
        /// <para>
        /// Turn <c>OnlineStore</c> off by specifying <c>False</c> for the <c>EnableOnlineStore</c>
        /// flag. Turn <c>OnlineStore</c> on by specifying <c>True</c> for the <c>EnableOnlineStore</c>
        /// flag. 
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>False</c>.
        /// </para>
        /// </summary>
        public bool? EnableOnlineStore { get; set; }

        /// <summary>
        /// Checks to see if the EnableOnlineStore property is set.
        /// </summary>
        internal bool IsSetEnableOnlineStore() => this.EnableOnlineStore.HasValue;

        /// <summary>
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// Use to specify KMS Key ID (<c>KMSKeyId</c>) for at-rest encryption of your <c>OnlineStore</c>.
        /// </para>
        /// </summary>
        public OnlineStoreSecurityConfig SecurityConfig { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfig property is set.
        /// </summary>
        internal bool IsSetSecurityConfig() => this.SecurityConfig != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// Option for different tiers of low latency storage for real-time data retrieval.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Standard</c>: A managed low latency data store for feature groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Standard_V2</c>: A managed low latency data store for feature groups that supports
        /// partial updates to individual features using the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_feature_store_UpdateRecord.html">UpdateRecord</a>
        /// operation. Choose this storage type at feature group creation time if your use case
        /// requires updating specific feature values without rewriting the entire record.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InMemory</c>: A managed data store for feature groups that supports very low latency
        /// retrieval.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StorageType StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property TtlDuration. 
        /// <para>
        /// Time to live duration, where the record is hard deleted after the expiration time
        /// is reached; <c>ExpiresAt</c> = <c>EventTime</c> + <c>TtlDuration</c>. For information
        /// on HardDelete, see the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_feature_store_DeleteRecord.html">DeleteRecord</a>
        /// API in the Amazon SageMaker API Reference guide.
        /// </para>
        /// </summary>
        public TtlDuration TtlDuration { get; set; }

        /// <summary>
        /// Checks to see if the TtlDuration property is set.
        /// </summary>
        internal bool IsSetTtlDuration() => this.TtlDuration != null;
    }
}
