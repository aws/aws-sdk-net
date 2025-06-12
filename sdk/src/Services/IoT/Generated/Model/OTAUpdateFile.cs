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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Describes a file to be associated with an OTA update.
    /// </summary>
    public partial class OTAUpdateFile
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private CodeSigning _codeSigning;
        private FileLocation _fileLocation;
        private string _fileName;
        private int? _fileType;
        private string _fileVersion;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A list of name-attribute pairs. They won't be sent to devices as a part of the Job
        /// document.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property FileLocation. 
        /// <para>
        /// The location of the updated firmware.
        /// </para>
        /// </summary>
        public FileLocation FileLocation
        {
            get { return this._fileLocation; }
            set { this._fileLocation = value; }
        }

        // Check to see if FileLocation property is set
        internal bool IsSetFileLocation()
        {
            return this._fileLocation != null;
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
        /// Gets and sets the property FileType. 
        /// <para>
        /// An integer value you can include in the job document to allow your devices to identify
        /// the type of file received from the cloud.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public int? FileType
        {
            get { return this._fileType; }
            set { this._fileType = value; }
        }

        // Check to see if FileType property is set
        internal bool IsSetFileType()
        {
            return this._fileType.HasValue; 
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