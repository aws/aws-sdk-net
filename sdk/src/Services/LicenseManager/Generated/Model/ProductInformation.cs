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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes product information for a license configuration.
    /// </summary>
    public partial class ProductInformation
    {
        private List<ProductInformationFilter> _productInformationFilterList = new List<ProductInformationFilter>();
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ProductInformationFilterList. 
        /// <para>
        /// Product information filters. The following filters and logical operators are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Application Name</code> - The name of the application. Logical operator is
        /// <code>EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Application Publisher</code> - The publisher of the application. Logical operator
        /// is <code>EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Application Version</code> - The version of the application. Logical operator
        /// is <code>EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Platform Name</code> - The name of the platform. Logical operator is <code>EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Platform Type</code> - The platform type. Logical operator is <code>EQUALS</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>License Included</code> - The type of license included. Logical operators are
        /// <code>EQUALS</code> and <code>NOT_EQUALS</code>. Possible values are <code>sql-server-enterprise</code>
        /// | <code>sql-server-standard</code> | <code>sql-server-web</code> | <code>windows-server-datacenter</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ProductInformationFilter> ProductInformationFilterList
        {
            get { return this._productInformationFilterList; }
            set { this._productInformationFilterList = value; }
        }

        // Check to see if ProductInformationFilterList property is set
        internal bool IsSetProductInformationFilterList()
        {
            return this._productInformationFilterList != null && this._productInformationFilterList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Resource type. The value is <code>SSM_MANAGED</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}