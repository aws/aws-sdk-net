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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Filters a conformance pack by Config rule names, compliance types, Amazon Web Services
    /// resource types, and resource IDs.
    /// </summary>
    public partial class ConformancePackEvaluationFilters
    {
        private ConformancePackComplianceType _complianceType;
        private List<string> _configRuleNames = new List<string>();
        private List<string> _resourceIds = new List<string>();
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ComplianceType. 
        /// <para>
        /// Filters the results by compliance.
        /// </para>
        ///  
        /// <para>
        /// The allowed values are <code>COMPLIANT</code> and <code>NON_COMPLIANT</code>. <code>INSUFFICIENT_DATA</code>
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
            return this._configRuleNames != null && this._configRuleNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// Filters the results by resource IDs.
        /// </para>
        ///  <note> 
        /// <para>
        /// This is valid only when you provide resource type. If there is no resource type, you
        /// will see an error.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<string> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && this._resourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Filters the results by the resource type (for example, <code>"AWS::EC2::Instance"</code>).
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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