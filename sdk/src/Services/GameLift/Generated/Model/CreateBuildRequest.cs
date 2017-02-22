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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateBuild operation.
    /// Creates a new Amazon GameLift build from a set of game server binary files stored
    /// in an Amazon Simple Storage Service (Amazon S3) location. When using this API call,
    /// you must create a <code>.zip</code> file containing all of the build files and store
    /// it in an Amazon S3 bucket under your AWS account. For help on packaging your build
    /// files and creating a build, see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Uploading
    /// Your Game to Amazon GameLift</a>.
    /// 
    ///  <important> 
    /// <para>
    /// Use this API action ONLY if you are storing your game build files in an Amazon S3
    /// bucket in your AWS account. To create a build using files stored in a directory, use
    /// the CLI command <a href="http://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">
    /// <code>upload-build</code> </a>, which uploads the build files from a file location
    /// you specify and creates a build.
    /// </para>
    ///  </important> 
    /// <para>
    /// To create a new build using <code>CreateBuild</code>, identify the storage location
    /// and operating system of your game build. You also have the option of specifying a
    /// build name and version. If successful, this action creates a new build record with
    /// an unique build ID and in <code>INITIALIZED</code> status. Use the API call <a>DescribeBuild</a>
    /// to check the status of your build. A build must be in <code>READY</code> status before
    /// it can be used to create fleets to host your game.
    /// </para>
    /// </summary>
    public partial class CreateBuildRequest : AmazonGameLiftRequest
    {
        private string _name;
        private OperatingSystem _operatingSystem;
        private S3Location _storageLocation;
        private string _version;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Descriptive label that is associated with a build. Build names do not need to be unique.
        /// You can use <a>UpdateBuild</a> to change this value later. 
        /// </para>
        /// </summary>
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
        /// Operating system that the game server binaries are built to run on. This value determines
        /// the type of fleet resources that you can use for this build. If your game build contains
        /// multiple executables, they all must run on the same operating system.
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
        /// Amazon S3 location of the game build files to be uploaded. The S3 bucket must be owned
        /// by the same AWS account that you're using to manage Amazon GameLift. It also must
        /// in the same region that you want to create a new build in. Before calling <code>CreateBuild</code>
        /// with this location, you must allow Amazon GameLift to access your Amazon S3 bucket
        /// (see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">Create
        /// a Build with Files in Amazon S3</a>).
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
        /// Version that is associated with this build. Version strings do not need to be unique.
        /// You can use <a>UpdateBuild</a> to change this value later. 
        /// </para>
        /// </summary>
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