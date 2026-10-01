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
    /// Describes a successful rule update.
    /// </summary>
    public partial class RuleUpdateSuccess
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action for the rule.
        /// </para>
        /// </summary>
        public RuleAction Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 5, Max = 22)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property IsDefault. 
        /// <para>
        /// Indicates whether this is the default rule.
        /// </para>
        /// </summary>
        public bool? IsDefault { get; set; }

        /// <summary>
        /// Checks to see if the IsDefault property is set.
        /// </summary>
        internal bool IsSetIsDefault() => this.IsDefault.HasValue;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the listener.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The rule priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;
    }
}
