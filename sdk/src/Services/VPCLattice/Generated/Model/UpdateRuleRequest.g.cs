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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRule operation. Updates a specified rule
    /// for the listener. You can't modify a default listener rule. To modify a default listener
    /// rule, use <c>UpdateListener</c>.
    /// </summary>
    public partial class UpdateRuleRequest : AmazonVPCLatticeRequest
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Information about the action for the specified listener rule.
        /// </para>
        /// </summary>
        public RuleAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property ListenerIdentifier. 
        /// <para>
        /// The ID or ARN of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ListenerIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ListenerIdentifier property is set.
        /// </summary>
        internal bool IsSetListenerIdentifier() => this.ListenerIdentifier != null;

        /// <summary>
        /// Gets and sets the property Match. 
        /// <para>
        /// The rule match.
        /// </para>
        /// </summary>
        public RuleMatch Match { get; set; }

        /// <summary>
        /// Checks to see if the Match property is set.
        /// </summary>
        internal bool IsSetMatch() => this.Match != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The rule priority. A listener can't have multiple rules with the same priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property RuleIdentifier. 
        /// <para>
        /// The ID or ARN of the rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RuleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the RuleIdentifier property is set.
        /// </summary>
        internal bool IsSetRuleIdentifier() => this.RuleIdentifier != null;

        /// <summary>
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or ARN of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 17, Max = 2048)]
        public string ServiceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ServiceIdentifier property is set.
        /// </summary>
        internal bool IsSetServiceIdentifier() => this.ServiceIdentifier != null;
    }
}
