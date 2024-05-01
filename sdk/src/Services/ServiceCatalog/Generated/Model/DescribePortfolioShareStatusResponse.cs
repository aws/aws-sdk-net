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
 * Do not modify this file. This file is generated from the servicecatalog-2015-12-10.normal.json service model.
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
        private string _organizationNodeValue;
        private string _portfolioId;
        private string _portfolioShareToken;
        private ShareDetails _shareDetails;
        private ShareStatus _status;

        /// <summary>
        /// Gets and sets the property OrganizationNodeValue. 
        /// <para>
        /// Organization node identifier. It can be either account id, organizational unit id
        /// or organization id.
        /// </para>
        /// </summary>
        public string OrganizationNodeValue
        {
            get { return this._organizationNodeValue; }
            set { this._organizationNodeValue = value; }
        }

        // Check to see if OrganizationNodeValue property is set
        internal bool IsSetOrganizationNodeValue()
        {
            return this._organizationNodeValue != null;
        }

        /// <summary>
        /// Gets and sets the property PortfolioId. 
        /// <para>
        /// The portfolio identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PortfolioId
        {
            get { return this._portfolioId; }
            set { this._portfolioId = value; }
        }

        // Check to see if PortfolioId property is set
        internal bool IsSetPortfolioId()
        {
            return this._portfolioId != null;
        }

        /// <summary>
        /// Gets and sets the property PortfolioShareToken. 
        /// <para>
        /// The token for the portfolio share operation. For example, <c>share-6v24abcdefghi</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string PortfolioShareToken
        {
            get { return this._portfolioShareToken; }
            set { this._portfolioShareToken = value; }
        }

        // Check to see if PortfolioShareToken property is set
        internal bool IsSetPortfolioShareToken()
        {
            return this._portfolioShareToken != null;
        }

        /// <summary>
        /// Gets and sets the property ShareDetails. 
        /// <para>
        /// Information about the portfolio share operation.
        /// </para>
        /// </summary>
        public ShareDetails ShareDetails
        {
            get { return this._shareDetails; }
            set { this._shareDetails = value; }
        }

        // Check to see if ShareDetails property is set
        internal bool IsSetShareDetails()
        {
            return this._shareDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the portfolio share operation.
        /// </para>
        /// </summary>
        public ShareStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}