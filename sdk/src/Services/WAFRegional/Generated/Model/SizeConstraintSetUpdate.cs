/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the waf-regional-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFRegional.Model
{
    /// <summary>
    /// Specifies the part of a web request that you want to inspect the size of and indicates
    /// whether you want to add the specification to a <a>SizeConstraintSet</a> or delete
    /// it from a <code>SizeConstraintSet</code>.
    /// </summary>
    public partial class SizeConstraintSetUpdate
    {
        private ChangeAction _action;
        private SizeConstraint _sizeConstraint;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specify <code>INSERT</code> to add a <a>SizeConstraintSetUpdate</a> to a <a>SizeConstraintSet</a>.
        /// Use <code>DELETE</code> to remove a <code>SizeConstraintSetUpdate</code> from a <code>SizeConstraintSet</code>.
        /// </para>
        /// </summary>
        public ChangeAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property SizeConstraint. 
        /// <para>
        /// Specifies a constraint on the size of a part of the web request. AWS WAF uses the
        /// <code>Size</code>, <code>ComparisonOperator</code>, and <code>FieldToMatch</code>
        /// to build an expression in the form of "<code>Size</code> <code>ComparisonOperator</code>
        /// size in bytes of <code>FieldToMatch</code>". If that expression is true, the <code>SizeConstraint</code>
        /// is considered to match.
        /// </para>
        /// </summary>
        public SizeConstraint SizeConstraint
        {
            get { return this._sizeConstraint; }
            set { this._sizeConstraint = value; }
        }

        // Check to see if SizeConstraint property is set
        internal bool IsSetSizeConstraint()
        {
            return this._sizeConstraint != null;
        }

    }
}