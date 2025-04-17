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
    /// Proposed configuration for an access point attached to an Amazon S3 directory bucket.
    /// You can propose up to 10 access points per bucket. If the proposed access point configuration
    /// is for an existing Amazon S3 directory bucket, the access preview uses the proposed
    /// access point configuration in place of the existing access points. To propose an access
    /// point without a policy, you can provide an empty string as the access point policy.
    /// For more information about access points for Amazon S3 directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-points-directory-buckets.html">Managing
    /// access to directory buckets with access points</a> in the Amazon Simple Storage Service
    /// User Guide.
    /// </summary>
    public partial class S3ExpressDirectoryAccessPointConfiguration
    {
        private string _accessPointPolicy;
        private NetworkOriginConfiguration _networkOrigin;

        /// <summary>
        /// Gets and sets the property AccessPointPolicy. 
        /// <para>
        /// The proposed access point policy for an Amazon S3 directory bucket access point.
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

    }
}