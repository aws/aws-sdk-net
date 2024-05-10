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
    /// This is the response object from the UpdatePortfolioShare operation.
    /// </summary>
    public partial class UpdatePortfolioShareResponse : AmazonWebServiceResponse
    {
        private string _portfolioShareToken;
        private ShareStatus _status;

        /// <summary>
        /// Gets and sets the property PortfolioShareToken. 
        /// <para>
        /// The token that tracks the status of the <c>UpdatePortfolioShare</c> operation for
        /// external account to account or organizational type sharing.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of <c>UpdatePortfolioShare</c> operation. You can also obtain the operation
        /// status using <c>DescribePortfolioShareStatus</c> API. 
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