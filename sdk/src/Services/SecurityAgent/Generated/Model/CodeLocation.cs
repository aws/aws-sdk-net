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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Represents a location in source code associated with a security finding.
    /// </summary>
    public partial class CodeLocation
    {
        private string _filePath;
        private string _label;
        private int? _lineEnd;
        private int? _lineStart;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The absolute path to the file containing the code location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FilePath
        {
            get { return this._filePath; }
            set { this._filePath = value; }
        }

        // Check to see if FilePath property is set
        internal bool IsSetFilePath()
        {
            return this._filePath != null;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The role of this location in the vulnerability, such as source or sink.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property LineEnd. 
        /// <para>
        /// The ending line number of the code location.
        /// </para>
        /// </summary>
        public int? LineEnd
        {
            get { return this._lineEnd; }
            set { this._lineEnd = value; }
        }

        // Check to see if LineEnd property is set
        internal bool IsSetLineEnd()
        {
            return this._lineEnd.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LineStart. 
        /// <para>
        /// The starting line number of the code location.
        /// </para>
        /// </summary>
        public int? LineStart
        {
            get { return this._lineStart; }
            set { this._lineStart = value; }
        }

        // Check to see if LineStart property is set
        internal bool IsSetLineStart()
        {
            return this._lineStart.HasValue; 
        }

    }
}