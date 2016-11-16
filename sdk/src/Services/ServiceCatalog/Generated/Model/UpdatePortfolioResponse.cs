/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the UpdatePortfolio operation.
    /// </summary>
    public partial class UpdatePortfolioResponse : AmazonWebServiceResponse
    {
        private PortfolioDetail _portfolioDetail;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property PortfolioDetail. 
        /// <para>
        /// The resulting detailed portfolio information.
        /// </para>
        /// </summary>
        public PortfolioDetail PortfolioDetail
        {
            get { return this._portfolioDetail; }
            set { this._portfolioDetail = value; }
        }

        // Check to see if PortfolioDetail property is set
        internal bool IsSetPortfolioDetail()
        {
            return this._portfolioDetail != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags associated with the portfolio.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}