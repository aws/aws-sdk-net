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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes product information filters.
    /// </summary>
    public partial class ProductInformationFilter
    {
        /// <summary>
        /// Gets and sets the property ProductInformationFilterComparator. 
        /// <para>
        /// Logical operator.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductInformationFilterComparator { get; set; }

        /// <summary>
        /// Checks to see if the ProductInformationFilterComparator property is set.
        /// </summary>
        internal bool IsSetProductInformationFilterComparator() => this.ProductInformationFilterComparator != null;

        /// <summary>
        /// Gets and sets the property ProductInformationFilterName. 
        /// <para>
        /// Filter name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ProductInformationFilterName { get; set; }

        /// <summary>
        /// Checks to see if the ProductInformationFilterName property is set.
        /// </summary>
        internal bool IsSetProductInformationFilterName() => this.ProductInformationFilterName != null;

        /// <summary>
        /// Gets and sets the property ProductInformationFilterValue. 
        /// <para>
        /// Filter value.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ProductInformationFilterValue { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ProductInformationFilterValue property is set.
        /// </summary>
        internal bool IsSetProductInformationFilterValue() => this.ProductInformationFilterValue != null && (this.ProductInformationFilterValue.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
