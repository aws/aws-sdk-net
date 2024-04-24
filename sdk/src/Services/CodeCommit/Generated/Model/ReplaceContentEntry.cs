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
    /// Information about a replacement content entry in the conflict of a merge or pull request
    /// operation.
    /// </summary>
    public partial class ReplaceContentEntry
    {
        private MemoryStream _content;
        private FileModeTypeEnum _fileMode;
        private string _filePath;
        private ReplacementTypeEnum _replacementType;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The base-64 encoded content to use when the replacement type is USE_NEW_CONTENT.
        /// </para>
        /// </summary>
        [AWSProperty(Max=6291456)]
        public MemoryStream Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property FileMode. 
        /// <para>
        /// The file mode to apply during conflict resoltion.
        /// </para>
        /// </summary>
        public FileModeTypeEnum FileMode
        {
            get { return this._fileMode; }
            set { this._fileMode = value; }
        }

        // Check to see if FileMode property is set
        internal bool IsSetFileMode()
        {
            return this._fileMode != null;
        }

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The path of the conflicting file.
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
        /// Gets and sets the property ReplacementType. 
        /// <para>
        /// The replacement type to use when determining how to resolve the conflict.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReplacementTypeEnum ReplacementType
        {
            get { return this._replacementType; }
            set { this._replacementType = value; }
        }

        // Check to see if ReplacementType property is set
        internal bool IsSetReplacementType()
        {
            return this._replacementType != null;
        }

    }
}