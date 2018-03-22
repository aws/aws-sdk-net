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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Information about the build environment of the build project.
    /// </summary>
    public partial class ProjectEnvironment
    {
        private string _certificate;
        private ComputeType _computeType;
        private List<EnvironmentVariable> _environmentVariables = new List<EnvironmentVariable>();
        private string _image;
        private bool? _privilegedMode;
        private EnvironmentType _type;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The certificate to use with this build project.
        /// </para>
        /// </summary>
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// Information about the compute resources the build project will use. Available values
        /// include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>BUILD_GENERAL1_SMALL</code>: Use up to 3 GB memory and 2 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BUILD_GENERAL1_MEDIUM</code>: Use up to 7 GB memory and 4 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>BUILD_GENERAL1_LARGE</code>: Use up to 15 GB memory and 8 vCPUs for builds.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ComputeType ComputeType
        {
            get { return this._computeType; }
            set { this._computeType = value; }
        }

        // Check to see if ComputeType property is set
        internal bool IsSetComputeType()
        {
            return this._computeType != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentVariables. 
        /// <para>
        /// A set of environment variables to make available to builds for this build project.
        /// </para>
        /// </summary>
        public List<EnvironmentVariable> EnvironmentVariables
        {
            get { return this._environmentVariables; }
            set { this._environmentVariables = value; }
        }

        // Check to see if EnvironmentVariables property is set
        internal bool IsSetEnvironmentVariables()
        {
            return this._environmentVariables != null && this._environmentVariables.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Image. 
        /// <para>
        /// The ID of the Docker image to use for this build project.
        /// </para>
        /// </summary>
        public string Image
        {
            get { return this._image; }
            set { this._image = value; }
        }

        // Check to see if Image property is set
        internal bool IsSetImage()
        {
            return this._image != null;
        }

        /// <summary>
        /// Gets and sets the property PrivilegedMode. 
        /// <para>
        /// Enables running the Docker daemon inside a Docker container. Set to true only if the
        /// build project is be used to build Docker images, and the specified build environment
        /// image is not provided by AWS CodeBuild with Docker support. Otherwise, all associated
        /// builds that attempt to interact with the Docker daemon will fail. Note that you must
        /// also start the Docker daemon so that builds can interact with it. One way to do this
        /// is to initialize the Docker daemon during the install phase of your build spec by
        /// running the following build commands. (Do not run the following build commands if
        /// the specified build environment image is provided by AWS CodeBuild with Docker support.)
        /// </para>
        ///  
        /// <para>
        ///  <code>- nohup /usr/local/bin/dockerd --host=unix:///var/run/docker.sock --host=tcp://0.0.0.0:2375
        /// --storage-driver=overlay&amp; - timeout -t 15 sh -c "until docker info; do echo .;
        /// sleep 1; done"</code> 
        /// </para>
        /// </summary>
        public bool PrivilegedMode
        {
            get { return this._privilegedMode.GetValueOrDefault(); }
            set { this._privilegedMode = value; }
        }

        // Check to see if PrivilegedMode property is set
        internal bool IsSetPrivilegedMode()
        {
            return this._privilegedMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of build environment to use for related builds.
        /// </para>
        /// </summary>
        public EnvironmentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}