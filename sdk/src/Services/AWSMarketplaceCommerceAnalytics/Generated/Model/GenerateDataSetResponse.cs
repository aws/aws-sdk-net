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
 * Do not modify this file. This file is generated from the marketplacecommerceanalytics-2015-07-01.normal.json service model.
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
namespace Amazon.AWSMarketplaceCommerceAnalytics.Model
{
    /// <summary>
    /// Container for the result of the GenerateDataSet operation.
    /// </summary>
    public partial class GenerateDataSetResponse : AmazonWebServiceResponse
    {
        private string _dataSetRequestId;

        /// <summary>
        /// Gets and sets the property DataSetRequestId. A unique identifier representing a specific
        /// request to the GenerateDataSet operation. This identifier can be used to correlate
        /// a request with notifications from the SNS topic.
        /// </summary>
        public string DataSetRequestId
        {
            get { return this._dataSetRequestId; }
            set { this._dataSetRequestId = value; }
        }

        // Check to see if DataSetRequestId property is set
        internal bool IsSetDataSetRequestId()
        {
            return this._dataSetRequestId != null;
        }

    }
}