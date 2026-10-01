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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The row filter expression.
    /// </summary>
    public partial class RowFilterExpression
    {
        /// <summary>
        /// Gets and sets the property EqualTo. 
        /// <para>
        /// The 'equal to' clause of the row filter expression.
        /// </para>
        /// </summary>
        public EqualToExpression EqualTo { get; set; }

        /// <summary>
        /// Checks to see if the EqualTo property is set.
        /// </summary>
        internal bool IsSetEqualTo() => this.EqualTo != null;

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// The 'greater than' clause of the row filter expression.
        /// </para>
        /// </summary>
        public GreaterThanExpression GreaterThan { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThan property is set.
        /// </summary>
        internal bool IsSetGreaterThan() => this.GreaterThan != null;

        /// <summary>
        /// Gets and sets the property GreaterThanOrEqualTo. 
        /// <para>
        /// The 'greater than or equal to' clause of the filter expression.
        /// </para>
        /// </summary>
        public GreaterThanOrEqualToExpression GreaterThanOrEqualTo { get; set; }

        /// <summary>
        /// Checks to see if the GreaterThanOrEqualTo property is set.
        /// </summary>
        internal bool IsSetGreaterThanOrEqualTo() => this.GreaterThanOrEqualTo != null;

        /// <summary>
        /// Gets and sets the property In. 
        /// <para>
        /// The 'in' clause of the row filter expression.
        /// </para>
        /// </summary>
        public InExpression In { get; set; }

        /// <summary>
        /// Checks to see if the In property is set.
        /// </summary>
        internal bool IsSetIn() => this.In != null;

        /// <summary>
        /// Gets and sets the property IsNotNull. 
        /// <para>
        /// The 'is not null' clause of the row filter expression.
        /// </para>
        /// </summary>
        public IsNotNullExpression IsNotNull { get; set; }

        /// <summary>
        /// Checks to see if the IsNotNull property is set.
        /// </summary>
        internal bool IsSetIsNotNull() => this.IsNotNull != null;

        /// <summary>
        /// Gets and sets the property IsNull. 
        /// <para>
        /// The 'is null' clause of the row filter expression.
        /// </para>
        /// </summary>
        public IsNullExpression IsNull { get; set; }

        /// <summary>
        /// Checks to see if the IsNull property is set.
        /// </summary>
        internal bool IsSetIsNull() => this.IsNull != null;

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// The 'less than' clause of the row filter expression.
        /// </para>
        /// </summary>
        public LessThanExpression LessThan { get; set; }

        /// <summary>
        /// Checks to see if the LessThan property is set.
        /// </summary>
        internal bool IsSetLessThan() => this.LessThan != null;

        /// <summary>
        /// Gets and sets the property LessThanOrEqualTo. 
        /// <para>
        /// The 'less than or equal to' clause of the row filter expression.
        /// </para>
        /// </summary>
        public LessThanOrEqualToExpression LessThanOrEqualTo { get; set; }

        /// <summary>
        /// Checks to see if the LessThanOrEqualTo property is set.
        /// </summary>
        internal bool IsSetLessThanOrEqualTo() => this.LessThanOrEqualTo != null;

        /// <summary>
        /// Gets and sets the property Like. 
        /// <para>
        /// The 'like' clause of the row filter expression.
        /// </para>
        /// </summary>
        public LikeExpression Like { get; set; }

        /// <summary>
        /// Checks to see if the Like property is set.
        /// </summary>
        internal bool IsSetLike() => this.Like != null;

        /// <summary>
        /// Gets and sets the property NotEqualTo. 
        /// <para>
        /// The 'no equal to' clause of the row filter expression.
        /// </para>
        /// </summary>
        public NotEqualToExpression NotEqualTo { get; set; }

        /// <summary>
        /// Checks to see if the NotEqualTo property is set.
        /// </summary>
        internal bool IsSetNotEqualTo() => this.NotEqualTo != null;

        /// <summary>
        /// Gets and sets the property NotIn. 
        /// <para>
        /// The 'not in' clause of the row filter expression.
        /// </para>
        /// </summary>
        public NotInExpression NotIn { get; set; }

        /// <summary>
        /// Checks to see if the NotIn property is set.
        /// </summary>
        internal bool IsSetNotIn() => this.NotIn != null;

        /// <summary>
        /// Gets and sets the property NotLike. 
        /// <para>
        /// The 'not like' clause of the row filter expression.
        /// </para>
        /// </summary>
        public NotLikeExpression NotLike { get; set; }

        /// <summary>
        /// Checks to see if the NotLike property is set.
        /// </summary>
        internal bool IsSetNotLike() => this.NotLike != null;
    }
}
