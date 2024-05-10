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
    /// Information about a product view.
    /// </summary>
    public partial class ProductViewDetail
    {
        private DateTime? _createdTime;
        private string _productARN;
        private ProductViewSummary _productViewSummary;
        private SourceConnectionDetail _sourceConnection;
        private Status _status;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The UTC time stamp of the creation time.
        /// </para>
        /// </summary>
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProductARN. 
        /// <para>
        /// The ARN of the product.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=150)]
        public string ProductARN
        {
            get { return this._productARN; }
            set { this._productARN = value; }
        }

        // Check to see if ProductARN property is set
        internal bool IsSetProductARN()
        {
            return this._productARN != null;
        }

        /// <summary>
        /// Gets and sets the property ProductViewSummary. 
        /// <para>
        /// Summary information about the product view.
        /// </para>
        /// </summary>
        public ProductViewSummary ProductViewSummary
        {
            get { return this._productViewSummary; }
            set { this._productViewSummary = value; }
        }

        // Check to see if ProductViewSummary property is set
        internal bool IsSetProductViewSummary()
        {
            return this._productViewSummary != null;
        }

        /// <summary>
        /// Gets and sets the property SourceConnection. 
        /// <para>
        /// A top level <c>ProductViewDetail</c> response containing details about the product’s
        /// connection. Service Catalog returns this field for the <c>CreateProduct</c>, <c>UpdateProduct</c>,
        /// <c>DescribeProductAsAdmin</c>, and <c>SearchProductAsAdmin</c> APIs. This response
        /// contains the same fields as the <c>ConnectionParameters</c> request, with the addition
        /// of the <c>LastSync</c> response.
        /// </para>
        /// </summary>
        public SourceConnectionDetail SourceConnection
        {
            get { return this._sourceConnection; }
            set { this._sourceConnection = value; }
        }

        // Check to see if SourceConnection property is set
        internal bool IsSetSourceConnection()
        {
            return this._sourceConnection != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the product.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> - The product is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> - Product creation has started; the product is not ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - An action failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Status Status
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