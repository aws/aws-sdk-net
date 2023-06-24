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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Contains information on where a code vulnerability is located in your Lambda function.
    /// </summary>
    public partial class CodeFilePath
    {
        private int? _endLine;
        private string _fileName;
        private string _filePath;
        private int? _startLine;

        /// <summary>
        /// Gets and sets the property EndLine. 
        /// <para>
        /// The line number of the last line of code that a vulnerability was found in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int EndLine
        {
            get { return this._endLine.GetValueOrDefault(); }
            set { this._endLine = value; }
        }

        // Check to see if EndLine property is set
        internal bool IsSetEndLine()
        {
            return this._endLine.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the file the code vulnerability was found in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string FileName
        {
            get { return this._fileName; }
            set { this._fileName = value; }
        }

        // Check to see if FileName property is set
        internal bool IsSetFileName()
        {
            return this._fileName != null;
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The file path to the code that a vulnerability was found in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property StartLine. 
        /// <para>
        /// The line number of the first line of code that a vulnerability was found in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int StartLine
        {
            get { return this._startLine.GetValueOrDefault(); }
            set { this._startLine = value; }
        }

        // Check to see if StartLine property is set
        internal bool IsSetStartLine()
        {
            return this._startLine.HasValue; 
        }

    }
}