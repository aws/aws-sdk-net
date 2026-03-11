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
    /// Container for the parameters to the CreateTrustStore operation.
    /// Creates a trust store.
    /// </summary>
    public partial class CreateTrustStoreRequest : AmazonCloudFrontRequest
    {
        private CaCertificatesBundleSource _caCertificatesBundleSource;
        private string _name;
        private Tags _tags;

        /// <summary>
        /// Gets and sets the property CaCertificatesBundleSource. 
        /// <para>
        /// The CA certificates bundle source for the trust store.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public Tags Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null;
        }

    }
}