/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a product code.</para>
    /// </summary>
    public class ProductCode
    {
        
        private string productCodeId;
        private ProductCodeValues productCodeType;


        /// <summary>
        /// The product code.
        ///  
        /// </summary>
        public string ProductCodeId
        {
            get { return this.productCodeId; }
            set { this.productCodeId = value; }
        }

        // Check to see if ProductCodeId property is set
        internal bool IsSetProductCodeId()
        {
            return this.productCodeId != null;
        }

        /// <summary>
        /// The type of product code.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>devpay, marketplace</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ProductCodeValues ProductCodeType
        {
            get { return this.productCodeType; }
            set { this.productCodeType = value; }
        }

        // Check to see if ProductCodeType property is set
        internal bool IsSetProductCodeType()
        {
            return this.productCodeType != null;
        }
    }
}
