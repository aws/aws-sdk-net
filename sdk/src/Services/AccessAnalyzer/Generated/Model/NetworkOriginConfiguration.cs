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
    /// The proposed <c>InternetConfiguration</c> or <c>VpcConfiguration</c> to apply to the
    /// Amazon S3 access point. You can make the access point accessible from the internet,
    /// or you can specify that all requests made through that access point must originate
    /// from a specific virtual private cloud (VPC). You can specify only one type of network
    /// configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/creating-access-points.html">Creating
    /// access points</a>.
    /// </summary>
    public partial class NetworkOriginConfiguration
    {
        private InternetConfiguration _internetConfiguration;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property InternetConfiguration. 
        /// <para>
        /// The configuration for the Amazon S3 access point or multi-region access point with
        /// an <c>Internet</c> origin.
        /// </para>
        /// </summary>
        public InternetConfiguration InternetConfiguration
        {
            get { return this._internetConfiguration; }
            set { this._internetConfiguration = value; }
        }

        // Check to see if InternetConfiguration property is set
        internal bool IsSetInternetConfiguration()
        {
            return this._internetConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration.
        /// </summary>
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}