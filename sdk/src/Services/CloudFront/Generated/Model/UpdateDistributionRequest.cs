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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDistribution operation.
    /// Updates the configuration for a CloudFront distribution.
    /// 
    ///  
    /// <para>
    /// The update process includes getting the current distribution configuration, updating
    /// it to make your changes, and then submitting an <code>UpdateDistribution</code> request
    /// to make the updates.
    /// </para>
    ///  
    /// <para>
    ///  <b>To update a web distribution using the CloudFront API</b> 
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Use <code>GetDistributionConfig</code> to get the current configuration, including
    /// the version identifier (<code>ETag</code>).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Update the distribution configuration that was returned in the response. Note the
    /// following important requirements and restrictions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must rename the <code>ETag</code> field to <code>IfMatch</code>, leaving the value
    /// unchanged. (Set the value of <code>IfMatch</code> to the value of <code>ETag</code>,
    /// then remove the <code>ETag</code> field.)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can't change the value of <code>CallerReference</code>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    /// Submit an <code>UpdateDistribution</code> request, providing the distribution configuration.
    /// The new configuration replaces the existing configuration. The values that you specify
    /// in an <code>UpdateDistribution</code> request are not merged into your existing configuration.
    /// Make sure to include all fields: the ones that you modified and also the ones that
    /// you didn't.
    /// </para>
    ///  </li> </ol>
    /// </summary>
    public partial class UpdateDistributionRequest : AmazonCloudFrontRequest
    {
        private DistributionConfig _distributionConfig;
        private string _id;
        private string _ifMatch;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UpdateDistributionRequest() { }

        /// <summary>
        /// Instantiates UpdateDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The distribution's id.</param>
        /// <param name="ifMatch">The value of the <code>ETag</code> header that you received when retrieving the distribution's configuration. For example: <code>E2QWRUHAPOMQZL</code>.</param>
        /// <param name="distributionConfig">The distribution's configuration information.</param>
        public UpdateDistributionRequest(string id, string ifMatch, DistributionConfig distributionConfig)
        {
            _id = id;
            _ifMatch = ifMatch;
            _distributionConfig = distributionConfig;
        }

        /// <summary>
        /// Gets and sets the property DistributionConfig. 
        /// <para>
        /// The distribution's configuration information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The distribution's id.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The value of the <code>ETag</code> header that you received when retrieving the distribution's
        /// configuration. For example: <code>E2QWRUHAPOMQZL</code>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

    }
}