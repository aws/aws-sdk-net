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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an application.
    /// </summary>
    public partial class ApplicationInfo
    {
        private string _applicationId;
        private string _applicationName;
        private ComputePlatform _computePlatform;
        private DateTime? _createTime;
        private string _gitHubAccountName;
        private bool? _linkedToGitHub;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// Gets and sets the property ComputePlatform. 
        /// <para>
        /// The destination platform type for deployment of the application (<c>Lambda</c> or
        /// <c>Server</c>).
        /// </para>
        /// </summary>
        public ComputePlatform ComputePlatform
        {
            get { return this._computePlatform; }
            set { this._computePlatform = value; }
        }

        // Check to see if ComputePlatform property is set
        internal bool IsSetComputePlatform()
        {
            return this._computePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the application was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime
        {
            get { return this._createTime; }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GitHubAccountName. 
        /// <para>
        /// The name for a connection to a GitHub account.
        /// </para>
        /// </summary>
        public string GitHubAccountName
        {
            get { return this._gitHubAccountName; }
            set { this._gitHubAccountName = value; }
        }

        // Check to see if GitHubAccountName property is set
        internal bool IsSetGitHubAccountName()
        {
            return this._gitHubAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property LinkedToGitHub. 
        /// <para>
        /// True if the user has authenticated with GitHub for the specified application. Otherwise,
        /// false.
        /// </para>
        /// </summary>
        public bool? LinkedToGitHub
        {
            get { return this._linkedToGitHub; }
            set { this._linkedToGitHub = value; }
        }

        // Check to see if LinkedToGitHub property is set
        internal bool IsSetLinkedToGitHub()
        {
            return this._linkedToGitHub.HasValue; 
        }

    }
}