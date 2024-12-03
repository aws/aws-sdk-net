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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBuild operation.
    /// Creates an Amazon GameLift build resource for your game server software and stores
    /// the software for deployment to hosting resources. Combine game server binaries and
    /// dependencies into a single .zip file 
    /// 
    ///  <important> 
    /// <para>
    /// Use the CLI command <b> <a href="https://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
    /// </b> to quickly and simply create a new build and upload your game build .zip file
    /// to Amazon GameLift Amazon S3. This helper command eliminates the need to explicitly
    /// manage access permissions.
    /// </para>
    ///  </important> 
    /// <para>
    /// Alternatively, use the <c>CreateBuild</c> action for the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You want to create a build and upload a game build zip file from in an Amazon S3 location
    /// that you control. In this scenario, you need to give Amazon GameLift permission to
    /// access to the Amazon S3 bucket. With permission in place, call <c>CreateBuild</c>
    /// and specify a build name, the build's runtime operating system, and the Amazon S3
    /// storage location where the build file is stored.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You want to create a build and upload a local game build zip file to an Amazon S3
    /// location that's controlled by Amazon GameLift. (See the <c>upload-build</c> CLI command
    /// for this scenario.) In this scenario, you need to request temporary access credentials
    /// to the Amazon GameLift Amazon S3 location. Specify a build name and the build's runtime
    /// operating system. The response provides an Amazon S3 location and a set of temporary
    /// access credentials. Use the credentials to upload your build files to the specified
    /// Amazon S3 location (see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
    /// Objects</a> in the <i>Amazon S3 Developer Guide</i>). You can't update build files
    /// after uploading them to Amazon GameLift Amazon S3.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, this action creates a new build resource with a unique build ID and
    /// places it in <c>INITIALIZED</c> status. When the build reaches <c>READY</c> status,
    /// you can create fleets with it.
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
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _version;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a build. Build names do not need to be
        /// unique. You can change this value later. 
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
        /// The environment that your game server binaries run on. This value determines the type
        /// of fleet resources that you use for this build. If your game build contains multiple
        /// executables, they all must run on the same operating system. This parameter is required,
        /// and there's no default value. You can't change a build's operating system later.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2 (AL2) will reach end of support on 6/30/2025. See more details in the
        /// <a href="https://aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2 FAQs</a>. For
        /// game servers that are hosted on AL2 and use Amazon GameLift server SDK 4.x., first
        /// update the game server build to server SDK 5.x, and then deploy to AL2023 instances.
        /// See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to Amazon GameLift server SDK version 5.</a> 
        /// </para>
        ///  </note>
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
        /// A server SDK version you used when integrating your game server build with Amazon
        /// GameLift. For more information see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-custom-intro.html">Integrate
        /// games with custom game servers</a>. By default Amazon GameLift sets this value to
        /// <c>4.0.2</c>.
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
        /// If a <c>StorageLocation</c> is specified, the size of your file can be found in your
        /// Amazon S3 bucket. Amazon GameLift will report a <c>SizeOnDisk</c> of 0. 
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version information that is associated with a build or script. Version strings do
        /// not need to be unique. You can change this value later. 
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