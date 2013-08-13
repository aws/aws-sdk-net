/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.DynamoDB.Model
{
    /// <summary>Condition
    /// </summary>
    public class Condition  
    {
        
        private List<AttributeValue> attributeValueList = new List<AttributeValue>();
        private string comparisonOperator;

        /// <summary>
        /// A list of attribute values to be used with a comparison operator for a scan or query operation. For comparisons that require more than one
        /// value, such as a <c>BETWEEN</c> comparison, the AttributeValueList contains two attribute values and the comparison operator.
        ///  
        /// </summary>
        public List<AttributeValue> AttributeValueList
        {
            get { return this.attributeValueList; }
            set { this.attributeValueList = value; }
        }
        /// <summary>
        /// Adds elements to the AttributeValueList collection
        /// </summary>
        /// <param name="attributeValueList">The values to add to the AttributeValueList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Condition WithAttributeValueList(params AttributeValue[] attributeValueList)
        {
            foreach (AttributeValue element in attributeValueList)
            {
                this.attributeValueList.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the AttributeValueList collection
        /// </summary>
        /// <param name="attributeValueList">The values to add to the AttributeValueList collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Condition WithAttributeValueList(IEnumerable<AttributeValue> attributeValueList)
        {
            foreach (AttributeValue element in attributeValueList)
            {
                this.attributeValueList.Add(element);
            }

            return this;
        }

        // Check to see if AttributeValueList property is set
        internal bool IsSetAttributeValueList()
        {
            return this.attributeValueList.Count > 0;       
        }

        /// <summary>
        /// A comparison operator is an enumeration of several operations: <ul> <li><c>EQ</c> for <em>equal</em>.</li> <li><c>NE</c> for <em>not
        /// equal</em>.</li> <li><c>IN</c> checks for exact matches.</li> <li><c>LE</c> for <em>less than or equal to</em>.</li> <li><c>LT</c> for
        /// <em>less than</em>.</li> <li><c>GE</c> for <em>greater than or equal to</em>.</li> <li><c>GT</c> for <em>greater than</em>.</li>
        /// <li><c>BETWEEN</c> for <em>between</em>.</li> <li><c>NOT_NULL</c> for <em>exists</em>.</li> <li><c>NULL</c> for <em>not exists</em>.</li>
        /// <li><c>CONTAINS</c> for substring or value in a set.</li> <li><c>NOT_CONTAINS</c> for absence of a substring or absence of a value in a
        /// set.</li> <li><c>BEGINS_WITH</c> for a substring prefix.</li> </ul> Scan operations support all available comparison operators. Query
        /// operations support a subset of the available comparison operators: EQ, LE, LT, GE, GT, BETWEEN, and BEGINS_WITH.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>EQ, NE, IN, LE, LT, GE, GT, BETWEEN, NOT_NULL, NULL, CONTAINS, NOT_CONTAINS, BEGINS_WITH</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ComparisonOperator
        {
            get { return this.comparisonOperator; }
            set { this.comparisonOperator = value; }
        }

        /// <summary>
        /// Sets the ComparisonOperator property
        /// </summary>
        /// <param name="comparisonOperator">The value to set for the ComparisonOperator property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Condition WithComparisonOperator(string comparisonOperator)
        {
            this.comparisonOperator = comparisonOperator;
            return this;
        }
            

        // Check to see if ComparisonOperator property is set
        internal bool IsSetComparisonOperator()
        {
            return this.comparisonOperator != null;       
        }
    }
}
