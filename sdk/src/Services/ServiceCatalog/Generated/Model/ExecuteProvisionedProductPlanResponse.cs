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
    /// This is the response object from the ExecuteProvisionedProductPlan operation.
    /// </summary>
    public partial class ExecuteProvisionedProductPlanResponse : AmazonWebServiceResponse
    {
        private RecordDetail _recordDetail;

        /// <summary>
        /// Gets and sets the property RecordDetail. 
        /// <para>
        /// Information about the result of provisioning the product.
        /// </para>
        /// </summary>
        public RecordDetail RecordDetail
        {
            get { return this._recordDetail; }
            set { this._recordDetail = value; }
        }

        // Check to see if RecordDetail property is set
        internal bool IsSetRecordDetail()
        {
            return this._recordDetail != null;
        }

    }
}