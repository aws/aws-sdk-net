/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudfront-2018-06-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDistribution operation.
    /// Creates a new web distribution. You create a CloudFront distribution to tell CloudFront
    /// where you want content to be delivered from, and the details about how to track and
    /// manage content delivery. Send a <code>POST</code> request to the <code>/<i>CloudFront
    /// API version</i>/distribution</code>/<code>distribution ID</code> resource.
    /// 
    ///  <important> 
    /// <para>
    /// When you update a distribution, there are more required fields than when you create
    /// a distribution. When you update your distribution by using <a>UpdateDistribution</a>,
    /// follow the steps included in the documentation to get the current configuration and
    /// then make your updates. This helps to make sure that you include all of the required
    /// fields. To view a summary, see <a href="http://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/distribution-overview-required-fields.html">Required
    /// Fields for Create Distribution and Update Distribution</a> in the <i>Amazon CloudFront
    /// Developer Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// If you are using Adobe Flash Media Server's RTMP protocol, you set up a different
    /// kind of CloudFront distribution. For more information, see <a>CreateStreamingDistribution</a>.
    /// </para>
    /// </summary>
    public partial class CreateDistributionRequest : AmazonCloudFrontRequest
    {
        private DistributionConfig _distributionConfig;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateDistributionRequest() { }

        /// <summary>
        /// Instantiates CreateDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="distributionConfig">The distribution's configuration information.</param>
        public CreateDistributionRequest(DistributionConfig distributionConfig)
        {
            _distributionConfig = distributionConfig;
        }

        /// <summary>
        /// Gets and sets the property DistributionConfig. 
        /// <para>
        /// The distribution's configuration information.
        /// </para>
        /// </summary>
        public DistributionConfig DistributionConfig
        {
            get { return this._distributionConfig; }
            set { this._distributionConfig = value; }
        }

        // Check to see if DistributionConfig property is set
        internal bool IsSetDistributionConfig()
        {
            return this._distributionConfig != null;
        }

    }
}