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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// Container for the parameters to the DescribePortfolioShares operation. Returns a summary
    /// of each of the portfolio shares that were created for the specified portfolio. <para>
    /// You can use this API to determine which accounts or organizational nodes this portfolio
    /// have been shared, whether the recipient entity has imported the share, and whether
    /// TagOptions are included with the share. </para> <para> The <c>PortfolioId</c> and
    /// <c>Type</c> parameters are both required. </para>
    /// </summary>
    public partial class DescribePortfolioSharesRequest : AmazonServiceCatalogRequest
    {
        /// <summary>
        /// Gets and sets the property PageSize. 
        /// <para>
        /// The maximum number of items to return with this call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? PageSize { get; set; }

        /// <summary>
        /// Checks to see if the PageSize property is set.
        /// </summary>
        internal bool IsSetPageSize() => this.PageSize.HasValue;

        /// <summary>
        /// Gets and sets the property PageToken. 
        /// <para>
        /// The page token for the next set of results. To retrieve the first set of results,
        /// use null.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2024)]
        public string PageToken { get; set; }

        /// <summary>
        /// Checks to see if the PageToken property is set.
        /// </summary>
        internal bool IsSetPageToken() => this.PageToken != null;

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The unique identifier of the portfolio for which shares will be retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// Checks to see if the PortfolioId property is set.
        /// </summary>
        internal bool IsSetPortfolioId() => this.PortfolioId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of portfolio share to summarize. This field acts as a filter on the type
        /// of portfolio share, which can be one of the following:
        /// </para>
        ///  
        /// <para>
        /// 1. <c>ACCOUNT</c> - Represents an external account to account share.
        /// </para>
        ///  
        /// <para>
        /// 2. <c>ORGANIZATION</c> - Represents a share to an organization. This share is available
        /// to every account in the organization.
        /// </para>
        ///  
        /// <para>
        /// 3. <c>ORGANIZATIONAL_UNIT</c> - Represents a share to an organizational unit.
        /// </para>
        ///  
        /// <para>
        /// 4. <c>ORGANIZATION_MEMBER_ACCOUNT</c> - Represents a share to an account in the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DescribePortfolioShareType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
