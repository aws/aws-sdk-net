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
    /// Container for the parameters to the CreateScript operation.
    /// Creates a new script record for your Realtime Servers script. Realtime scripts are
    /// JavaScript that provide configuration settings and optional custom game logic for
    /// your game. The script is deployed when you create a Realtime Servers fleet to host
    /// your game sessions. Script logic is executed during an active game session. 
    /// 
    ///  
    /// <para>
    /// To create a new script record, specify a script name and provide the script file(s).
    /// The script files and all dependencies must be zipped into a single file. You can pull
    /// the zip file from either of these locations: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A locally available directory. Use the <i>ZipFile</i> parameter for this option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// An Amazon Simple Storage Service (Amazon S3) bucket under your AWS account. Use the
    /// <i>StorageLocation</i> parameter for this option. You'll need to have an Identity
    /// Access Management (IAM) role that allows the Amazon GameLift service to access your
    /// S3 bucket. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the call is successful, a new script record is created with a unique script ID.
    /// If the script file is provided as a local file, the file is uploaded to an Amazon
    /// GameLift-owned S3 bucket and the script record's storage location reflects this location.
    /// If the script file is provided as an S3 bucket, Amazon GameLift accesses the file
    /// at this storage location as needed for deployment.
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
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">Set
    /// Up a Role for Amazon GameLift Access</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListScripts</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateScript</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteScript</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateScriptRequest : AmazonGameLiftRequest
    {
        private string _name;
        private S3Location _storageLocation;
        private List<Tag> _tags = new List<Tag>();
        private string _version;
        private MemoryStream _zipFile;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a script. Script names do not need to
        /// be unique. You can use <a>UpdateScript</a> to change this value later. 
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
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// The Amazon S3 location of your Realtime scripts. The storage location must specify
        /// the S3 bucket name, the zip file name (the "key"), and an IAM role ARN that allows
        /// Amazon GameLift to access the S3 storage location. The S3 bucket must be in the same
        /// Region where you are creating a new script. By default, Amazon GameLift uploads the
        /// latest version of the zip file; if you have S3 object versioning turned on, you can
        /// use the <code>ObjectVersion</code> parameter to specify an earlier version. To call
        /// this operation with a storage location, you must have IAM PassRole permission. For
        /// more details on IAM roles and PassRole permissions, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">
        /// Set up a role for GameLift access</a>. 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new script resource. Tags are developer-defined
        /// key-value pairs. Tagging AWS resources are useful for resource management, access
        /// management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging AWS Resources</a> in the <i>AWS General Reference</i>. Once the resource is
        /// created, you can use <a>TagResource</a>, <a>UntagResource</a>, and <a>ListTagsForResource</a>
        /// to add, remove, and view tags. The maximum tag limit may be lower than stated. See
        /// the AWS General Reference for actual tagging limits.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version that is associated with a build or script. Version strings do not need
        /// to be unique. You can use <a>UpdateScript</a> to change this value later. 
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
        /// When using the AWS CLI tool to create a script, this parameter is set to the zip file
        /// name. It must be prepended with the string "fileb://" to indicate that the file data
        /// is a binary object. For example: <code>--zip-file fileb://myRealtimeScript.zip</code>.
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