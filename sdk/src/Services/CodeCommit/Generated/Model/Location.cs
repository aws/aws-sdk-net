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
    /// Returns information about the location of a change or comment in the comparison between
    /// two commits or a pull request.
    /// </summary>
    public partial class Location
    {
        private string _filePath;
        private long? _filePosition;
        private RelativeFileVersionEnum _relativeFileVersion;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The name of the file being compared, including its extension and subdirectory, if
        /// any.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FilePosition. 
        /// <para>
        /// The position of a change in a compared file, in line number format.
        /// </para>
        /// </summary>
        public long? FilePosition
        {
            get { return this._filePosition; }
            set { this._filePosition = value; }
        }

        // Check to see if FilePosition property is set
        internal bool IsSetFilePosition()
        {
            return this._filePosition.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelativeFileVersion. 
        /// <para>
        /// In a comparison of commits or a pull request, whether the change is in the before
        /// or after of that comparison.
        /// </para>
        /// </summary>
        public RelativeFileVersionEnum RelativeFileVersion
        {
            get { return this._relativeFileVersion; }
            set { this._relativeFileVersion = value; }
        }

        // Check to see if RelativeFileVersion property is set
        internal bool IsSetRelativeFileVersion()
        {
            return this._relativeFileVersion != null;
        }

    }
}