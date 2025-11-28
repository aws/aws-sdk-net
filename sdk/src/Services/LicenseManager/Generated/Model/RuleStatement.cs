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
    /// Rule statement.
    /// </summary>
    public partial class RuleStatement
    {
        private InstanceRuleStatement _instanceRuleStatement;
        private LicenseConfigurationRuleStatement _licenseConfigurationRuleStatement;
        private LicenseRuleStatement _licenseRuleStatement;

        /// <summary>
        /// Gets and sets the property InstanceRuleStatement. 
        /// <para>
        /// Instance rule statement.
        /// </para>
        /// </summary>
        public InstanceRuleStatement InstanceRuleStatement
        {
            get { return this._instanceRuleStatement; }
            set { this._instanceRuleStatement = value; }
        }

        // Check to see if InstanceRuleStatement property is set
        internal bool IsSetInstanceRuleStatement()
        {
            return this._instanceRuleStatement != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConfigurationRuleStatement. 
        /// <para>
        /// License configuration rule statement.
        /// </para>
        /// </summary>
        public LicenseConfigurationRuleStatement LicenseConfigurationRuleStatement
        {
            get { return this._licenseConfigurationRuleStatement; }
            set { this._licenseConfigurationRuleStatement = value; }
        }

        // Check to see if LicenseConfigurationRuleStatement property is set
        internal bool IsSetLicenseConfigurationRuleStatement()
        {
            return this._licenseConfigurationRuleStatement != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseRuleStatement. 
        /// <para>
        /// License rule statement.
        /// </para>
        /// </summary>
        public LicenseRuleStatement LicenseRuleStatement
        {
            get { return this._licenseRuleStatement; }
            set { this._licenseRuleStatement = value; }
        }

        // Check to see if LicenseRuleStatement property is set
        internal bool IsSetLicenseRuleStatement()
        {
            return this._licenseRuleStatement != null;
        }

    }
}