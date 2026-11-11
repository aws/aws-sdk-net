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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Indicates whether an Config rule is compliant. A rule is compliant if all of the resources
    /// that the rule evaluated comply with it. A rule is noncompliant if any of these resources
    /// do not comply.
    /// </summary>
    public partial class ComplianceByConfigRule
    {
        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// Indicates whether the Config rule is compliant.
        /// </para>
        /// </summary>
        public Compliance Compliance { get; set; }

        /// <summary>
        /// Checks to see if the Compliance property is set.
        /// </summary>
        internal bool IsSetCompliance() => this.Compliance != null;

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name of the Config rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ConfigRuleName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigRuleName property is set.
        /// </summary>
        internal bool IsSetConfigRuleName() => this.ConfigRuleName != null;
    }
}
