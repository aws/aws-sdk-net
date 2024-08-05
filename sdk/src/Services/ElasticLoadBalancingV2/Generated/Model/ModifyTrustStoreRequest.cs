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
    /// Container for the parameters to the ModifyTrustStore operation.
    /// Update the ca certificate bundle for the specified trust store.
    /// </summary>
    public partial class ModifyTrustStoreRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _caCertificatesBundleS3Bucket;
        private string _caCertificatesBundleS3Key;
        private string _caCertificatesBundleS3ObjectVersion;
        private string _trustStoreArn;

        /// <summary>
        /// Gets and sets the property CaCertificatesBundleS3Bucket. 
        /// <para>
        /// The Amazon S3 bucket for the ca certificates bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CaCertificatesBundleS3Bucket
        {
            get { return this._caCertificatesBundleS3Bucket; }
            set { this._caCertificatesBundleS3Bucket = value; }
        }

        // Check to see if CaCertificatesBundleS3Bucket property is set
        internal bool IsSetCaCertificatesBundleS3Bucket()
        {
            return this._caCertificatesBundleS3Bucket != null;
        }

        /// <summary>
        /// Gets and sets the property CaCertificatesBundleS3Key. 
        /// <para>
        /// The Amazon S3 path for the ca certificates bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CaCertificatesBundleS3Key
        {
            get { return this._caCertificatesBundleS3Key; }
            set { this._caCertificatesBundleS3Key = value; }
        }

        // Check to see if CaCertificatesBundleS3Key property is set
        internal bool IsSetCaCertificatesBundleS3Key()
        {
            return this._caCertificatesBundleS3Key != null;
        }

        /// <summary>
        /// Gets and sets the property CaCertificatesBundleS3ObjectVersion. 
        /// <para>
        /// The Amazon S3 object version for the ca certificates bundle. If undefined the current
        /// version is used.
        /// </para>
        /// </summary>
        public string CaCertificatesBundleS3ObjectVersion
        {
            get { return this._caCertificatesBundleS3ObjectVersion; }
            set { this._caCertificatesBundleS3ObjectVersion = value; }
        }

        // Check to see if CaCertificatesBundleS3ObjectVersion property is set
        internal bool IsSetCaCertificatesBundleS3ObjectVersion()
        {
            return this._caCertificatesBundleS3ObjectVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TrustStoreArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}