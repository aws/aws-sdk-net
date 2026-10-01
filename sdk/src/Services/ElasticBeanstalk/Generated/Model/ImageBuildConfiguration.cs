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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
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
namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Settings that Elastic Beanstalk uses to build a container image from the source bundle
    /// of an application version.
    /// </summary>
    public partial class ImageBuildConfiguration
    {
        private ArchitectureType _architecture;
        private string _buildpack;
        private string _codeBuildServiceRole;
        private ComputeType _computeType;
        private string _dockerfileLocation;
        private int? _timeoutInMinutes;
        private ImageBuildType _type;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The processor architecture that Elastic Beanstalk builds the container image for.
        /// The architecture must match the architecture of the instances in the environment that
        /// you deploy the application version to.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>amd64</c> – x86-64 instances. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>arm64</c> – Amazon Web Services Graviton instances.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ArchitectureType Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property Buildpack. 
        /// <para>
        /// The Cloud Native Buildpacks builder image that Elastic Beanstalk uses to build the
        /// container image. For example, <c>paketobuildpacks/builder-jammy-base</c>.
        /// </para>
        ///  
        /// <para>
        /// This member is required when <c>Type</c> is <c>buildpack</c>. Elastic Beanstalk doesn't
        /// provide a default builder.
        /// </para>
        /// </summary>
        public string Buildpack
        {
            get { return this._buildpack; }
            set { this._buildpack = value; }
        }

        // Check to see if Buildpack property is set
        internal bool IsSetBuildpack()
        {
            return this._buildpack != null;
        }

        /// <summary>
        /// Gets and sets the property CodeBuildServiceRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// CodeBuild assumes to run the build in your Amazon Web Services account. Elastic Beanstalk
        /// rejects a <c>Build</c> that doesn't specify this role.
        /// </para>
        /// </summary>
        public string CodeBuildServiceRole
        {
            get { return this._codeBuildServiceRole; }
            set { this._codeBuildServiceRole = value; }
        }

        // Check to see if CodeBuildServiceRole property is set
        internal bool IsSetCodeBuildServiceRole()
        {
            return this._codeBuildServiceRole != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeType. 
        /// <para>
        /// The size of the compute resources that run the build. If you don't specify it, Elastic
        /// Beanstalk uses <c>BUILD_GENERAL1_MEDIUM</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_SMALL</c> – Use up to 3 GB memory and 2 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_MEDIUM</c> – Use up to 7 GB memory and 4 vCPUs for builds.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_LARGE</c> – Use up to 15 GB memory and 8 vCPUs for builds.
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
        /// Gets and sets the property DockerfileLocation. 
        /// <para>
        /// The path to the Dockerfile within the source bundle, relative to the root of the source
        /// bundle. For example, <c>backend/Dockerfile</c>.
        /// </para>
        ///  
        /// <para>
        /// Elastic Beanstalk uses this member only when <c>Type</c> is <c>docker</c>. If you
        /// don't specify it, Elastic Beanstalk uses the Dockerfile at the root of the source
        /// bundle.
        /// </para>
        /// </summary>
        public string DockerfileLocation
        {
            get { return this._dockerfileLocation; }
            set { this._dockerfileLocation = value; }
        }

        // Check to see if DockerfileLocation property is set
        internal bool IsSetDockerfileLocation()
        {
            return this._dockerfileLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long, in minutes from 5 to 480 (8 hours), Elastic Beanstalk waits before stopping
        /// a build that hasn't completed. The default is 60 minutes.
        /// </para>
        /// </summary>
        public int? TimeoutInMinutes
        {
            get { return this._timeoutInMinutes; }
            set { this._timeoutInMinutes = value; }
        }

        // Check to see if TimeoutInMinutes property is set
        internal bool IsSetTimeoutInMinutes()
        {
            return this._timeoutInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// How Elastic Beanstalk builds the container image. Elastic Beanstalk rejects a <c>Build</c>
        /// that doesn't specify it.
        /// </para>
        ///  
        /// <para>
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>docker</c> – Elastic Beanstalk builds the image from a Dockerfile in your source
        /// bundle. Specify the Dockerfile with <c>DockerfileLocation</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>buildpack</c> – Elastic Beanstalk builds the image with a Cloud Native Buildpacks
        /// builder. Specify the builder with <c>Buildpack</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ImageBuildType Type
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