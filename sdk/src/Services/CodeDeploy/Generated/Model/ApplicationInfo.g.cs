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

namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Information about an application.
    /// </summary>
    public partial class ApplicationInfo
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The application ID.
        /// </para>
        /// </summary>
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ApplicationName. 
        /// <para>
        /// The application name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationName property is set.
        /// </summary>
        internal bool IsSetApplicationName() => this.ApplicationName != null;

        /// <summary>
        /// Gets and sets the property ComputePlatform. 
        /// <para>
        /// The destination platform type for deployment of the application (<c>Lambda</c> or
        /// <c>Server</c>).
        /// </para>
        /// </summary>
        public ComputePlatform ComputePlatform { get; set; }

        /// <summary>
        /// Checks to see if the ComputePlatform property is set.
        /// </summary>
        internal bool IsSetComputePlatform() => this.ComputePlatform != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the application was created.
        /// </para>
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property GitHubAccountName. 
        /// <para>
        /// The name for a connection to a GitHub account.
        /// </para>
        /// </summary>
        public string GitHubAccountName { get; set; }

        /// <summary>
        /// Checks to see if the GitHubAccountName property is set.
        /// </summary>
        internal bool IsSetGitHubAccountName() => this.GitHubAccountName != null;

        /// <summary>
        /// Gets and sets the property LinkedToGitHub. 
        /// <para>
        /// True if the user has authenticated with GitHub for the specified application. Otherwise,
        /// false.
        /// </para>
        /// </summary>
        public bool? LinkedToGitHub { get; set; }

        /// <summary>
        /// Checks to see if the LinkedToGitHub property is set.
        /// </summary>
        internal bool IsSetLinkedToGitHub() => this.LinkedToGitHub.HasValue;
    }
}
