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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateScript operation.
    /// Updates Realtime script metadata and content.
    /// 
    ///  
    /// <para>
    /// To update script metadata, specify the script ID and provide updated name and/or version
    /// values. 
    /// </para>
    ///  
    /// <para>
    /// To update script content, provide an updated zip file by pointing to either a local
    /// file or an Amazon S3 bucket location. You can use either method regardless of how
    /// the original script was uploaded. Use the <i>Version</i> parameter to track updates
    /// to the script.
    /// </para>
    ///  
    /// <para>
    /// If the call is successful, the updated metadata is stored in the script record and
    /// a revised script is uploaded to the Amazon GameLift service. Once the script is updated
    /// and acquired by a fleet instance, the new version is used for all new game sessions.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/realtime-intro.html">Amazon
    /// GameLift Realtime Servers</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class UpdateScriptRequest : AmazonGameLiftRequest
    {
        private string _name;
        private string _scriptId;
        private S3Location _storageLocation;
        private string _version;
        private MemoryStream _zipFile;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a script. Script names do not need to
        /// be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// A unique identifier for the Realtime script to update. You can use either the script
        /// ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScriptId
        {
            get { return this._scriptId; }
            set { this._scriptId = value; }
        }

        // Check to see if ScriptId property is set
        internal bool IsSetScriptId()
        {
            return this._scriptId != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// The location of the Amazon S3 bucket where a zipped file containing your Realtime
        /// scripts is stored. The storage location must specify the Amazon S3 bucket name, the
        /// zip file name (the "key"), and a role ARN that allows Amazon GameLift to access the
        /// Amazon S3 storage location. The S3 bucket must be in the same Region where you want
        /// to create a new script. By default, Amazon GameLift uploads the latest version of
        /// the zip file; if you have S3 object versioning turned on, you can use the <code>ObjectVersion</code>
        /// parameter to specify an earlier version. 
        /// </para>
        /// </summary>
        public S3Location StorageLocation
        {
            get { return this._storageLocation; }
            set { this._storageLocation = value; }
        }

        // Check to see if StorageLocation property is set
        internal bool IsSetStorageLocation()
        {
            return this._storageLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version information associated with a build or script. Version strings do not need
        /// to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property ZipFile. 
        /// <para>
        /// A data object containing your Realtime scripts and dependencies as a zip file. The
        /// zip file can have one or multiple files. Maximum size of a zip file is 5 MB.
        /// </para>
        ///  
        /// <para>
        /// When using the Amazon Web Services CLI tool to create a script, this parameter is
        /// set to the zip file name. It must be prepended with the string "fileb://" to indicate
        /// that the file data is a binary object. For example: <code>--zip-file fileb://myRealtimeScript.zip</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=5000000)]
        public MemoryStream ZipFile
        {
            get { return this._zipFile; }
            set { this._zipFile = value; }
        }

        // Check to see if ZipFile property is set
        internal bool IsSetZipFile()
        {
            return this._zipFile != null;
        }

    }
}