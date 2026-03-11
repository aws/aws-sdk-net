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
    /// Matching rule statement.
    /// </summary>
    public partial class MatchingRuleStatement
    {
        private string _constraint;
        private string _keyToMatch;
        private List<string> _valueToMatch = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Constraint. 
        /// <para>
        /// Constraint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Constraint
        {
            get { return this._constraint; }
            set { this._constraint = value; }
        }

        // Check to see if Constraint property is set
        internal bool IsSetConstraint()
        {
            return this._constraint != null;
        }

        /// <summary>
        /// Gets and sets the property KeyToMatch. 
        /// <para>
        /// Key to match.
        /// </para>
        ///  
        /// <para>
        /// The following keys and are supported when the RuleStatement type is <c>Instance</c>:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Platform</c> - The name of the platform. Logical operators are <c>EQUALS</c> and
        /// <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EC2BillingProduct</c> - The billing product code. Logical operators are <c>EQUALS</c>
        /// and <c>NOT_EQUALS</c>. Possible values are: <c>windows-server-enterprise</c> | <c>windows-byol</c>
        /// | <c>rhel</c> | <c>rhel-byol</c> | <c>rhel-high-availability</c> | <c>ubuntu-pro</c>
        /// | <c>suse-linux</c> | <c>sql-server-standard</c> | <c>sql-server-enterprise</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MarketPlaceProductCode</c> - The Marketplace product code. Logical operators are
        /// <c>EQUALS</c> and <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AMIId</c> - The ID of the AMI. Logical operators are <c>EQUALS</c> and <c>NOT_EQUALS</c>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceType</c> - The instance type. Logical operators are <c>EQUALS</c> and
        /// <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>InstanceId</c> - The ID of the instance. Logical operators are <c>EQUALS</c> and
        /// <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HostId</c> - The ID of the host. Logical operators are <c>EQUALS</c> and <c>NOT_EQUALS</c>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccountId</c> - The ID of the account. Logical operators are <c>EQUALS</c> and
        /// <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following keys and are supported when the RuleStatement type is <c>License</c>:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LicenseArn</c> - The ARN of a Managed Entitlement License. Logical operators are
        /// <c>EQUALS</c> and <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ProductSKU</c> - The productSKU of the license. Logical operators are <c>EQUALS</c>
        /// and <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Issuer</c> - The issuer of the license. Logical operators are <c>EQUALS</c> and
        /// <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Beneficiary</c> - The beneficiary of the license. Logical operators are <c>EQUALS</c>
        /// and <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LicenseStatus</c> - The status of the license. Logical operators are <c>EQUALS</c>
        /// and <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>HomeRegion</c> - The home region of the license. Logical operators are <c>EQUALS</c>
        /// and <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following keys and are supported when the RuleStatement type is <c>License Configuration</c>:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>LicenseConfigurationArn</c> - The ARN of a self-managed license configuration.
        /// Logical operators are <c>EQUALS</c> and <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccountId</c> - The account of the license configuration. Logical operators are
        /// <c>EQUALS</c> and <c>NOT_EQUALS</c>. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KeyToMatch
        {
            get { return this._keyToMatch; }
            set { this._keyToMatch = value; }
        }

        // Check to see if KeyToMatch property is set
        internal bool IsSetKeyToMatch()
        {
            return this._keyToMatch != null;
        }

        /// <summary>
        /// Gets and sets the property ValueToMatch. 
        /// <para>
        /// Value to match.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ValueToMatch
        {
            get { return this._valueToMatch; }
            set { this._valueToMatch = value; }
        }

        // Check to see if ValueToMatch property is set
        internal bool IsSetValueToMatch()
        {
            return this._valueToMatch != null && (this._valueToMatch.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}