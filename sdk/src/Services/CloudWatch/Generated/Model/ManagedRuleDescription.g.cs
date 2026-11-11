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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Contains information about managed Contributor Insights rules, as returned by <c>ListManagedInsightRules</c>.
    /// </summary>
    public partial class ManagedRuleDescription
    {
        /// <summary>
        /// Gets and sets the property ResourceARN. 
        /// <para>
        ///  If a managed rule is enabled, this is the ARN for the related Amazon Web Services
        /// resource. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property RuleState. 
        /// <para>
        ///  Describes the state of a managed rule. If present, it contains information about
        /// the Contributor Insights rule that contains information about the related Amazon Web
        /// Services resource. 
        /// </para>
        /// </summary>
        public ManagedRuleState RuleState { get; set; }

        /// <summary>
        /// Checks to see if the RuleState property is set.
        /// </summary>
        internal bool IsSetRuleState() => this.RuleState != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        ///  The template name for the managed rule. Used to enable managed rules using <c>PutManagedInsightRules</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
