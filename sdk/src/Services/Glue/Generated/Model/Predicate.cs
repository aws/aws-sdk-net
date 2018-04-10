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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Defines the predicate of the trigger, which determines when it fires.
    /// </summary>
    public partial class Predicate
    {
        private List<Condition> _conditions = new List<Condition>();
        private Logical _logical;

        /// <summary>
        /// Gets and sets the property Conditions. 
        /// <para>
        /// A list of the conditions that determine when the trigger will fire.
        /// </para>
        /// </summary>
        public List<Condition> Conditions
        {
            get { return this._conditions; }
            set { this._conditions = value; }
        }

        // Check to see if Conditions property is set
        internal bool IsSetConditions()
        {
            return this._conditions != null && this._conditions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Logical. 
        /// <para>
        /// Optional field if only one condition is listed. If multiple conditions are listed,
        /// then this field is required.
        /// </para>
        /// </summary>
        public Logical Logical
        {
            get { return this._logical; }
            set { this._logical = value; }
        }

        // Check to see if Logical property is set
        internal bool IsSetLogical()
        {
            return this._logical != null;
        }

    }
}