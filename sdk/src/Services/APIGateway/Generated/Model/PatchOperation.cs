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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

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
        /// The <code>copy</code> update operation's source as identified by a <code>JSON-Pointer</code>
        /// value referencing the location within the targeted resource to copy the value from.
        /// For example, to promote a canary deployment, you copy the canary deployment ID to
        /// the affiliated deployment ID by calling a PATCH request on a <a>Stage</a> resource
        /// with <code>"op":"copy"</code>, <code>"from":"/canarySettings/deploymentId"</code>
        /// and <code>"path":"/deploymentId"</code>.
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
        ///  An update operation to be performed with this PATCH request. The valid value can
        /// be <code>add</code>, <code>remove</code>, <code>replace</code> or <code>copy</code>.
        /// Not all valid operations are supported for a given resource. Support of the operations
        /// depends on specific operational contexts. Attempts to apply an unsupported operation
        /// on a resource will return an error message.
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
        /// The <code>op</code> operation's target, as identified by a <a href="https://tools.ietf.org/html/draft-ietf-appsawg-json-pointer-08">JSON
        /// Pointer</a> value that references a location within the targeted resource. For example,
        /// if the target resource has an updateable property of <code>{"name":"value"}</code>,
        /// the path for this property is <code>/name</code>. If the <code>name</code> property
        /// value is a JSON object (e.g., <code>{"name": {"child/name": "child-value"}}</code>),
        /// the path for the <code>child/name</code> property will be <code>/name/child~1name</code>.
        /// Any slash ("/") character appearing in path names must be escaped with "~1", as shown
        /// in the example above. Each <code>op</code> operation can have only one <code>path</code>
        /// associated with it.
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
        /// The new target value of the update operation. It is applicable for the <code>add</code>
        /// or <code>replace</code> operation. When using AWS CLI to update a property of a JSON
        /// value, enclose the JSON object with a pair of single quotes in a Linux shell, e.g.,
        /// '{"a": ...}'. In a Windows shell, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-using-param.html#cli-using-param-json">Using
        /// JSON for Parameters</a>.
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