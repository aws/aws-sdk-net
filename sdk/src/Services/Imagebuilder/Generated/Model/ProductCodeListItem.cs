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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Information about a single product code.
    /// </summary>
    public partial class ProductCodeListItem
    {
        private string _productCodeId;
        private ProductCodeType _productCodeType;

        /// <summary>
        /// Gets and sets the property ProductCodeId. 
        /// <para>
        /// For Amazon Web Services Marketplace components, this contains the product code ID
        /// that can be stamped onto an EC2 AMI to ensure that components are billed correctly.
        /// If this property is empty, it might mean that the component is not published.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProductCodeId
        {
            get { return this._productCodeId; }
            set { this._productCodeId = value; }
        }

        // Check to see if ProductCodeId property is set
        internal bool IsSetProductCodeId()
        {
            return this._productCodeId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCodeType. 
        /// <para>
        /// The owner of the product code that's billed. If this property is empty, it might mean
        /// that the component is not published.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProductCodeType ProductCodeType
        {
            get { return this._productCodeType; }
            set { this._productCodeType = value; }
        }

        // Check to see if ProductCodeType property is set
        internal bool IsSetProductCodeType()
        {
            return this._productCodeType != null;
        }

    }
}