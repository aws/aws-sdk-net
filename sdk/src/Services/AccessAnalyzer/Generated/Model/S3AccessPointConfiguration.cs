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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The configuration for an Amazon S3 access point or multi-region access point for the
    /// bucket. You can propose up to 10 access points or multi-region access points per bucket.
    /// If the proposed Amazon S3 access point configuration is for an existing bucket, the
    /// access preview uses the proposed access point configuration in place of the existing
    /// access points. To propose an access point without a policy, you can provide an empty
    /// string as the access point policy. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/creating-access-points.html">Creating
    /// access points</a>. For more information about access point policy limits, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-points-restrictions-limitations.html">Access
    /// points restrictions and limitations</a>.
    /// </summary>
    public partial class S3AccessPointConfiguration
    {
        private string _accessPointPolicy;
        private NetworkOriginConfiguration _networkOrigin;
        private S3PublicAccessBlockConfiguration _publicAccessBlock;

        /// <summary>
        /// Gets and sets the property AccessPointPolicy. 
        /// <para>
        /// The access point or multi-region access point policy.
        /// </para>
        /// </summary>
        public string AccessPointPolicy
        {
            get { return this._accessPointPolicy; }
            set { this._accessPointPolicy = value; }
        }

        // Check to see if AccessPointPolicy property is set
        internal bool IsSetAccessPointPolicy()
        {
            return this._accessPointPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkOrigin. 
        /// <para>
        /// The proposed <c>Internet</c> and <c>VpcConfiguration</c> to apply to this Amazon S3
        /// access point. <c>VpcConfiguration</c> does not apply to multi-region access points.
        /// If the access preview is for a new resource and neither is specified, the access preview
        /// uses <c>Internet</c> for the network origin. If the access preview is for an existing
        /// resource and neither is specified, the access preview uses the existing network origin.
        /// </para>
        /// </summary>
        public NetworkOriginConfiguration NetworkOrigin
        {
            get { return this._networkOrigin; }
            set { this._networkOrigin = value; }
        }

        // Check to see if NetworkOrigin property is set
        internal bool IsSetNetworkOrigin()
        {
            return this._networkOrigin != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccessBlock. 
        /// <para>
        /// The proposed <c>S3PublicAccessBlock</c> configuration to apply to this Amazon S3 access
        /// point or multi-region access point.
        /// </para>
        /// </summary>
        public S3PublicAccessBlockConfiguration PublicAccessBlock
        {
            get { return this._publicAccessBlock; }
            set { this._publicAccessBlock = value; }
        }

        // Check to see if PublicAccessBlock property is set
        internal bool IsSetPublicAccessBlock()
        {
            return this._publicAccessBlock != null;
        }

    }
}