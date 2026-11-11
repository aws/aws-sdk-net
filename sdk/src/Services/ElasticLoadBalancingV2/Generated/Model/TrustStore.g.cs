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

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a trust store.
    /// </summary>
    public partial class TrustStore
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NumberOfCaCertificates. 
        /// <para>
        /// The number of ca certificates in the trust store.
        /// </para>
        /// </summary>
        public int? NumberOfCaCertificates { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfCaCertificates property is set.
        /// </summary>
        internal bool IsSetNumberOfCaCertificates() => this.NumberOfCaCertificates.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the trust store.
        /// </para>
        /// </summary>
        public TrustStoreStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TotalRevokedEntries. 
        /// <para>
        /// The number of revoked certificates in the trust store.
        /// </para>
        /// </summary>
        public long? TotalRevokedEntries { get; set; }

        /// <summary>
        /// Checks to see if the TotalRevokedEntries property is set.
        /// </summary>
        internal bool IsSetTotalRevokedEntries() => this.TotalRevokedEntries.HasValue;

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trust store.
        /// </para>
        /// </summary>
        public string TrustStoreArn { get; set; }

        /// <summary>
        /// Checks to see if the TrustStoreArn property is set.
        /// </summary>
        internal bool IsSetTrustStoreArn() => this.TrustStoreArn != null;
    }
}
