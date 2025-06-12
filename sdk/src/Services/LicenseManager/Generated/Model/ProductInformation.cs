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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Describes product information for a license configuration.
    /// </summary>
    public partial class ProductInformation
    {
        private List<ProductInformationFilter> _productInformationFilterList = AWSConfigs.InitializeCollections ? new List<ProductInformationFilter>() : null;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ProductInformationFilterList. 
        /// <para>
        /// A Product information filter consists of a <c>ProductInformationFilterComparator</c>
        /// which is a logical operator, a <c>ProductInformationFilterName</c> which specifies
        /// the type of filter being declared, and a <c>ProductInformationFilterValue</c> that
        /// specifies the value to filter on. 
        /// </para>
        ///  
        /// <para>
        /// Accepted values for <c>ProductInformationFilterName</c> are listed here along with
        /// descriptions and valid options for <c>ProductInformationFilterComparator</c>. 
        /// </para>
        ///  
        /// <para>
        /// The following filters and are supported when the resource type is <c>SSM_MANAGED</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Application Name</c> - The name of the application. Logical operator is <c>EQUALS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Application Publisher</c> - The publisher of the application. Logical operator
        /// is <c>EQUALS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Application Version</c> - The version of the application. Logical operator is
        /// <c>EQUALS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Platform Name</c> - The name of the platform. Logical operator is <c>EQUALS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Platform Type</c> - The platform type. Logical operator is <c>EQUALS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Tag:key</c> - The key of a tag attached to an Amazon Web Services resource you
        /// wish to exclude from automated discovery. Logical operator is <c>NOT_EQUALS</c>. The
        /// key for your tag must be appended to <c>Tag:</c> following the example: <c>Tag:name-of-your-key</c>.
        /// <c>ProductInformationFilterValue</c> is optional if you are not using values for the
        /// key. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccountId</c> - The 12-digit ID of an Amazon Web Services account you wish to
        /// exclude from automated discovery. Logical operator is <c>NOT_EQUALS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>License Included</c> - The type of license included. Logical operators are <c>EQUALS</c>
        /// and <c>NOT_EQUALS</c>. Possible values are: <c>sql-server-enterprise</c> | <c>sql-server-standard</c>
        /// | <c>sql-server-web</c> | <c>windows-server-datacenter</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following filters and logical operators are supported when the resource type is
        /// <c>RDS</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Engine Edition</c> - The edition of the database engine. Logical operator is <c>EQUALS</c>.
        /// Possible values are: <c>oracle-ee</c> | <c>oracle-se</c> | <c>oracle-se1</c> | <c>oracle-se2</c>
        /// | <c>db2-se</c> | <c>db2-ae</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>License Pack</c> - The license pack. Logical operator is <c>EQUALS</c>. Possible
        /// values are: <c>data guard</c> | <c>diagnostic pack sqlt</c> | <c>tuning pack sqlt</c>
        /// | <c>ols</c> | <c>olap</c>.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._productInformationFilterList != null && (this._productInformationFilterList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Resource type. The possible values are <c>SSM_MANAGED</c> | <c>RDS</c>.
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