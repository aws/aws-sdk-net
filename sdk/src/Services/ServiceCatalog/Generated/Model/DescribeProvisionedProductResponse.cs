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

namespace Amazon.ServiceCatalog.Model
{
    /// <summary>
    /// This is the response object from the DescribeProvisionedProduct operation.
    /// </summary>
    public partial class DescribeProvisionedProductResponse : AmazonWebServiceResponse
    {
        private List<CloudWatchDashboard> _cloudWatchDashboards = new List<CloudWatchDashboard>();
        private ProvisionedProductDetail _provisionedProductDetail;

        /// <summary>
        /// Gets and sets the property CloudWatchDashboards. 
        /// <para>
        /// Any CloudWatch dashboards that were created when provisioning the product.
        /// </para>
        /// </summary>
        public List<CloudWatchDashboard> CloudWatchDashboards
        {
            get { return this._cloudWatchDashboards; }
            set { this._cloudWatchDashboards = value; }
        }

        // Check to see if CloudWatchDashboards property is set
        internal bool IsSetCloudWatchDashboards()
        {
            return this._cloudWatchDashboards != null && this._cloudWatchDashboards.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProvisionedProductDetail. 
        /// <para>
        /// Information about the provisioned product.
        /// </para>
        /// </summary>
        public ProvisionedProductDetail ProvisionedProductDetail
        {
            get { return this._provisionedProductDetail; }
            set { this._provisionedProductDetail = value; }
        }

        // Check to see if ProvisionedProductDetail property is set
        internal bool IsSetProvisionedProductDetail()
        {
            return this._provisionedProductDetail != null;
        }

    }
}