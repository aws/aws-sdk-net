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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProject operation.
    /// Updates the description of an existing project.
    /// 
    ///  
    /// <para>
    /// To create a new project, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_CreateProject.html">CreateProject</a>.
    /// </para>
    ///  
    /// <para>
    /// Don't use this operation to update the data storage options of a project. Instead,
    /// use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateProjectDataDelivery.html">UpdateProjectDataDelivery</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Don't use this operation to update the tags of a project. Instead, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_TagResource.html">TagResource</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class UpdateProjectRequest : AmazonCloudWatchEvidentlyRequest
    {
        private ProjectAppConfigResourceConfig _appConfigResource;
        private string _description;
        private string _project;

        /// <summary>
        /// Gets and sets the property AppConfigResource. 
        /// <para>
        /// Use this parameter if the project will use client-side evaluation powered by AppConfig.
        /// Client-side evaluation allows your application to assign variations to user sessions
        /// locally instead of by calling the <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_EvaluateFeature.html">EvaluateFeature</a>
        /// operation. This mitigates the latency and availability risks that come with an API
        /// call. allows you to
        /// </para>
        ///  
        /// <para>
        /// This parameter is a structure that contains information about the AppConfig application
        /// that will be used for client-side evaluation.
        /// </para>
        /// </summary>
        public ProjectAppConfigResourceConfig AppConfigResource
        {
            get { return this._appConfigResource; }
            set { this._appConfigResource = value; }
        }

        // Check to see if AppConfigResource property is set
        internal bool IsSetAppConfigResource()
        {
            return this._appConfigResource != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=160)]
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
        /// Gets and sets the property Project. 
        /// <para>
        /// The name or ARN of the project to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

    }
}