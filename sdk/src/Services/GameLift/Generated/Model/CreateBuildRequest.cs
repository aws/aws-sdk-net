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
    /// Initializes a new build record and generates information required to upload a game
    /// build to Amazon GameLift. Once the build record has been created and its status is
    /// <code>INITIALIZED</code>, you can upload your game build.
    /// 
    ///  <important> 
    /// <para>
    /// Do not use this API action unless you are using your own Amazon Simple Storage Service
    /// (Amazon S3) client and need to manually upload your build files. Instead, to create
    /// a build, use the CLI command <code>upload-build</code>, which creates a new build
    /// record and uploads the build files in one step. (See the <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Amazon
    /// GameLift Developer Guide</a> help on packaging and uploading your build.) 
    /// </para>
    ///  </important> 
    /// <para>
    /// To create a new build, identify the operating system of the game server binaries.
    /// All game servers in a build must use the same operating system. Optionally, specify
    /// a build name and version; this metadata is stored with other properties in the build
    /// record and is displayed in the GameLift console (it is not visible to players). If
    /// successful, this action returns the newly created build record along with the Amazon
    /// S3 storage location and AWS account credentials. Use the location and credentials
    /// to upload your game build.
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
        /// Descriptive label associated with a build. Build names do not need to be unique. A
        /// build name can be changed later using <code> <a>UpdateBuild</a> </code>.
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
        /// the type of fleet resources that you can use for this build.
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
        /// Version associated with this build. Version strings do not need to be unique to a
        /// build. A build version can be changed later using <code> <a>UpdateBuild</a> </code>.
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