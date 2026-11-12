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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the GetSubdomains operation. Returns information about
    /// one or more of your Lightsail subdomains. <para> When you don't specify a subdomain,
    /// the response lists your top-level subdomains, and each top-level subdomain includes
    /// its nested subdomains. </para> <para> The results are paginated. To get the next page
    /// of results, use the <c>pageToken</c> parameter. </para>
    /// </summary>
    public partial class GetSubdomainsRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetSubdomains</c> request. If your results
        /// are paginated, the response will return a next page token that you can specify as
        /// the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;

        /// <summary>
        /// Gets and sets the property SubdomainName. 
        /// <para>
        /// The subdomain for which to return information (for example, <c>mysite</c> or <c>blog.mysite</c>),
        /// not its web address.
        /// </para>
        ///  
        /// <para>
        /// When omitted, the response includes all of your subdomains.
        /// </para>
        ///  
        /// <para>
        /// You can't specify this parameter together with the <c>pageToken</c> parameter.
        /// </para>
        /// </summary>
        public string SubdomainName { get; set; }

        /// <summary>
        /// Checks to see if the SubdomainName property is set.
        /// </summary>
        internal bool IsSetSubdomainName() => this.SubdomainName != null;
    }
}
