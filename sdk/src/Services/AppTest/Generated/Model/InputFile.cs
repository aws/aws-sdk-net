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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Specifies the input file.
    /// </summary>
    public partial class InputFile
    {
        private FileMetadata _fileMetadata;
        private string _sourceLocation;
        private string _targetLocation;

        /// <summary>
        /// Gets and sets the property FileMetadata. 
        /// <para>
        /// The file metadata of the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileMetadata FileMetadata
        {
            get { return this._fileMetadata; }
            set { this._fileMetadata = value; }
        }

        // Check to see if FileMetadata property is set
        internal bool IsSetFileMetadata()
        {
            return this._fileMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLocation. 
        /// <para>
        /// The source location of the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceLocation
        {
            get { return this._sourceLocation; }
            set { this._sourceLocation = value; }
        }

        // Check to see if SourceLocation property is set
        internal bool IsSetSourceLocation()
        {
            return this._sourceLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TargetLocation. 
        /// <para>
        /// The target location of the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TargetLocation
        {
            get { return this._targetLocation; }
            set { this._targetLocation = value; }
        }

        // Check to see if TargetLocation property is set
        internal bool IsSetTargetLocation()
        {
            return this._targetLocation != null;
        }

    }
}