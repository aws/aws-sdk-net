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
    /// Container for the parameters to the CreateBuild operation.
    /// Creates a new Amazon GameLift build resource for your game server binary files. Game
    /// server binaries must be combined into a zip file for use with Amazon GameLift. 
    /// 
    ///  <important> 
    /// <para>
    /// When setting up a new game build for GameLift, we recommend using the AWS CLI command
    /// <b> <a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
    /// </b>. This helper command combines two tasks: (1) it uploads your build files from
    /// a file directory to a GameLift Amazon S3 location, and (2) it creates a new build
    /// resource. 
    /// </para>
    ///  </important> 
    /// <para>
    /// The <code>CreateBuild</code> operation can used in the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create a new game build with build files that are in an S3 location under an AWS
    /// account that you control. To use this option, you must first give Amazon GameLift
    /// access to the S3 bucket. With permissions in place, call <code>CreateBuild</code>
    /// and specify a build name, operating system, and the S3 storage location of your game
    /// build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To directly upload your build files to a GameLift S3 location. To use this option,
    /// first call <code>CreateBuild</code> and specify a build name and operating system.
    /// This operation creates a new build resource and also returns an S3 location with temporary
    /// access credentials. Use the credentials to manually upload your build files to the
    /// specified S3 location. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
    /// Objects</a> in the <i>Amazon S3 Developer Guide</i>. Build files can be uploaded to
    /// the GameLift S3 location once only; that can't be updated. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, this operation creates a new build resource with a unique build ID
    /// and places it in <code>INITIALIZED</code> status. A build must be in <code>READY</code>
    /// status before you can create fleets with it.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Uploading
    /// Your Game</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
    /// Create a Build with Files in Amazon S3</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateBuild</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListBuilds</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeBuild</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateBuild</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteBuild</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateBuildRequest : AmazonGameLiftRequest
    {
        private string _name;
        private OperatingSystem _operatingSystem;
        private S3Location _storageLocation;
        private List<Tag> _tags = new List<Tag>();
        private string _version;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a build. Build names do not need to be
        /// unique. You can use <a>UpdateBuild</a> to change this value later. 
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The operating system that the game server binaries are built to run on. This value
        /// determines the type of fleet resources that you can use for this build. If your game
        /// build contains multiple executables, they all must run on the same operating system.
        /// If an operating system is not specified when creating a build, Amazon GameLift uses
        /// the default value (WINDOWS_2012). This value cannot be changed later.
        /// </para>
        /// </summary>
        public OperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// The location where your game build files are stored. Use this parameter only when
        /// creating a build using files that are stored in an S3 bucket that you own. Identify
        /// an S3 bucket name and key, which must in the same Region where you're creating a build.
        /// This parameter must also specify the ARN for an IAM role that you've set up to give
        /// Amazon GameLift access your S3 bucket. To call this operation with a storage location,
        /// you must have IAM PassRole permission. For more details on IAM roles and PassRole
        /// permissions, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/setting-up-role.html">
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
        /// A list of labels to assign to the new build resource. Tags are developer-defined key-value
        /// pairs. Tagging AWS resources are useful for resource management, access management
        /// and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
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
        /// Version information that is associated with a build or script. Version strings do
        /// not need to be unique. You can use <a>UpdateBuild</a> to change this value later.
        /// 
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

    }
}