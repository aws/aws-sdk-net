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
    /// Container for the parameters to the DeleteDistribution operation. Delete a distribution.
    /// <important> <para> Before you can delete a distribution, you must disable it, which
    /// requires permission to update the distribution. Once deleted, a distribution cannot
    /// be recovered. </para> </important>
    /// </summary>
    public partial class DeleteDistributionRequest : AmazonCloudFrontRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public DeleteDistributionRequest() { }

        /// <summary>
        /// Instantiates DeleteDistributionRequest with the parameterized properties
        /// </summary>
        /// <param name="id">The distribution ID.</param>
        /// <param name="ifMatch">The value of the <c>ETag</c> header that you received when you disabled the distribution. For example: <c>E2QWRUHAPOMQZL</c>.</param>
        public DeleteDistributionRequest(string id, string ifMatch)
        {
            this.Id = id;
            this.IfMatch = ifMatch;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The distribution ID.
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
        /// The value of the <c>ETag</c> header that you received when you disabled the distribution.
        /// For example: <c>E2QWRUHAPOMQZL</c>.
        /// </para>
        /// </summary>
        public string IfMatch { get; set; }

        /// <summary>
        /// Checks to see if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch() => this.IfMatch != null;
    }
}
