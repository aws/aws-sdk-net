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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A trust store configuration.
    /// </summary>
    public partial class TrustStoreConfig
    {
        private bool? _advertiseTrustStoreCaNames;
        private bool? _ignoreCertificateExpiry;
        private string _trustStoreId;

        /// <summary>
        /// Gets and sets the property AdvertiseTrustStoreCaNames. 
        /// <para>
        /// The configuration to use to advertise trust store CA names.
        /// </para>
        /// </summary>
        public bool? AdvertiseTrustStoreCaNames
        {
            get { return this._advertiseTrustStoreCaNames; }
            set { this._advertiseTrustStoreCaNames = value; }
        }

        // Check to see if AdvertiseTrustStoreCaNames property is set
        internal bool IsSetAdvertiseTrustStoreCaNames()
        {
            return this._advertiseTrustStoreCaNames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnoreCertificateExpiry. 
        /// <para>
        /// The configuration to use to ignore certificate expiration.
        /// </para>
        /// </summary>
        public bool? IgnoreCertificateExpiry
        {
            get { return this._ignoreCertificateExpiry; }
            set { this._ignoreCertificateExpiry = value; }
        }

        // Check to see if IgnoreCertificateExpiry property is set
        internal bool IsSetIgnoreCertificateExpiry()
        {
            return this._ignoreCertificateExpiry.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrustStoreId. 
        /// <para>
        /// The trust store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrustStoreId
        {
            get { return this._trustStoreId; }
            set { this._trustStoreId = value; }
        }

        // Check to see if TrustStoreId property is set
        internal bool IsSetTrustStoreId()
        {
            return this._trustStoreId != null;
        }

    }
}