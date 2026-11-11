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
    /// Information about the mutual authentication attributes of a listener.
    /// </summary>
    public partial class MutualAuthenticationAttributes
    {
        /// <summary>
        /// Gets and sets the property AdvertiseTrustStoreCaNames. 
        /// <para>
        /// Indicates whether trust store CA certificate names are advertised.
        /// </para>
        /// </summary>
        public AdvertiseTrustStoreCaNamesEnum AdvertiseTrustStoreCaNames { get; set; }

        /// <summary>
        /// Checks to see if the AdvertiseTrustStoreCaNames property is set.
        /// </summary>
        internal bool IsSetAdvertiseTrustStoreCaNames() => this.AdvertiseTrustStoreCaNames != null;

        /// <summary>
        /// Gets and sets the property IgnoreClientCertificateExpiry. 
        /// <para>
        /// Indicates whether expired client certificates are ignored.
        /// </para>
        /// </summary>
        public bool? IgnoreClientCertificateExpiry { get; set; }

        /// <summary>
        /// Checks to see if the IgnoreClientCertificateExpiry property is set.
        /// </summary>
        internal bool IsSetIgnoreClientCertificateExpiry() => this.IgnoreClientCertificateExpiry.HasValue;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The client certificate handling method. Options are <c>off</c>, <c>passthrough</c>
        /// or <c>verify</c>. The default value is <c>off</c>.
        /// </para>
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

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

        /// <summary>
        /// Gets and sets the property TrustStoreAssociationStatus. 
        /// <para>
        /// Indicates a shared trust stores association status.
        /// </para>
        /// </summary>
        public TrustStoreAssociationStatusEnum TrustStoreAssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrustStoreAssociationStatus property is set.
        /// </summary>
        internal bool IsSetTrustStoreAssociationStatus() => this.TrustStoreAssociationStatus != null;
    }
}
