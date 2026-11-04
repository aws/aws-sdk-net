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
    /// Container for the parameters to the CreateApplicationVersion operation. Creates an
    /// application version for the specified application. You can create an application version
    /// from a source bundle in Amazon S3, a commit in CodeCommit, or the output of an CodeBuild
    /// build as follows: <para> Specify a commit in an CodeCommit repository with <c>SourceBuildInformation</c>.
    /// </para> <para> Specify a build in an CodeBuild with <c>SourceBuildInformation</c>
    /// and <c>BuildConfiguration</c>. </para> <para> Specify a source bundle in Amazon S3
    /// with <c>SourceBundle</c> </para> <para> Omit both <c>SourceBuildInformation</c> and
    /// <c>SourceBundle</c> to use the default sample application. </para> <note> <para> After
    /// you create an application version with a specified Amazon S3 bucket and key location,
    /// you can't change that Amazon S3 location. If you change the Amazon S3 location, you
    /// receive an exception when you attempt to launch an environment from the application
    /// version. </para> </note>
    /// </summary>
    public partial class CreateApplicationVersionRequest : AmazonElasticBeanstalkRequest
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CreateApplicationVersionRequest() { }

        /// <summary>
        /// Instantiates CreateApplicationVersionRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName"> The name of the application. If no application is found with this name, and <c>AutoCreateApplication</c> is <c>false</c>, returns an  <c>InvalidParameterValue</c> error. </param>
        /// <param name="versionLabel">A label identifying this version.   Constraint: Must be unique per application. If an application version already exists with this label for the specified application, Elastic Beanstalk returns   an <c>InvalidParameterValue</c> error. </param>
        public CreateApplicationVersionRequest(string applicationName, string versionLabel)
        {
            this.ApplicationName = applicationName;
            this.VersionLabel = versionLabel;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///  The name of the application. If no application is found with this name, and <c>AutoCreateApplication</c>
        /// is <c>false</c>, returns an <c>InvalidParameterValue</c> error. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property AutoCreateApplication. 
        /// <para>
        /// Set to <c>true</c> to create an application with the specified name if it doesn't
        /// already exist.
        /// </para>
        /// </summary>
        public bool? AutoCreateApplication { get; set; }

        /// <summary>
        /// Checks to see if the AutoCreateApplication property is set.
        /// </summary>
        internal bool IsSetAutoCreateApplication() => this.AutoCreateApplication.HasValue;

        /// <summary>
        /// Gets and sets the property BuildConfiguration. 
        /// <para>
        /// Settings for an CodeBuild build.
        /// </para>
        ///  
        /// <para>
        /// Don't specify <c>BuildConfiguration</c> together with <c>ImageConfiguration</c>, which
        /// configures a container image build instead.
        /// </para>
        /// </summary>
        public BuildConfiguration BuildConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the BuildConfiguration property is set.
        /// </summary>
        internal bool IsSetBuildConfiguration() => this.BuildConfiguration != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of this application version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ImageConfiguration. 
        /// <para>
        /// The source of the container image for this application version. You can specify an
        /// image that you built and pushed to a container registry yourself, or settings for
        /// Elastic Beanstalk to build one from your source bundle. Specify exactly one of the
        /// <c>Source</c> and <c>Build</c> members.
        /// </para>
        ///  
        /// <para>
        /// Don't specify <c>ImageConfiguration</c> together with <c>BuildConfiguration</c>, which
        /// configures an CodeBuild build instead.
        /// </para>
        /// </summary>
        public ImageConfiguration ImageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfiguration property is set.
        /// </summary>
        internal bool IsSetImageConfiguration() => this.ImageConfiguration != null;

        /// <summary>
        /// Gets and sets the property Process. 
        /// <para>
        /// Pre-processes and validates the environment manifest (<c>env.yaml</c>) and configuration
        /// files (<c>*.config</c> files in the <c>.ebextensions</c> folder) in the source bundle.
        /// Validating configuration files can identify issues prior to deploying the application
        /// version to an environment.
        /// </para>
        ///  
        /// <para>
        /// You must turn processing on for application versions that you create using CodeBuild
        /// or CodeCommit. For application versions built from a source bundle in Amazon S3, processing
        /// is optional.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Process</c> option validates Elastic Beanstalk configuration files. It doesn't
        /// validate your application's configuration files, like proxy server or Docker configuration.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Process { get; set; }

        /// <summary>
        /// Checks to see if the Process property is set.
        /// </summary>
        internal bool IsSetProcess() => this.Process.HasValue;

        /// <summary>
        /// Gets and sets the property SourceBuildInformation. 
        /// <para>
        /// Specify a commit in an CodeCommit Git repository to use as the source code for the
        /// application version.
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
        /// The Amazon S3 bucket and key that identify the location of the source bundle for this
        /// version.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon S3 bucket must be in the same region as the environment.
        /// </para>
        ///  
        /// <para>
        /// Unless you're specifying a source bundle in the bucket that Elastic Beanstalk manages
        /// in your account, you must assign a custom policy to your user, and grant <c>Allow</c>
        /// permission to the <c>s3:Get*</c> actions on your S3 object resource, for example,
        /// <c>arn:aws:s3:::your-bucket/your-source-bundle-object</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Specify a source bundle in Amazon S3 or a commit in an CodeCommit repository (with
        /// <c>SourceBuildInformation</c>), but not both. If neither <c>SourceBundle</c> nor <c>SourceBuildInformation</c>
        /// are provided, Elastic Beanstalk uses a sample application.
        /// </para>
        /// </summary>
        public S3Location SourceBundle { get; set; }

        /// <summary>
        /// Checks to see if the SourceBundle property is set.
        /// </summary>
        internal bool IsSetSourceBundle() => this.SourceBundle != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies the tags applied to the application version.
        /// </para>
        ///  
        /// <para>
        /// Elastic Beanstalk applies these tags only to the application version. Environments
        /// that use the application version don't inherit the tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// A label identifying this version.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Must be unique per application. If an application version already exists
        /// with this label for the specified application, Elastic Beanstalk returns an <c>InvalidParameterValue</c>
        /// error. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string VersionLabel { get; set; }

        /// <summary>
        /// Checks to see if the VersionLabel property is set.
        /// </summary>
        internal bool IsSetVersionLabel() => this.VersionLabel != null;
    }
}
