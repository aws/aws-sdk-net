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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
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
        private AdvertiseTrustStoreCaNamesEnum _advertiseTrustStoreCaNames;
        private bool? _ignoreClientCertificateExpiry;
        private string _mode;
        private string _trustStoreArn;
        private TrustStoreAssociationStatusEnum _trustStoreAssociationStatus;

        /// <summary>
        /// Gets and sets the property AdvertiseTrustStoreCaNames. 
        /// <para>
        /// Indicates whether trust store CA certificate names are advertised.
        /// </para>
        /// </summary>
        public AdvertiseTrustStoreCaNamesEnum AdvertiseTrustStoreCaNames
        {
            get { return this._advertiseTrustStoreCaNames; }
            set { this._advertiseTrustStoreCaNames = value; }
        }

        // Check to see if AdvertiseTrustStoreCaNames property is set
        internal bool IsSetAdvertiseTrustStoreCaNames()
        {
            return this._advertiseTrustStoreCaNames != null;
        }

        /// <summary>
        /// Gets and sets the property IgnoreClientCertificateExpiry. 
        /// <para>
        /// Indicates whether expired client certificates are ignored.
        /// </para>
        /// </summary>
        public bool? IgnoreClientCertificateExpiry
        {
            get { return this._ignoreClientCertificateExpiry; }
            set { this._ignoreClientCertificateExpiry = value; }
        }

        // Check to see if IgnoreClientCertificateExpiry property is set
        internal bool IsSetIgnoreClientCertificateExpiry()
        {
            return this._ignoreClientCertificateExpiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The client certificate handling method. Options are <c>off</c>, <c>passthrough</c>
        /// or <c>verify</c>. The default value is <c>off</c>.
        /// </para>
        /// </summary>
        public string Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trust store.
        /// </para>
        /// </summary>
        public string TrustStoreArn
        {
            get { return this._trustStoreArn; }
            set { this._trustStoreArn = value; }
        }

        // Check to see if TrustStoreArn property is set
        internal bool IsSetTrustStoreArn()
        {
            return this._trustStoreArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreAssociationStatus. 
        /// <para>
        /// Indicates a shared trust stores association status.
        /// </para>
        /// </summary>
        public TrustStoreAssociationStatusEnum TrustStoreAssociationStatus
        {
            get { return this._trustStoreAssociationStatus; }
            set { this._trustStoreAssociationStatus = value; }
        }

        // Check to see if TrustStoreAssociationStatus property is set
        internal bool IsSetTrustStoreAssociationStatus()
        {
            return this._trustStoreAssociationStatus != null;
        }

    }
}