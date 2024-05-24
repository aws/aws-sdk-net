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
    /// Container for the parameters to the GetInvalidation operation.
    /// Get the information about an invalidation.
    /// </summary>
    public partial class GetInvalidationRequest : AmazonCloudFrontRequest
    {
        private string _distributionId;
        private string _id;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetInvalidationRequest() { }

        /// <summary>
        /// Instantiates GetInvalidationRequest with the parameterized properties
        /// </summary>
        /// <param name="distributionId">The distribution's ID.</param>
        /// <param name="id">The identifier for the invalidation request, for example, <c>IDFDVBD632BHDS5</c>.</param>
        public GetInvalidationRequest(string distributionId, string id)
        {
            _distributionId = distributionId;
            _id = id;
        }

        /// <summary>
        /// Gets and sets the property DistributionId. 
        /// <para>
        /// The distribution's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DistributionId
        {
            get { return this._distributionId; }
            set { this._distributionId = value; }
        }

        // Check to see if DistributionId property is set
        internal bool IsSetDistributionId()
        {
            return this._distributionId != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the invalidation request, for example, <c>IDFDVBD632BHDS5</c>.
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

    }
}