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
    /// Specifies a <code>Predicate</code> (such as an <code>IPSet</code>) and indicates whether
    /// you want to add it to a <code>Rule</code> or delete it from a <code>Rule</code>.
    /// </summary>
    public partial class RuleUpdate
    {
        private ChangeAction _action;
        private Predicate _predicate;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specify <code>INSERT</code> to add a <code>Predicate</code> to a <code>Rule</code>.
        /// Use <code>DELETE</code> to remove a <code>Predicate</code> from a <code>Rule</code>.
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
        /// Gets and sets the property Predicate. 
        /// <para>
        /// The ID of the <code>Predicate</code> (such as an <code>IPSet</code>) that you want
        /// to add to a <code>Rule</code>.
        /// </para>
        /// </summary>
        public Predicate Predicate
        {
            get { return this._predicate; }
            set { this._predicate = value; }
        }

        // Check to see if Predicate property is set
        internal bool IsSetPredicate()
        {
            return this._predicate != null;
        }

    }
}