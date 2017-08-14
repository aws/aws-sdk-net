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
    /// Represents a node in a directed acyclic graph (DAG)
    /// </summary>
    public partial class CodeGenNode
    {
        private List<CodeGenNodeArg> _args = new List<CodeGenNodeArg>();
        private string _id;
        private int? _lineNumber;
        private string _nodeType;

        /// <summary>
        /// Gets and sets the property Args. 
        /// <para>
        /// Properties of the node, in the form of name-value pairs.
        /// </para>
        /// </summary>
        public List<CodeGenNodeArg> Args
        {
            get { return this._args; }
            set { this._args = value; }
        }

        // Check to see if Args property is set
        internal bool IsSetArgs()
        {
            return this._args != null && this._args.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A node identifier that is unique within the node's graph.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LineNumber. 
        /// <para>
        /// The line number of the node.
        /// </para>
        /// </summary>
        public int LineNumber
        {
            get { return this._lineNumber.GetValueOrDefault(); }
            set { this._lineNumber = value; }
        }

        // Check to see if LineNumber property is set
        internal bool IsSetLineNumber()
        {
            return this._lineNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NodeType. 
        /// <para>
        /// The type of node this is.
        /// </para>
        /// </summary>
        public string NodeType
        {
            get { return this._nodeType; }
            set { this._nodeType = value; }
        }

        // Check to see if NodeType property is set
        internal bool IsSetNodeType()
        {
            return this._nodeType != null;
        }

    }
}