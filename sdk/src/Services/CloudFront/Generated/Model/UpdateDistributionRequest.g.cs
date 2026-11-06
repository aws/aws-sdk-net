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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the UpdateDistribution operation. Updates the configuration
    /// for a CloudFront distribution. <para> The update process includes getting the current
    /// distribution configuration, updating it to make your changes, and then submitting
    /// an <c>UpdateDistribution</c> request to make the updates. </para> <para> <b>To update
    /// a web distribution using the CloudFront API</b> </para> <ol> <li> <para> Use <c>GetDistributionConfig</c>
    /// to get the current configuration, including the version identifier (<c>ETag</c>).
    /// </para> </li> <li> <para> Update the distribution configuration that was returned
    /// in the response. Note the following important requirements and restrictions: </para>
    /// <ul> <li> <para> You must copy the <c>ETag</c> field value from the response. (You'll
    /// use it for the <c>IfMatch</c> parameter in your request.) Then, remove the <c>ETag</c>
    /// field from the distribution configuration. </para> </li> <li> <para> You can't change
    /// the value of <c>CallerReference</c>. </para> </li> </ul> </li> <li> <para> Submit
    /// an <c>UpdateDistribution</c> request, providing the updated distribution configuration.
    /// The new configuration replaces the existing configuration. The values that you specify
    /// in an <c>UpdateDistribution</c> request are not merged into your existing configuration.
    /// Make sure to include all fields: the ones that you modified and also the ones that
    /// you didn't. </para> </li> </ol>
    /// </summary>
    public partial class UpdateDistributionRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public UpdateDistributionRequest() { }

        /// <summary>
        /// Instantiates UpdateDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The distribution's id.</param>
        /// <param name="ifMatch">The value of the <c>ETag</c> header that you received when retrieving the distribution's configuration. For example: <c>E2QWRUHAPOMQZL</c>.</param>
        /// <param name="distributionConfig">The distribution's configuration information.</param>
        public UpdateDistributionRequest(string id, string ifMatch, DistributionConfig distributionConfig)
        {
            this.Id = id;
            this.IfMatch = ifMatch;
            this.DistributionConfig = distributionConfig;
        }

        /// <summary>
        /// Gets and sets the property DistributionConfig. 
        /// <para>
        /// The distribution's configuration information.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DistributionConfig DistributionConfig { get; set; }

        /// <summary>
        /// Checks to see if the DistributionConfig property is set.
        /// </summary>
        internal bool IsSetDistributionConfig() => this.DistributionConfig != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The distribution's id.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// The value of the <c>ETag</c> header that you received when retrieving the distribution's
        /// configuration. For example: <c>E2QWRUHAPOMQZL</c>.
        /// </para>
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;
    }
}
