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
    /// Settings for an AWS CodeBuild build.
    /// </summary>
    public partial class BuildConfiguration
    {
        private string _artifactName;
        private string _codeBuildServiceRole;
        private ComputeType _computeType;
        private string _image;
        private int? _timeoutInMinutes;

        /// <summary>
        /// Gets and sets the property ArtifactName. 
        /// <para>
        /// The name of the artifact of the CodeBuild build. If provided, Elastic Beanstalk stores
        /// the build artifact in the S3 location <i>S3-bucket</i>/resources/<i>application-name</i>/codebuild/codebuild-<i>version-label</i>-<i>artifact-name</i>.zip.
        /// If not provided, Elastic Beanstalk stores the build artifact in the S3 location <i>S3-bucket</i>/resources/<i>application-name</i>/codebuild/codebuild-<i>version-label</i>.zip.
        /// 
        /// </para>
        /// </summary>
        public string ArtifactName
        {
            get { return this._artifactName; }
            set { this._artifactName = value; }
        }

        // Check to see if ArtifactName property is set
        internal bool IsSetArtifactName()
        {
            return this._artifactName != null;
        }

        /// <summary>
        /// Gets and sets the property CodeBuildServiceRole. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role
        /// that enables AWS CodeBuild to interact with dependent AWS services on behalf of the
        /// AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Information about the compute resources the build project will use.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_SMALL: Use up to 3 GB memory and 2 vCPUs for builds</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_MEDIUM: Use up to 7 GB memory and 4 vCPUs for builds</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BUILD_GENERAL1_LARGE: Use up to 15 GB memory and 8 vCPUs for builds</c> 
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
        /// Gets and sets the property Image. 
        /// <para>
        /// The ID of the Docker image to use for this build project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property TimeoutInMinutes. 
        /// <para>
        /// How long in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait until timing
        /// out any related build that does not get marked as completed. The default is 60 minutes.
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

    }
}