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
    /// Describes the properties of an application version.
    /// </summary>
    public partial class ApplicationVersionDescription
    {
        private string _applicationName;
        private string _applicationVersionArn;
        private string _buildArn;
        private DateTime? _dateCreated;
        private DateTime? _dateUpdated;
        private string _description;
        private SourceBuildInformation _sourceBuildInformation;
        private S3Location _sourceBundle;
        private ApplicationVersionStatus _status;
        private string _versionLabel;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ApplicationVersionDescription() { }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The name of the application to which the application version belongs.
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
        /// Gets and sets the property ApplicationVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the application version.
        /// </para>
        /// </summary>
        public string ApplicationVersionArn
        {
            get { return this._applicationVersionArn; }
            set { this._applicationVersionArn = value; }
        }

        // Check to see if ApplicationVersionArn property is set
        internal bool IsSetApplicationVersionArn()
        {
            return this._applicationVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property BuildArn. 
        /// <para>
        /// Reference to the artifact from the AWS CodeBuild build.
        /// </para>
        /// </summary>
        public string BuildArn
        {
            get { return this._buildArn; }
            set { this._buildArn = value; }
        }

        // Check to see if BuildArn property is set
        internal bool IsSetBuildArn()
        {
            return this._buildArn != null;
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The creation date of the application version.
        /// </para>
        /// </summary>
        public DateTime DateCreated
        {
            get { return this._dateCreated.GetValueOrDefault(); }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DateUpdated. 
        /// <para>
        /// The last modified date of the application version.
        /// </para>
        /// </summary>
        public DateTime DateUpdated
        {
            get { return this._dateUpdated.GetValueOrDefault(); }
            set { this._dateUpdated = value; }
        }

        // Check to see if DateUpdated property is set
        internal bool IsSetDateUpdated()
        {
            return this._dateUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the application version.
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
        /// Gets and sets the property SourceBuildInformation. 
        /// <para>
        /// If the version's source code was retrieved from AWS CodeCommit, the location of the
        /// source code for the application version.
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
        /// The storage location of the application version's source bundle in Amazon S3.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The processing status of the application version.
        /// </para>
        /// </summary>
        public ApplicationVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VersionLabel. 
        /// <para>
        /// A unique identifier for the application version.
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