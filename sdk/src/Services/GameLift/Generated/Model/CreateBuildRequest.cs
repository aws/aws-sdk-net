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
    /// Creates a new Amazon GameLift build resource for your game server binary files. Combine
    /// game server binaries into a zip file for use with Amazon GameLift. 
    /// 
    ///  <important> 
    /// <para>
    /// When setting up a new game build for GameLift, we recommend using the CLI command
    /// <b> <a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
    /// </b>. This helper command combines two tasks: (1) it uploads your build files from
    /// a file directory to a GameLift Amazon S3 location, and (2) it creates a new build
    /// resource.
    /// </para>
    ///  </important> 
    /// <para>
    /// You can use the operation in the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To create a new game build with build files that are in an Amazon S3 location under
    /// an Amazon Web Services account that you control. To use this option, you give Amazon
    /// GameLift access to the Amazon S3 bucket. With permissions in place, specify a build
    /// name, operating system, and the Amazon S3 storage location of your game build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To directly upload your build files to a GameLift Amazon S3 location. To use this
    /// option, specify a build name and operating system. This operation creates a new build
    /// resource and also returns an Amazon S3 location with temporary access credentials.
    /// Use the credentials to manually upload your build files to the specified Amazon S3
    /// location. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
    /// Objects</a> in the <i>Amazon S3 Developer Guide</i>. After you upload build files
    /// to the GameLift Amazon S3 location, you can't update them. 
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
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class CreateBuildRequest : AmazonGameLiftRequest
    {
        private string _name;
        private OperatingSystem _operatingSystem;
        private string _serverSdkVersion;
        private S3Location _storageLocation;
        private List<Tag> _tags = new List<Tag>();
        private string _version;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label associated with a build. Build names do not need to be unique.
        /// You can change this value later. 
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
        /// The operating system that you built the game server binaries to run on. This value
        /// determines the type of fleet resources that you can use for this build. If your game
        /// build contains multiple executables, they all must run on the same operating system.
        /// If an operating system is not specified when creating a build, GameLift uses the default
        /// value (WINDOWS_2012). This value cannot be changed later.
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
        /// Gets and sets the property ServerSdkVersion. 
        /// <para>
        /// A server SDK version you used when integrating your game server build with GameLift.
        /// For more information see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-custom-intro.html">Integrate
        /// games with custom game servers</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string ServerSdkVersion
        {
            get { return this._serverSdkVersion; }
            set { this._serverSdkVersion = value; }
        }

        // Check to see if ServerSdkVersion property is set
        internal bool IsSetServerSdkVersion()
        {
            return this._serverSdkVersion != null;
        }

        /// <summary>
        /// Gets and sets the property StorageLocation. 
        /// <para>
        /// Information indicating where your game build files are stored. Use this parameter
        /// only when creating a build with files stored in an Amazon S3 bucket that you own.
        /// The storage location must specify an Amazon S3 bucket name and key. The location must
        /// also specify a role ARN that you set up to allow Amazon GameLift to access your Amazon
        /// S3 bucket. The S3 bucket and your new build must be in the same Region.
        /// </para>
        ///  
        /// <para>
        /// If a <code>StorageLocation</code> is specified, the size of your file can be found
        /// in your Amazon S3 bucket. Amazon GameLift will report a <code>SizeOnDisk</code> of
        /// 0. 
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
        /// A list of labels to assign to the new build resource. Tags are developer defined key-value
        /// pairs. Tagging Amazon Web Services resources are useful for resource management, access
        /// management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// Once the resource is created, you can use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_TagResource.html">TagResource</a>,
        /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UntagResource.html">UntagResource</a>,
        /// and <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListTagsForResource.html">ListTagsForResource</a>
        /// to add, remove, and view tags. The maximum tag limit may be lower than stated. See
        /// the Amazon Web Services General Reference for actual tagging limits.
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
        /// Version information associated with a build or script. Version strings do not need
        /// to be unique. You can change this value later. 
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