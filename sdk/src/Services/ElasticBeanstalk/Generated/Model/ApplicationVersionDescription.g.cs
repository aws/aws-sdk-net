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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes the properties of an application version.
    /// </summary>
    public partial class ApplicationVersionDescription
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public ApplicationVersionDescription() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to which the application version belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property ApplicationVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application version.
        /// </para>
        /// </summary>
        public string ApplicationVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationVersionArn property is set.
        /// </summary>
        internal bool IsSetApplicationVersionArn() => this.ApplicationVersionArn != null;

        /// <summary>
        /// Gets and sets the property BuildArn. 
        /// <para>
        /// Reference to the artifact from the CodeBuild build.
        /// </para>
        /// </summary>
        public string BuildArn { get; set; }

        /// <summary>
        /// Checks to see if the BuildArn property is set.
        /// </summary>
        internal bool IsSetBuildArn() => this.BuildArn != null;

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The creation date of the application version.
        /// </para>
        /// </summary>
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Checks to see if the DateCreated property is set.
        /// </summary>
        internal bool IsSetDateCreated() => this.DateCreated.HasValue;

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The last modified date of the application version.
        /// </para>
        /// </summary>
        public DateTime? DateUpdated { get; set; }

        /// <summary>
        /// Checks to see if the DateUpdated property is set.
        /// </summary>
        internal bool IsSetDateUpdated() => this.DateUpdated.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ImageBuildConfiguration. 
        /// <para>
        /// The settings that Elastic Beanstalk uses to build a container image from the source
        /// bundle of the application version. Not present for an application version created
        /// from an image you provide.
        /// </para>
        /// </summary>
        public ImageBuildConfiguration ImageBuildConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuildConfiguration property is set.
        /// </summary>
        internal bool IsSetImageBuildConfiguration() => this.ImageBuildConfiguration != null;

        /// <summary>
        /// Gets and sets the property ImageSource. 
        /// <para>
        /// The location of the container image for the application version.
        /// </para>
        ///  
        /// <para>
        /// For an application version created from an image you provide, this is that image.
        /// For one that Elastic Beanstalk builds from your source bundle, Elastic Beanstalk fills
        /// this in with the image it pushed after the build succeeds.
        /// </para>
        /// </summary>
        public ImageSource ImageSource { get; set; }

        /// <summary>
        /// Checks to see if the ImageSource property is set.
        /// </summary>
        internal bool IsSetImageSource() => this.ImageSource != null;

        /// <summary>
        /// Gets and sets the property Process. 
        /// <para>
        /// Indicates whether Elastic Beanstalk pre-processed and validated the environment manifest
        /// (<c>env.yaml</c>) and configuration files (<c>*.config</c> files in the <c>.ebextensions</c>
        /// folder) in the source bundle of the application version.
        /// </para>
        /// </summary>
        public bool? Process { get; set; }

        /// <summary>
        /// Checks to see if the Process property is set.
        /// </summary>
        internal bool IsSetProcess() => this.Process.HasValue;

        /// <summary>
        /// Gets and sets the property SourceBuildInformation. 
        /// <para>
        /// If the version's source code was retrieved from CodeCommit, the location of the source
        /// code for the application version.
        /// </para>
        /// </summary>
        public SourceBuildInformation SourceBuildInformation { get; set; }

        /// <summary>
        /// Checks to see if the SourceBuildInformation property is set.
        /// </summary>
        internal bool IsSetSourceBuildInformation() => this.SourceBuildInformation != null;

        /// <summary>
        /// Gets and sets the property SourceBundle. 
        /// <para>
        /// The storage location of the application version's source bundle in Amazon S3.
        /// </para>
        /// </summary>
        public S3Location SourceBundle { get; set; }

        /// <summary>
        /// Checks to see if the SourceBundle property is set.
        /// </summary>
        internal bool IsSetSourceBundle() => this.SourceBundle != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The processing status of the application version. Reflects the state of the application
        /// version during its creation. Many of the values are only applicable if you specified
        /// <c>True</c> for the <c>Process</c> parameter of the <c>CreateApplicationVersion</c>
        /// action. The following list describes the possible values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Unprocessed</c> – Application version wasn't pre-processed or validated. Elastic
        /// Beanstalk will validate configuration files during deployment of the application version
        /// to an environment.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Processing</c> – Elastic Beanstalk is currently processing the application version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Building</c> – Application version is currently undergoing an CodeBuild build.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Processed</c> – Elastic Beanstalk was successfully pre-processed and validated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> – Either the CodeBuild build failed or configuration files didn't pass
        /// validation. This application version isn't usable.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApplicationVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// A unique identifier for the application version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
