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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// This is the response object from the DescribeBrand operation.
    /// </summary>
    public partial class DescribeBrandResponse : AmazonWebServiceResponse
    {
        private BrandDefinition _brandDefinition;
        private BrandDetail _brandDetail;
        private string _requestId;

        /// <summary>
        /// Gets and sets the property BrandDefinition. 
        /// <para>
        /// The definition of the brand.
        /// </para>
        /// </summary>
        public BrandDefinition BrandDefinition
        {
            get { return this._brandDefinition; }
            set { this._brandDefinition = value; }
        }

        // Check to see if BrandDefinition property is set
        internal bool IsSetBrandDefinition()
        {
            return this._brandDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property BrandDetail. 
        /// <para>
        /// The details of the brand.
        /// </para>
        /// </summary>
        public BrandDetail BrandDetail
        {
            get { return this._brandDetail; }
            set { this._brandDetail = value; }
        }

        // Check to see if BrandDetail property is set
        internal bool IsSetBrandDetail()
        {
            return this._brandDetail != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. 
        /// <para>
        /// The Amazon Web Services request ID for this operation.
        /// </para>
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

    }
}