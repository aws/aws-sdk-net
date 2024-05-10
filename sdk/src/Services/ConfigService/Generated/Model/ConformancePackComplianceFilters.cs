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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Filters the conformance pack by compliance types and Config rule names.
    /// </summary>
    public partial class ConformancePackComplianceFilters
    {
        private ConformancePackComplianceType _complianceType;
        private List<string> _configRuleNames = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// Filters the results by compliance.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are <c>COMPLIANT</c> and <c>NON_COMPLIANT</c>. <c>INSUFFICIENT_DATA</c>
        /// is not supported.
        /// </para>
        /// </summary>
        public ConformancePackComplianceType ComplianceType
        {
            get { return this._complianceType; }
            set { this._complianceType = value; }
        }

        // Check to see if ComplianceType property is set
        internal bool IsSetComplianceType()
        {
            return this._complianceType != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleNames. 
        /// <para>
        /// Filters the results by Config rule names.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> ConfigRuleNames
        {
            get { return this._configRuleNames; }
            set { this._configRuleNames = value; }
        }

        // Check to see if ConfigRuleNames property is set
        internal bool IsSetConfigRuleNames()
        {
            return this._configRuleNames != null && (this._configRuleNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}