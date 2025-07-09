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
    /// Container for the parameters to the CreateTrustStore operation.
    /// Creates a trust store.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/mutual-authentication.html">Mutual
    /// TLS for Application Load Balancers</a>.
    /// </para>
    /// </summary>
    public partial class CreateTrustStoreRequest : AmazonElasticLoadBalancingV2Request
    {
        private string _caCertificatesBundleS3Bucket;
        private string _caCertificatesBundleS3Key;
        private string _caCertificatesBundleS3ObjectVersion;
        private string _name;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the trust store.
        /// </para>
        ///  
        /// <para>
        /// This name must be unique per region and can't be changed after creation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// <para>
        /// The tags to assign to the trust store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}