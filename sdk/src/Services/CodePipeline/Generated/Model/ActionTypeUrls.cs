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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Returns information about URLs for web pages that display to customers as links on
    /// the pipeline view, such as an external configuration page for the action type.
    /// </summary>
    public partial class ActionTypeUrls
    {
        private string _configurationUrl;
        private string _entityUrlTemplate;
        private string _executionUrlTemplate;
        private string _revisionUrlTemplate;

        /// <summary>
        /// Gets and sets the property ConfigurationUrl. 
        /// <para>
        /// The URL returned to the CodePipeline console that contains a link to the page where
        /// customers can configure the external action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ConfigurationUrl
        {
            get { return this._configurationUrl; }
            set { this._configurationUrl = value; }
        }

        // Check to see if ConfigurationUrl property is set
        internal bool IsSetConfigurationUrl()
        {
            return this._configurationUrl != null;
        }

        /// <summary>
        /// Gets and sets the property EntityUrlTemplate. 
        /// <para>
        /// The URL returned to the CodePipeline console that provides a deep link to the resources
        /// of the external system, such as a status page. This link is provided as part of the
        /// action display in the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string EntityUrlTemplate
        {
            get { return this._entityUrlTemplate; }
            set { this._entityUrlTemplate = value; }
        }

        // Check to see if EntityUrlTemplate property is set
        internal bool IsSetEntityUrlTemplate()
        {
            return this._entityUrlTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionUrlTemplate. 
        /// <para>
        /// The link to an execution page for the action type in progress. For example, for a
        /// CodeDeploy action, this link is shown on the pipeline view page in the CodePipeline
        /// console, and it links to a CodeDeploy status page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExecutionUrlTemplate
        {
            get { return this._executionUrlTemplate; }
            set { this._executionUrlTemplate = value; }
        }

        // Check to see if ExecutionUrlTemplate property is set
        internal bool IsSetExecutionUrlTemplate()
        {
            return this._executionUrlTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionUrlTemplate. 
        /// <para>
        /// The URL returned to the CodePipeline console that contains a link to the page where
        /// customers can update or change the configuration of the external action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RevisionUrlTemplate
        {
            get { return this._revisionUrlTemplate; }
            set { this._revisionUrlTemplate = value; }
        }

        // Check to see if RevisionUrlTemplate property is set
        internal bool IsSetRevisionUrlTemplate()
        {
            return this._revisionUrlTemplate != null;
        }

    }
}