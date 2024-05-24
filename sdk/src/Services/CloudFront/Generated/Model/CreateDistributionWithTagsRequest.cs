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
    /// Container for the parameters to the CreateDistributionWithTags operation.
    /// Create a new distribution with tags. This API operation requires the following IAM
    /// permissions:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_CreateDistribution.html">CreateDistribution</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cloudfront/latest/APIReference/API_TagResource.html">TagResource</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateDistributionWithTagsRequest : AmazonCloudFrontRequest
    {
        private DistributionConfigWithTags _distributionConfigWithTags;

        /// <summary>
        /// Gets and sets the property DistributionConfigWithTags. 
        /// <para>
        /// The distribution's configuration information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DistributionConfigWithTags DistributionConfigWithTags
        {
            get { return this._distributionConfigWithTags; }
            set { this._distributionConfigWithTags = value; }
        }

        // Check to see if DistributionConfigWithTags property is set
        internal bool IsSetDistributionConfigWithTags()
        {
            return this._distributionConfigWithTags != null;
        }

    }
}