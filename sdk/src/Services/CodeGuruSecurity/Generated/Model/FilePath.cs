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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
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
namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Information about the location of security vulnerabilities that Amazon CodeGuru Security
    /// detected in your code.
    /// </summary>
    public partial class FilePath
    {
        private List<CodeLine> _codeSnippet = AWSConfigs.InitializeCollections ? new List<CodeLine>() : null;
        private int? _endLine;
        private string _name;
        private string _path;
        private int? _startLine;

        /// <summary>
        /// Gets and sets the property CodeSnippet. 
        /// <para>
        /// A list of <c>CodeLine</c> objects that describe where the security vulnerability appears
        /// in your code.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodeLine> CodeSnippet
        {
            get { return this._codeSnippet; }
            set { this._codeSnippet = value; }
        }

        // Check to see if CodeSnippet property is set
        internal bool IsSetCodeSnippet()
        {
            return this._codeSnippet != null && (this._codeSnippet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndLine. 
        /// <para>
        /// The last line number of the code snippet where the security vulnerability appears
        /// in your code.
        /// </para>
        /// </summary>
        public int? EndLine
        {
            get { return this._endLine; }
            set { this._endLine = value; }
        }

        // Check to see if EndLine property is set
        internal bool IsSetEndLine()
        {
            return this._endLine.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the file.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path to the resource with the security vulnerability.
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
        /// Gets and sets the property StartLine. 
        /// <para>
        /// The first line number of the code snippet where the security vulnerability appears
        /// in your code.
        /// </para>
        /// </summary>
        public int? StartLine
        {
            get { return this._startLine; }
            set { this._startLine = value; }
        }

        // Check to see if StartLine property is set
        internal bool IsSetStartLine()
        {
            return this._startLine.HasValue; 
        }

    }
}