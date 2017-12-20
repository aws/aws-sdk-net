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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes a file to be associated with an OTA update.
    /// </summary>
    public partial class OTAUpdateFile
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private CodeSigning _codeSigning;
        private string _fileName;
        private Stream _fileSource;
        private string _fileVersion;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A list of name/attribute pairs.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CodeSigning. 
        /// <para>
        /// The code signing method of the file.
        /// </para>
        /// </summary>
        public CodeSigning CodeSigning
        {
            get { return this._codeSigning; }
            set { this._codeSigning = value; }
        }

        // Check to see if CodeSigning property is set
        internal bool IsSetCodeSigning()
        {
            return this._codeSigning != null;
        }

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// The name of the file.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FileSource. 
        /// <para>
        /// The source of the file.
        /// </para>
        /// </summary>
        public Stream FileSource
        {
            get { return this._fileSource; }
            set { this._fileSource = value; }
        }

        // Check to see if FileSource property is set
        internal bool IsSetFileSource()
        {
            return this._fileSource != null;
        }

        /// <summary>
        /// Gets and sets the property FileVersion. 
        /// <para>
        /// The file version.
        /// </para>
        /// </summary>
        public string FileVersion
        {
            get { return this._fileVersion; }
            set { this._fileVersion = value; }
        }

        // Check to see if FileVersion property is set
        internal bool IsSetFileVersion()
        {
            return this._fileVersion != null;
        }

    }
}