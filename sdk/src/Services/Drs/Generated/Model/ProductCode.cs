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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Properties of a product code associated with a volume.
    /// </summary>
    public partial class ProductCode
    {
        private string _productCodeId;
        private ProductCodeMode _productCodeMode;

        /// <summary>
        /// Gets and sets the property ProductCodeId. 
        /// <para>
        /// Id of a product code associated with a volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min=25, Max=25)]
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
        /// Gets and sets the property ProductCodeMode. 
        /// <para>
        /// Mode of a product code associated with a volume.
        /// </para>
        /// </summary>
        public ProductCodeMode ProductCodeMode
        {
            get { return this._productCodeMode; }
            set { this._productCodeMode = value; }
        }

        // Check to see if ProductCodeMode property is set
        internal bool IsSetProductCodeMode()
        {
            return this._productCodeMode != null;
        }

    }
}