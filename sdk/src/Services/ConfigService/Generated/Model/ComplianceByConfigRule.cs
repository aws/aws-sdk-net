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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Indicates whether an AWS Config rule is compliant. A rule is compliant if all of the
    /// resources that the rule evaluated comply with it. A rule is noncompliant if any of
    /// these resources do not comply.
    /// </summary>
    public partial class ComplianceByConfigRule
    {
        private Compliance _compliance;
        private string _configRuleName;

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// Indicates whether the AWS Config rule is compliant.
        /// </para>
        /// </summary>
        public Compliance Compliance
        {
            get { return this._compliance; }
            set { this._compliance = value; }
        }

        // Check to see if Compliance property is set
        internal bool IsSetCompliance()
        {
            return this._compliance != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the AWS Config rule.
        /// </para>
        /// </summary>
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

    }
}