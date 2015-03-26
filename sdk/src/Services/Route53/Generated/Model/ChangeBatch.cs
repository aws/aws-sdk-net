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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// A complex type that contains an optional comment and the changes that you want to
    /// make with a change batch request.
    /// </summary>
    public partial class ChangeBatch
    {
        private string _comment;
        private List<Change> _changes = new List<Change>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ChangeBatch() { }

        /// <summary>
        /// Instantiates ChangeBatch with the parameterized properties
        /// </summary>
        /// <param name="changes">A complex type that contains one <code>Change</code> element for each resource record set that you want to create or delete.</param>
        public ChangeBatch(List<Change> changes)
        {
            _changes = changes;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// <i>Optional:</i> Any comments you want to include about a change batch request.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property Changes. 
        /// <para>
        /// A complex type that contains one <code>Change</code> element for each resource record
        /// set that you want to create or delete.
        /// </para>
        /// </summary>
        public List<Change> Changes
        {
            get { return this._changes; }
            set { this._changes = value; }
        }

        // Check to see if Changes property is set
        internal bool IsSetChanges()
        {
            return this._changes != null && this._changes.Count > 0; 
        }

    }
}