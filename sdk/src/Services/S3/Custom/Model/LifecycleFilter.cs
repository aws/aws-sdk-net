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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.S3.Model.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Base class for all the different predicates that can be used
    /// in a <see cref="LifecycleRule"/> filter.
    /// </summary>
    public abstract class LifecycleFilterPredicate
    {
        /// <summary>
        /// This method is called by the visitor when it wants to visit the predicate.
        /// </summary>
        /// <param name="visitor"></param>
        abstract internal void Accept(ILifecyclePredicateVisitor visitor);
    }

    /// <summary>
    /// Filter identifying one or more objects to which a <see cref="LifecycleRule"/> applies.
    /// </summary>
    public partial class LifecycleFilter
    {
        /// <summary>
        /// The predicate used by the filter.
        /// </summary>
        public LifecycleFilterPredicate LifecycleFilterPredicate { get; set; }

        // Check to see if Predicate property is set
        internal bool IsSetLifecycleFilterPredicate()
        {
            return LifecycleFilterPredicate != null;
        }
    }

    /// <summary>
    /// Base class for lifecycle operators.
    /// </summary>
    public abstract class LifecycleNAryOperator : LifecycleFilterPredicate
    {
        /// <summary>
        /// The list of <see cref="LifecycleFilterPredicate"/> objects
        /// that this operator operates on.
        /// </summary>
        public List<LifecycleFilterPredicate> Operands { get; set; }

        // Check to see if Operands property is set
        internal bool IsSetOperands()
        {
            return Operands != null;
        }
    }

    /// <summary>
    /// The logical and operator for filtering objects for a <see cref="LifecycleRule"/>
    /// </summary>
    public class LifecycleAndOperator : LifecycleNAryOperator
    {
        /// <summary>
        /// Accept a visit from an <see cref="ILifecyclePredicateVisitor"/>
        /// </summary>
        /// <remarks>
        /// This method is used internally by the SDK.
        /// </remarks>
        /// <param name="visitor"></param>
        internal override void Accept(ILifecyclePredicateVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// A predicate that filters objects for a <see cref="LifecycleRule"/>
    /// by matching a particular prefix.
    /// </summary>
    public class LifecyclePrefixPredicate : LifecycleFilterPredicate
    {
        /// <summary>
        /// The prefix to be matched by filtered objects.
        /// </summary>
        public string Prefix { get; set; }

        // Check to see if Prefix property is set
        internal bool IsSetPrefix()
        {
            return Prefix != null;
        }

        /// <summary>
        /// Accept a visit from an <see cref="ILifecyclePredicateVisitor"/>
        /// </summary>
        /// <remarks>
        /// This method is used internally by the SDK.
        /// </remarks>
        /// <param name="visitor"></param>
        internal override void Accept(ILifecyclePredicateVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// A predicate that filters objects for a <see cref="LifecycleRule"/>
    /// by matching a particular <see cref="Tag"/> key and value.
    /// </summary>
    public class LifecycleTagPredicate : LifecycleFilterPredicate
    {
        /// <summary>
        /// The Tag to be matched by filtered objects.
        /// </summary>
        public Tag Tag { get; set; }

        // Check to see if Tag property is set
        internal bool IsSetTag()
        {
            return Tag != null;
        }

        /// <summary>
        /// Accept a visit from an <see cref="ILifecyclePredicateVisitor"/>
        /// </summary>
        /// <remarks>
        /// This method is used internally by the SDK.
        /// </remarks>
        /// <param name="visitor"></param>
        internal override void Accept(ILifecyclePredicateVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// A predicate that filters objects for a <see cref="LifecycleRule"/>
    /// by comparing object size greater then specified value.
    /// </summary>
    public class LifecycleObjectSizeGreaterThanPredicate : LifecycleFilterPredicate
    {
        private long? _objectSizeGreaterThan;

        /// <summary>
        /// Gets and sets the property ObjectSizeGreaterThan.
        /// </summary>
        public long? ObjectSizeGreaterThan
        {
            get { return this._objectSizeGreaterThan; }
            set { this._objectSizeGreaterThan = value; }
        }

        // Check to see if ObjectSizeGreaterThan property is set
        internal bool IsSetObjectSizeGreaterThan()
        {
            return this._objectSizeGreaterThan.HasValue; 
        }

        /// <summary>
        /// Accept a visit from an <see cref="ILifecyclePredicateVisitor"/>
        /// </summary>
        /// <remarks>
        /// This method is used internally by the SDK.
        /// </remarks>
        /// <param name="visitor"></param>
        internal override void Accept(ILifecyclePredicateVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    /// <summary>
    /// A predicate that filters objects for a <see cref="LifecycleRule"/>
    /// by comparing object size less then specified value.
    /// </summary>
    public class LifecycleObjectSizeLessThanPredicate : LifecycleFilterPredicate
    {
        private long? _objectSizeLessThan;

        /// <summary>
        /// Gets and sets the property ObjectSizeLessThan.
        /// </summary>
        public long? ObjectSizeLessThan
        {
            get { return this._objectSizeLessThan; }
            set { this._objectSizeLessThan = value; }
        }

        // Check to see if ObjectSizeLessThan property is set
        internal bool IsSetObjectSizeLessThan()
        {
            return this._objectSizeLessThan.HasValue; 
        }

        /// <summary>
        /// Accept a visit from an <see cref="ILifecyclePredicateVisitor"/>
        /// </summary>
        /// <remarks>
        /// This method is used internally by the SDK.
        /// </remarks>
        /// <param name="visitor"></param>
        internal override void Accept(ILifecyclePredicateVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
