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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Specifies how does the rule-based matching process should match profiles. You can
    /// choose from the following attributes to build the matching Rule:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// AccountNumber
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Address.Address
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Address.City
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Address.Country
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Address.County
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Address.PostalCode
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Address.State
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Address.Province
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// BirthDate
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// BusinessName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// EmailAddress
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// FirstName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Gender
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// LastName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// MiddleName
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// PhoneNumber
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any customized profile attributes that start with the <c>Attributes</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class MatchingRule
    {
        private List<string> _rule = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// A single rule level of the <c>MatchRules</c>. Configures how the rule-based matching
        /// process should match profiles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=15)]
        public List<string> Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null && (this._rule.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}