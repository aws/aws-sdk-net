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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the ListProtocolsLists operation. Returns an array
    /// of <c>ProtocolsListDataSummary</c> objects.
    /// </summary>
    public partial class ListProtocolsListsRequest : AmazonFMSRequest
    {
        /// <summary>
        /// Gets and sets the property DefaultLists. 
        /// <para>
        /// Specifies whether the lists to retrieve are default lists owned by Firewall Manager.
        /// </para>
        /// </summary>
        public bool? DefaultLists { get; set; }

        /// <summary>
        /// Checks to see if the DefaultLists property is set.
        /// </summary>
        internal bool IsSetDefaultLists() => this.DefaultLists.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of objects that you want Firewall Manager to return for this request.
        /// If more objects are available, in the response, Firewall Manager provides a <c>NextToken</c>
        /// value that you can use in a subsequent call to get the next batch of objects.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify this, Firewall Manager returns all available objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify a value for <c>MaxResults</c> in your list request, and you have more
        /// objects than the maximum, Firewall Manager returns this token in the response. For
        /// all but the first request, you provide the token returned by the prior request in
        /// the request parameters, to retrieve the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
