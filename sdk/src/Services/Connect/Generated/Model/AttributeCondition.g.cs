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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// An object to specify the predefined attribute condition.
    /// </summary>
    public partial class AttributeCondition
    {
        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The operator of the condition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// Checks to see if the ComparisonOperator property is set.
        /// </summary>
        internal bool IsSetComparisonOperator() => this.ComparisonOperator != null;

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// An object to define <c>AgentsCriteria</c>.
        /// </para>
        /// </summary>
        public MatchCriteria MatchCriteria { get; set; }

        /// <summary>
        /// Checks to see if the MatchCriteria property is set.
        /// </summary>
        internal bool IsSetMatchCriteria() => this.MatchCriteria != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of predefined attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProficiencyLevel. 
        /// <para>
        /// The proficiency level of the condition.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public float? ProficiencyLevel { get; set; }

        /// <summary>
        /// Checks to see if the ProficiencyLevel property is set.
        /// </summary>
        internal bool IsSetProficiencyLevel() => this.ProficiencyLevel.HasValue;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// An Object to define the minimum and maximum proficiency levels.
        /// </para>
        /// </summary>
        public Range Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of predefined attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
