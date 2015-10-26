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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// A single patch operation to apply to the specified resource. Please refer to http://tools.ietf.org/html/rfc6902#section-4
    /// for an explanation of how each operation is used.
    /// </summary>
    public partial class PatchOperation
    {
        private string _from;
        private Op _op;
        private string _path;
        private string _value;

        /// <summary>
        /// Gets and sets the property From. 
        /// <para>
        /// The "move" and "copy" operation object MUST contain a "from" member, which is a string
        /// containing a <code>JSON Pointer</code> value that references the location in the target
        /// document to move the value from.
        /// </para>
        /// </summary>
        public string From
        {
            get { return this._from; }
            set { this._from = value; }
        }

        // Check to see if From property is set
        internal bool IsSetFrom()
        {
            return this._from != null;
        }

        /// <summary>
        /// Gets and sets the property Op. 
        /// <para>
        /// A patch operation whose value indicates the operation to perform. Its value MUST be
        /// one of "add", "remove", "replace", "move", "copy", or "test"; other values are errors.
        /// 
        /// </para>
        /// </summary>
        public Op Op
        {
            get { return this._op; }
            set { this._op = value; }
        }

        // Check to see if Op property is set
        internal bool IsSetOp()
        {
            return this._op != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// Operation objects MUST have exactly one "path" member. That member's value is a string
        /// containing a `JSON-Pointer` value that references a location within the target document
        /// (the "target location") where the operation is performed.
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The actual value content. 
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}