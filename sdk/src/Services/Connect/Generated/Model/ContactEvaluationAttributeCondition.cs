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
    /// An attribute condition for contact evaluation filtering.
    /// </summary>
    public partial class ContactEvaluationAttributeCondition
    {
        private ContactEvaluationAttributeKey _attributeKey;
        private ContactEvaluationAttributeValue _attributeValue;
        private ContactEvaluationAttributeComparisonType _comparisonType;

        /// <summary>
        /// Gets and sets the property AttributeKey. 
        /// <para>
        /// The key of the attribute.
        /// </para>
        /// </summary>
        public ContactEvaluationAttributeKey AttributeKey
        {
            get { return this._attributeKey; }
            set { this._attributeKey = value; }
        }

        // Check to see if AttributeKey property is set
        internal bool IsSetAttributeKey()
        {
            return this._attributeKey != null;
        }

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The value of the attribute.
        /// </para>
        /// </summary>
        public ContactEvaluationAttributeValue AttributeValue
        {
            get { return this._attributeValue; }
            set { this._attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this._attributeValue != null;
        }

        /// <summary>
        /// Gets and sets the property ComparisonType. 
        /// <para>
        /// The comparison type for the condition.
        /// </para>
        /// </summary>
        public ContactEvaluationAttributeComparisonType ComparisonType
        {
            get { return this._comparisonType; }
            set { this._comparisonType = value; }
        }

        // Check to see if ComparisonType property is set
        internal bool IsSetComparisonType()
        {
            return this._comparisonType != null;
        }

    }
}