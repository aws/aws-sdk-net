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
    /// This is the response object from the DescribePortfolioShareStatus operation.
    /// </summary>
    public partial class DescribePortfolioShareStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property OrganizationNodeValue. 
        /// <para>
        /// Organization node identifier. It can be either account id, organizational unit id
        /// or organization id.
        /// </para>
        /// </summary>
        public string OrganizationNodeValue { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationNodeValue property is set.
        /// </summary>
        internal bool IsSetOrganizationNodeValue() => this.OrganizationNodeValue != null;

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The portfolio identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// Checks to see if the PortfolioId property is set.
        /// </summary>
        internal bool IsSetPortfolioId() => this.PortfolioId != null;

        /// <summary>
        /// Gets and sets the property PortfolioShareToken. 
        /// <para>
        /// The token for the portfolio share operation. For example, <c>share-6v24abcdefghi</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string PortfolioShareToken { get; set; }

        /// <summary>
        /// Checks to see if the PortfolioShareToken property is set.
        /// </summary>
        internal bool IsSetPortfolioShareToken() => this.PortfolioShareToken != null;

        /// <summary>
        /// Gets and sets the property ShareDetails. 
        /// <para>
        /// Information about the portfolio share operation.
        /// </para>
        /// </summary>
        public ShareDetails ShareDetails { get; set; }

        /// <summary>
        /// Checks to see if the ShareDetails property is set.
        /// </summary>
        internal bool IsSetShareDetails() => this.ShareDetails != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the portfolio share operation.
        /// </para>
        /// </summary>
        public ShareStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
