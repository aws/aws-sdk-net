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
    /// Creates an application version for the specified application.
    /// 
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
        /// Determines how the system behaves if the specified application for this version does
        /// not already exist:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>true</code> : Automatically creates the specified application for this release
        /// if it does not already exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>false</code> : Throws an <code>InvalidParameterValue</code> if the specified
        /// application for this release does not already exist.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  Default: <code>false</code> 
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: <code>true</code> | <code>false</code> 
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
        ///  
        /// <para>
        ///  If data found at the Amazon S3 location exceeds the maximum allowed source bundle
        /// size, AWS Elastic Beanstalk returns an <code>InvalidParameterValue</code> error. The
        /// maximum size allowed is 512 MB. 
        /// </para>
        ///  
        /// <para>
        /// Default: If not specified, AWS Elastic Beanstalk uses a sample application. If only
        /// partially specified (for example, a bucket is provided but not the key) or if no data
        /// is found at the Amazon S3 location, AWS Elastic Beanstalk returns an <code>InvalidParameterCombination</code>
        /// error. 
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