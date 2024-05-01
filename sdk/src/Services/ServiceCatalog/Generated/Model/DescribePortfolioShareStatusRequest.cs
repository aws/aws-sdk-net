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
    /// Container for the parameters to the DescribePortfolioShareStatus operation.
    /// Gets the status of the specified portfolio share operation. This API can only be called
    /// by the management account in the organization or by a delegated admin.
    /// </summary>
    public partial class DescribePortfolioShareStatusRequest : AmazonServiceCatalogRequest
    {
        private string _portfolioShareToken;

        /// <summary>
        /// Gets and sets the property PortfolioShareToken. 
        /// <para>
        /// The token for the portfolio share operation. This token is returned either by CreatePortfolioShare
        /// or by DeletePortfolioShare.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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

    }
}