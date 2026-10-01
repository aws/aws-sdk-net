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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the ListSigningPlatforms operation. Lists all signing
    /// platforms available in AWS Signer that match the request parameters. If additional
    /// jobs remain to be listed, Signer returns a <c>nextToken</c> value. Use this value
    /// in subsequent calls to <c>ListSigningJobs</c> to fetch the remaining values. You can
    /// continue calling <c>ListSigningJobs</c> with your <c>maxResults</c> parameter and
    /// with new values that Signer returns in the <c>nextToken</c> parameter until all of
    /// your signing jobs have been returned.
    /// </summary>
    public partial class ListSigningPlatformsRequest : AmazonSignerRequest
    {
        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category type of a signing platform.
        /// </para>
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned by this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 25)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Value for specifying the next set of paginated results to return. After you receive
        /// a response with truncated results, use this parameter in a subsequent request. Set
        /// it to the value of <c>nextToken</c> from the response that you just received.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Partner. 
        /// <para>
        /// Any partner entities connected to a signing platform.
        /// </para>
        /// </summary>
        public string Partner { get; set; }

        /// <summary>
        /// Checks to see if the Partner property is set.
        /// </summary>
        internal bool IsSetPartner() => this.Partner != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The validation template that is used by the target signing platform.
        /// </para>
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;
    }
}
