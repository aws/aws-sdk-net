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
    /// This is the response object from the DescribeProvisionedProductPlan operation.
    /// </summary>
    public partial class DescribeProvisionedProductPlanResponse : AmazonWebServiceResponse
    {
        private string _nextPageToken;
        private ProvisionedProductPlanDetails _provisionedProductPlanDetails;
        private List<ResourceChange> _resourceChanges = new List<ResourceChange>();

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The page token to use to retrieve the next set of results. If there are no additional
        /// results, this value is null.
        /// </para>
        /// </summary>
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductPlanDetails. 
        /// <para>
        /// Information about the plan.
        /// </para>
        /// </summary>
        public ProvisionedProductPlanDetails ProvisionedProductPlanDetails
        {
            get { return this._provisionedProductPlanDetails; }
            set { this._provisionedProductPlanDetails = value; }
        }

        // Check to see if ProvisionedProductPlanDetails property is set
        internal bool IsSetProvisionedProductPlanDetails()
        {
            return this._provisionedProductPlanDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceChanges. 
        /// <para>
        /// Information about the resource changes that will occur when the plan is executed.
        /// </para>
        /// </summary>
        public List<ResourceChange> ResourceChanges
        {
            get { return this._resourceChanges; }
            set { this._resourceChanges = value; }
        }

        // Check to see if ResourceChanges property is set
        internal bool IsSetResourceChanges()
        {
            return this._resourceChanges != null && this._resourceChanges.Count > 0; 
        }

    }
}