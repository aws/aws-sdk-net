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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about a source file that is part of changes made in a commit.
    /// </summary>
    public partial class SourceFileSpecifier
    {
        private string _filePath;
        private bool? _isMove;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The full path to the file, including the name of the file.
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
        /// Gets and sets the property IsMove. 
        /// <para>
        /// Whether to remove the source file from the parent commit.
        /// </para>
        /// </summary>
        public bool? IsMove
        {
            get { return this._isMove; }
            set { this._isMove = value; }
        }

        // Check to see if IsMove property is set
        internal bool IsSetIsMove()
        {
            return this._isMove.HasValue; 
        }

    }
}