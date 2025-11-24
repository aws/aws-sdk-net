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
    /// Container for the parameters to the UpdateTrustStore operation.
    /// Updates a trust store.
    /// </summary>
    public partial class UpdateTrustStoreRequest : AmazonCloudFrontRequest
    {
        private CaCertificatesBundleSource _caCertificatesBundleSource;
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Gets and sets the property CaCertificatesBundleSource. 
        /// <para>
        /// The CA certificates bundle source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CaCertificatesBundleSource CaCertificatesBundleSource
        {
            get { return this._caCertificatesBundleSource; }
            set { this._caCertificatesBundleSource = value; }
        }

        // Check to see if CaCertificatesBundleSource property is set
        internal bool IsSetCaCertificatesBundleSource()
        {
            return this._caCertificatesBundleSource != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The trust store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The current version (<c>ETag</c> value) of the trust store you are updating.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return !string.IsNullOrEmpty(this._ifMatch);
        }

    }
}