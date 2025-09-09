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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
        private string _comparisonOperator;
        private MatchCriteria _matchCriteria;
        private string _name;
        private float? _proficiencyLevel;
        private Range _range;
        private string _value;

        /// <summary>
        /// Gets and sets the property ComparisonOperator. 
        /// <para>
        /// The operator of the condition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string ComparisonOperator
        {
            get { return this._comparisonOperator; }
            set { this._comparisonOperator = value; }
        }

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this._comparisonOperator != null;
        }

        /// <summary>
        /// Gets and sets the property MatchCriteria. 
        /// <para>
        /// An object to define <c>AgentsCriteria</c>.
        /// </para>
        /// </summary>
        public MatchCriteria MatchCriteria
        {
            get { return this._matchCriteria; }
            set { this._matchCriteria = value; }
        }

        // Check to see if MatchCriteria property is set
        internal bool IsSetMatchCriteria()
        {
            return this._matchCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of predefined attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProficiencyLevel. 
        /// <para>
        /// The proficiency level of the condition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public float? ProficiencyLevel
        {
            get { return this._proficiencyLevel; }
            set { this._proficiencyLevel = value; }
        }

        // Check to see if ProficiencyLevel property is set
        internal bool IsSetProficiencyLevel()
        {
            return this._proficiencyLevel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// An Object to define the minimum and maximum proficiency levels.
        /// </para>
        /// </summary>
        public Range Range
        {
            get { return this._range; }
            set { this._range = value; }
        }

        // Check to see if Range property is set
        internal bool IsSetRange()
        {
            return this._range != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of predefined attribute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}