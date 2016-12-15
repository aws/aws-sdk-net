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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the CreateApplicationVersion operation.
    /// Creates an application version for the specified application. You can create an application
    /// version from a source bundle in Amazon S3, a commit in AWS CodeCommit, or the output
    /// of an AWS CodeBuild build as follows:
    /// 
    ///  
    /// <para>
    /// Specify a commit in an AWS CodeCommit repository with <code>SourceBuildInformation</code>.
    /// </para>
    ///  
    /// <para>
    /// Specify a build in an AWS CodeBuild with <code>SourceBuildInformation</code> and <code>BuildConfiguration</code>.
    /// </para>
    ///  
    /// <para>
    /// Specify a source bundle in S3 with <code>SourceBundle</code> 
    /// </para>
    ///  
    /// <para>
    /// Omit both <code>SourceBuildInformation</code> and <code>SourceBundle</code> to use
    /// the default sample application.
    /// </para>
    ///  <note> 
    /// <para>
    /// Once you create an application version with a specified Amazon S3 bucket and key location,
    /// you cannot change that Amazon S3 location. If you change the Amazon S3 location, you
    /// receive an exception when you attempt to launch an environment from the application
    /// version.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateApplicationVersionRequest : AmazonElasticBeanstalkRequest
    {
        private string _applicationName;
        private bool? _autoCreateApplication;
        private BuildConfiguration _buildConfiguration;
        private string _description;
        private bool? _process;
        private SourceBuildInformation _sourceBuildInformation;
        private S3Location _sourceBundle;
        private string _versionLabel;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CreateApplicationVersionRequest() { }

        /// <summary>
        /// Instantiates CreateApplicationVersionRequest with the parameterized properties
        /// </summary>
        /// <param name="applicationName"> The name of the application. If no application is found with this name, and <code>AutoCreateApplication</code> is <code>false</code>, returns an <code>InvalidParameterValue</code> error. </param>
        /// <param name="versionLabel">A label identifying this version. Constraint: Must be unique per application. If an application version already exists with this label for the specified application, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code> error. </param>
        public CreateApplicationVersionRequest(string applicationName, string versionLabel)
        {
            _applicationName = applicationName;
            _versionLabel = versionLabel;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        ///  The name of the application. If no application is found with this name, and <code>AutoCreateApplication</code>
        /// is <code>false</code>, returns an <code>InvalidParameterValue</code> error. 
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this._applicationName; }
            set { this._applicationName = value; }
        }

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this._applicationName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoCreateApplication. 
        /// <para>
        /// Set to <code>true</code> to create an application with the specified name if it doesn't
        /// already exist.
        /// </para>
        /// </summary>
        public bool AutoCreateApplication
        {
            get { return this._autoCreateApplication.GetValueOrDefault(); }
            set { this._autoCreateApplication = value; }
        }

        // Check to see if AutoCreateApplication property is set
        internal bool IsSetAutoCreateApplication()
        {
            return this._autoCreateApplication.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BuildConfiguration. 
        /// <para>
        /// Settings for an AWS CodeBuild build.
        /// </para>
        /// </summary>
        public BuildConfiguration BuildConfiguration
        {
            get { return this._buildConfiguration; }
            set { this._buildConfiguration = value; }
        }

        // Check to see if BuildConfiguration property is set
        internal bool IsSetBuildConfiguration()
        {
            return this._buildConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Describes this version.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Process. 
        /// <para>
        /// Preprocesses and validates the environment manifest and configuration files in the
        /// source bundle. Validating configuration files can identify issues prior to deploying
        /// the application version to an environment.
        /// </para>
        /// </summary>
        public bool Process
        {
            get { return this._process.GetValueOrDefault(); }
            set { this._process = value; }
        }

        // Check to see if Process property is set
        internal bool IsSetProcess()
        {
            return this._process.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceBuildInformation. 
        /// <para>
        /// Specify a commit in an AWS CodeCommit Git repository to use as the source code for
        /// the application version.
        /// </para>
        /// </summary>
        public SourceBuildInformation SourceBuildInformation
        {
            get { return this._sourceBuildInformation; }
            set { this._sourceBuildInformation = value; }
        }

        // Check to see if SourceBuildInformation property is set
        internal bool IsSetSourceBuildInformation()
        {
            return this._sourceBuildInformation != null;
        }

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
        ///  </note> 
        /// <para>
        /// Specify a source bundle in S3 or a commit in an AWS CodeCommit repository (with <code>SourceBuildInformation</code>),
        /// but not both. If neither <code>SourceBundle</code> nor <code>SourceBuildInformation</code>
        /// are provided, Elastic Beanstalk uses a sample application.
        /// </para>
        /// </summary>
        public S3Location SourceBundle
        {
            get { return this._sourceBundle; }
            set { this._sourceBundle = value; }
        }

        // Check to see if SourceBundle property is set
        internal bool IsSetSourceBundle()
        {
            return this._sourceBundle != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// A label identifying this version.
        /// </para>
        ///  
        /// <para>
        /// Constraint: Must be unique per application. If an application version already exists
        /// with this label for the specified application, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code>
        /// error. 
        /// </para>
        /// </summary>
        public string VersionLabel
        {
            get { return this._versionLabel; }
            set { this._versionLabel = value; }
        }

        // Check to see if VersionLabel property is set
        internal bool IsSetVersionLabel()
        {
            return this._versionLabel != null;
        }

    }
}