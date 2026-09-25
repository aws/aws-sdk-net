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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Stores information for generating Amplify DataStore queries. Use a <c>Predicate</c>
    /// to retrieve a subset of the data in a collection.
    /// </summary>
    public partial class Predicate
    {
        /// <summary>
        /// Gets and sets the property And. 
        /// <para>
        /// A list of predicates to combine logically.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Predicate> And { get; set; } = AWSConfigs.InitializeCollections ? new List<Predicate>() : null;

        /// <summary>
        /// Checks to see if the And property is set.
        /// </summary>
        internal bool IsSetAnd() => this.And != null && (this.And.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Field. 
        /// <para>
        /// The field to query.
        /// </para>
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Checks to see if the Field property is set.
        /// </summary>
        internal bool IsSetField() => this.Field != null;

        /// <summary>
        /// Gets and sets the property Operand. 
        /// <para>
        /// The value to use when performing the evaluation.
        /// </para>
        /// </summary>
        public string Operand { get; set; }

        /// <summary>
        /// Checks to see if the Operand property is set.
        /// </summary>
        internal bool IsSetOperand() => this.Operand != null;

        /// <summary>
        /// Gets and sets the property OperandType. 
        /// <para>
        /// The type of value to use when performing the evaluation.
        /// </para>
        /// </summary>
        public string OperandType { get; set; }

        /// <summary>
        /// Checks to see if the OperandType property is set.
        /// </summary>
        internal bool IsSetOperandType() => this.OperandType != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The operator to use to perform the evaluation.
        /// </para>
        /// </summary>
        public string Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Or. 
        /// <para>
        /// A list of predicates to combine logically.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Predicate> Or { get; set; } = AWSConfigs.InitializeCollections ? new List<Predicate>() : null;

        /// <summary>
        /// Checks to see if the Or property is set.
        /// </summary>
        internal bool IsSetOr() => this.Or != null && (this.Or.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
