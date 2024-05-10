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
 * Do not modify this file. This file is generated from the marketplace-catalog-2018-09-17.normal.json service model.
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
namespace Amazon.MarketplaceCatalog.Model
{
    /// <summary>
    /// Allows filtering on the <c>ManufacturerLegalName</c> of a ResaleAuthorization.
    /// </summary>
    public partial class ResaleAuthorizationManufacturerLegalNameFilter
    {
        private List<string> _valueList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _wildCardValue;

        /// <summary>
        /// Gets and sets the property ValueList. 
        /// <para>
        /// Allows filtering on the <c>ManufacturerLegalName</c> of a ResaleAuthorization with
        /// list input.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> ValueList
        {
            get { return this._valueList; }
            set { this._valueList = value; }
        }

        // Check to see if ValueList property is set
        internal bool IsSetValueList()
        {
            return this._valueList != null && (this._valueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WildCardValue. 
        /// <para>
        /// Allows filtering on the <c>ManufacturerLegalName</c> of a ResaleAuthorization with
        /// wild card input.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string WildCardValue
        {
            get { return this._wildCardValue; }
            set { this._wildCardValue = value; }
        }

        // Check to see if WildCardValue property is set
        internal bool IsSetWildCardValue()
        {
            return this._wildCardValue != null;
        }

    }
}