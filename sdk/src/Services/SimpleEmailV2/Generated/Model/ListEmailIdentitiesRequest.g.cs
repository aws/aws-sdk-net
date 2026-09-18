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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListEmailIdentities operation. Returns a list
    /// of all of the email identities that are associated with your Amazon Web Services account.
    /// An identity can be either an email address or a domain. This operation returns identities
    /// that are verified as well as those that aren't. This operation returns identities
    /// that are associated with Amazon SES and Amazon Pinpoint.
    /// </summary>
    public partial class ListEmailIdentitiesRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token returned from a previous call to <c>ListEmailIdentities</c> to indicate the
        /// position in the list of identities.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The number of results to show in a single call to <c>ListEmailIdentities</c>. If the
        /// number of results is larger than the number you specified in this parameter, then
        /// the response includes a <c>NextToken</c> element, which you can use to obtain additional
        /// results.
        /// </para>
        ///  
        /// <para>
        /// The value you specify has to be at least 0, and can be no more than 1000.
        /// </para>
        /// </summary>
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;
    }
}
