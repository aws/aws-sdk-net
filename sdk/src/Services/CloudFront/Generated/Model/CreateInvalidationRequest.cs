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
    /// Container for the parameters to the CreateInvalidation operation.
    /// Create a new invalidation. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/Invalidation.html">Invalidating
    /// files</a> in the <i>Amazon CloudFront Developer Guide</i>.
    /// </summary>
    public partial class CreateInvalidationRequest : AmazonCloudFrontRequest
    {
        private string _distributionId;
        private InvalidationBatch _invalidationBatch;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateInvalidationRequest() { }

        /// <summary>
        /// Instantiates CreateInvalidationRequest with the parameterized properties
        /// </summary>
        /// <param name="distributionId">The distribution's id.</param>
        /// <param name="invalidationBatch">The batch information for the invalidation.</param>
        public CreateInvalidationRequest(string distributionId, InvalidationBatch invalidationBatch)
        {
            _distributionId = distributionId;
            _invalidationBatch = invalidationBatch;
        }

        /// <summary>
        /// Gets and sets the property DistributionId. 
        /// <para>
        /// The distribution's id.
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
        /// Gets and sets the property InvalidationBatch. 
        /// <para>
        /// The batch information for the invalidation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InvalidationBatch InvalidationBatch
        {
            get { return this._invalidationBatch; }
            set { this._invalidationBatch = value; }
        }

        // Check to see if InvalidationBatch property is set
        internal bool IsSetInvalidationBatch()
        {
            return this._invalidationBatch != null;
        }

    }
}