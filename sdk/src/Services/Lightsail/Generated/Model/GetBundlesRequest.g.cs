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
    /// Container for the parameters to the GetBundles operation. Returns the bundles that
    /// you can apply to an Amazon Lightsail instance when you create it. <para> A bundle
    /// describes the specifications of an instance, such as the monthly cost, amount of memory,
    /// the number of vCPUs, amount of storage space, and monthly network data transfer quota.
    /// </para> <note> <para> Bundles are referred to as <i>instance plans</i> in the Lightsail
    /// console. </para> </note>
    /// </summary>
    public partial class GetBundlesRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property AppCategory. 
        /// <para>
        /// Returns a list of bundles that are specific to Lightsail for Research.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must use this parameter to view Lightsail for Research bundles.
        /// </para>
        ///  </important>
        /// </summary>
        public AppCategory AppCategory { get; set; }

        /// <summary>
        /// Checks to see if the AppCategory property is set.
        /// </summary>
        internal bool IsSetAppCategory() => this.AppCategory != null;

        /// <summary>
        /// Gets and sets the property IncludeInactive. 
        /// <para>
        /// A Boolean value that indicates whether to include inactive (unavailable) bundles in
        /// the response of your request.
        /// </para>
        /// </summary>
        public bool? IncludeInactive { get; set; }

        /// <summary>
        /// Checks to see if the IncludeInactive property is set.
        /// </summary>
        internal bool IsSetIncludeInactive() => this.IncludeInactive.HasValue;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The token to advance to the next page of results from your request.
        /// </para>
        ///  
        /// <para>
        /// To get a page token, perform an initial <c>GetBundles</c> request. If your results
        /// are paginated, the response will return a next page token that you can specify as
        /// the page token in a subsequent request.
        /// </para>
        /// </summary>
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;
    }
}
