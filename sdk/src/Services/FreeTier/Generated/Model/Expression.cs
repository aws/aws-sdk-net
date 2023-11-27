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
 * Do not modify this file. This file is generated from the freetier-2023-09-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FreeTier.Model
{
    /// <summary>
    /// Use <code>Expression</code> to filter in the <code>GetFreeTierUsage</code> API operation.
    /// 
    ///  
    /// <para>
    /// You can use the following patterns:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Simple dimension values (<code>Dimensions</code> root operator)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Complex expressions with logical operators (<code>AND</code>, <code>NOT</code>, and
    /// <code>OR</code> root operators).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For <i>simple dimension values</i>, you can set the dimension name, values, and match
    /// type for the filters that you plan to use.
    /// </para>
    ///  
    /// <para>
    ///  <b>Example for simple dimension values</b> 
    /// </para>
    ///  
    /// <para>
    /// You can filter to match exactly for <code>REGION==us-east-1 OR REGION==us-west-1</code>.
    /// </para>
    ///  
    /// <para>
    /// The corresponding <code>Expression</code> appears like the following: <code>{ "Dimensions":
    /// { "Key": "REGION", "Values": [ "us-east-1", "us-west-1" ], "MatchOptions": ["EQUALS"]
    /// } }</code> 
    /// </para>
    ///  
    /// <para>
    /// As shown in the previous example, lists of dimension values are combined with <code>OR</code>
    /// when you apply the filter.
    /// </para>
    ///  
    /// <para>
    /// For <i>complex expressions with logical operators</i>, you can have nested expressions
    /// to use the logical operators and specify advanced filtering.
    /// </para>
    ///  
    /// <para>
    ///  <b>Example for complex expressions with logical operators</b> 
    /// </para>
    ///  
    /// <para>
    /// You can filter by <code>((REGION == us-east-1 OR REGION == us-west-1) OR (SERVICE
    /// CONTAINS AWSLambda)) AND (USAGE_TYPE !CONTAINS DataTransfer)</code>.
    /// </para>
    ///  
    /// <para>
    /// The corresponding <code>Expression</code> appears like the following: <code>{ "And":
    /// [ {"Or": [ {"Dimensions": { "Key": "REGION", "Values": [ "us-east-1", "us-west-1"
    /// ], "MatchOptions": ["EQUALS"] }}, {"Dimensions": { "Key": "SERVICE", "Values": ["AWSLambda"],
    /// "MatchOptions": ["CONTAINS"] } } ]}, {"Not": {"Dimensions": { "Key": "USAGE_TYPE",
    /// "Values": ["DataTransfer"], "MatchOptions": ["CONTAINS"] }}} ] }</code> 
    /// </para>
    ///  
    /// <para>
    /// In the following <b>Contents</b>, you must specify exactly one of the following root
    /// operators.
    /// </para>
    /// </summary>
    public partial class Expression
    {
        private List<Expression> _and = new List<Expression>();
        private DimensionValues _dimensions;
        private Expression _not;
        private List<Expression> _or = new List<Expression>();

        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// Return results that match all <code>Expressions</code> that you specified in the array.
        /// </para>
        /// </summary>
        public List<Expression> And
        {
            get { return this._and; }
            set { this._and = value; }
        }

        // Check to see if And property is set
        internal bool IsSetAnd()
        {
            return this._and != null && this._and.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The specific dimension, values, and match type to filter objects with.
        /// </para>
        /// </summary>
        public DimensionValues Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property Not. 
        /// <para>
        /// Return results that don’t match the <code>Expression</code> that you specified.
        /// </para>
        /// </summary>
        public Expression Not
        {
            get { return this._not; }
            set { this._not = value; }
        }

        // Check to see if Not property is set
        internal bool IsSetNot()
        {
            return this._not != null;
        }

        /// <summary>
        /// Gets and sets the property Or. 
        /// <para>
        /// Return results that match any of the <code>Expressions</code> that you specified.
        /// in the array.
        /// </para>
        /// </summary>
        public List<Expression> Or
        {
            get { return this._or; }
            set { this._or = value; }
        }

        // Check to see if Or property is set
        internal bool IsSetOr()
        {
            return this._or != null && this._or.Count > 0; 
        }

    }
}