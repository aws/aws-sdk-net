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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
        private EqualToExpression _equalTo;
        private GreaterThanExpression _greaterThan;
        private GreaterThanOrEqualToExpression _greaterThanOrEqualTo;
        private InExpression _in;
        private IsNotNullExpression _isNotNull;
        private IsNullExpression _isNull;
        private LessThanExpression _lessThan;
        private LessThanOrEqualToExpression _lessThanOrEqualTo;
        private LikeExpression _like;
        private NotEqualToExpression _notEqualTo;
        private NotInExpression _notIn;
        private NotLikeExpression _notLike;

        /// <summary>
        /// Gets and sets the property EqualTo. 
        /// <para>
        /// The 'equal to' clause of the row filter expression.
        /// </para>
        /// </summary>
        public EqualToExpression EqualTo
        {
            get { return this._equalTo; }
            set { this._equalTo = value; }
        }

        // Check to see if EqualTo property is set
        internal bool IsSetEqualTo()
        {
            return this._equalTo != null;
        }

        /// <summary>
        /// Gets and sets the property GreaterThan. 
        /// <para>
        /// The 'greater than' clause of the row filter expression.
        /// </para>
        /// </summary>
        public GreaterThanExpression GreaterThan
        {
            get { return this._greaterThan; }
            set { this._greaterThan = value; }
        }

        // Check to see if GreaterThan property is set
        internal bool IsSetGreaterThan()
        {
            return this._greaterThan != null;
        }

        /// <summary>
        /// Gets and sets the property GreaterThanOrEqualTo. 
        /// <para>
        /// The 'greater than or equal to' clause of the filter expression.
        /// </para>
        /// </summary>
        public GreaterThanOrEqualToExpression GreaterThanOrEqualTo
        {
            get { return this._greaterThanOrEqualTo; }
            set { this._greaterThanOrEqualTo = value; }
        }

        // Check to see if GreaterThanOrEqualTo property is set
        internal bool IsSetGreaterThanOrEqualTo()
        {
            return this._greaterThanOrEqualTo != null;
        }

        /// <summary>
        /// Gets and sets the property In. 
        /// <para>
        /// The 'in' clause of the row filter expression.
        /// </para>
        /// </summary>
        public InExpression In
        {
            get { return this._in; }
            set { this._in = value; }
        }

        // Check to see if In property is set
        internal bool IsSetIn()
        {
            return this._in != null;
        }

        /// <summary>
        /// Gets and sets the property IsNotNull. 
        /// <para>
        /// The 'is not null' clause of the row filter expression.
        /// </para>
        /// </summary>
        public IsNotNullExpression IsNotNull
        {
            get { return this._isNotNull; }
            set { this._isNotNull = value; }
        }

        // Check to see if IsNotNull property is set
        internal bool IsSetIsNotNull()
        {
            return this._isNotNull != null;
        }

        /// <summary>
        /// Gets and sets the property IsNull. 
        /// <para>
        /// The 'is null' clause of the row filter expression.
        /// </para>
        /// </summary>
        public IsNullExpression IsNull
        {
            get { return this._isNull; }
            set { this._isNull = value; }
        }

        // Check to see if IsNull property is set
        internal bool IsSetIsNull()
        {
            return this._isNull != null;
        }

        /// <summary>
        /// Gets and sets the property LessThan. 
        /// <para>
        /// The 'less than' clause of the row filter expression.
        /// </para>
        /// </summary>
        public LessThanExpression LessThan
        {
            get { return this._lessThan; }
            set { this._lessThan = value; }
        }

        // Check to see if LessThan property is set
        internal bool IsSetLessThan()
        {
            return this._lessThan != null;
        }

        /// <summary>
        /// Gets and sets the property LessThanOrEqualTo. 
        /// <para>
        /// The 'less than or equal to' clause of the row filter expression.
        /// </para>
        /// </summary>
        public LessThanOrEqualToExpression LessThanOrEqualTo
        {
            get { return this._lessThanOrEqualTo; }
            set { this._lessThanOrEqualTo = value; }
        }

        // Check to see if LessThanOrEqualTo property is set
        internal bool IsSetLessThanOrEqualTo()
        {
            return this._lessThanOrEqualTo != null;
        }

        /// <summary>
        /// Gets and sets the property Like. 
        /// <para>
        /// The 'like' clause of the row filter expression.
        /// </para>
        /// </summary>
        public LikeExpression Like
        {
            get { return this._like; }
            set { this._like = value; }
        }

        // Check to see if Like property is set
        internal bool IsSetLike()
        {
            return this._like != null;
        }

        /// <summary>
        /// Gets and sets the property NotEqualTo. 
        /// <para>
        /// The 'no equal to' clause of the row filter expression.
        /// </para>
        /// </summary>
        public NotEqualToExpression NotEqualTo
        {
            get { return this._notEqualTo; }
            set { this._notEqualTo = value; }
        }

        // Check to see if NotEqualTo property is set
        internal bool IsSetNotEqualTo()
        {
            return this._notEqualTo != null;
        }

        /// <summary>
        /// Gets and sets the property NotIn. 
        /// <para>
        /// The 'not in' clause of the row filter expression.
        /// </para>
        /// </summary>
        public NotInExpression NotIn
        {
            get { return this._notIn; }
            set { this._notIn = value; }
        }

        // Check to see if NotIn property is set
        internal bool IsSetNotIn()
        {
            return this._notIn != null;
        }

        /// <summary>
        /// Gets and sets the property NotLike. 
        /// <para>
        /// The 'not like' clause of the row filter expression.
        /// </para>
        /// </summary>
        public NotLikeExpression NotLike
        {
            get { return this._notLike; }
            set { this._notLike = value; }
        }

        // Check to see if NotLike property is set
        internal bool IsSetNotLike()
        {
            return this._notLike != null;
        }

    }
}