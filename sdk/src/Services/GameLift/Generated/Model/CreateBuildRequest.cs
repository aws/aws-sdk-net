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
    /// Creates a new Amazon GameLift build record for your game server binary files and points
    /// to the location of your game server build files in an Amazon Simple Storage Service
    /// (Amazon S3) location. 
    /// 
    ///  
    /// <para>
    /// Game server binaries must be combined into a <code>.zip</code> file for use with Amazon
    /// GameLift. See <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Uploading
    /// Your Game</a> for more information. 
    /// </para>
    ///  <important> 
    /// <para>
    /// To create new builds quickly and easily, use the AWS CLI command <b> <a href="http://docs.aws.amazon.com/cli/latest/reference/gamelift/upload-build.html">upload-build</a>
    /// </b>. This helper command uploads your build and creates a new build record in one
    /// step, and automatically handles the necessary permissions. See <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html">
    /// Upload Build Files to Amazon GameLift</a> for more help.
    /// </para>
    ///  </important> 
    /// <para>
    /// The <code>CreateBuild</code> operation should be used only when you need to manually
    /// upload your build files, as in the following scenarios:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Store a build file in an Amazon S3 bucket under your own AWS account. To use this
    /// option, you must first give Amazon GameLift access to that Amazon S3 bucket. See <a
    /// href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-cli-uploading.html#gamelift-build-cli-uploading-create-build">
    /// Create a Build with Files in Amazon S3</a> for detailed help. To create a new build
    /// record using files in your Amazon S3 bucket, call <code>CreateBuild</code> and specify
    /// a build name, operating system, and the storage location of your game build.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Upload a build file directly to Amazon GameLift's Amazon S3 account. To use this option,
    /// you first call <code>CreateBuild</code> with a build name and operating system. This
    /// action creates a new build record and returns an Amazon S3 storage location (bucket
    /// and key only) and temporary access credentials. Use the credentials to manually upload
    /// your build file to the storage location (see the Amazon S3 topic <a href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UploadingObjects.html">Uploading
    /// Objects</a>). You can upload files to a location only once. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If successful, this operation creates a new build record with a unique build ID and
    /// places it in <code>INITIALIZED</code> status. You can use <a>DescribeBuild</a> to
    /// check the status of your build. A build must be in <code>READY</code> status before
    /// it can be used to create fleets.
    /// </para>
    ///  
    /// <para>
    /// Build-related operations include:
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
        /// multiple executables, they all must run on the same operating system. If an operating
        /// system is not specified when creating a build, Amazon GameLift uses the default value
        /// (WINDOWS_2012). This value cannot be changed later.
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
        /// Information indicating where your game build files are stored. Use this parameter
        /// only when creating a build with files stored in an Amazon S3 bucket that you own.
        /// The storage location must specify an Amazon S3 bucket name and key, as well as a role
        /// ARN that you set up to allow Amazon GameLift to access your Amazon S3 bucket. The
        /// S3 bucket must be in the same region that you want to create a new build in.
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