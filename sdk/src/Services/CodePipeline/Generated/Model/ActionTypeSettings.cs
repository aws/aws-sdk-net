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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Returns information about the settings for an action type.
    /// </summary>
    public partial class ActionTypeSettings
    {
        private string _entityUrlTemplate;
        private string _executionUrlTemplate;
        private string _revisionUrlTemplate;
        private string _thirdPartyConfigurationUrl;

        /// <summary>
        /// Gets and sets the property EntityUrlTemplate. 
        /// <para>
        /// The URL returned to the AWS CodePipeline console that provides a deep link to the
        /// resources of the external system, such as the configuration page for an AWS CodeDeploy
        /// deployment group. This link is provided as part of the action display within the pipeline.
        /// </para>
        /// </summary>
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
        /// The URL returned to the AWS CodePipeline console that contains a link to the top-level
        /// landing page for the external system, such as console page for AWS CodeDeploy. This
        /// link is shown on the pipeline view page in the AWS CodePipeline console and provides
        /// a link to the execution entity of the external action.
        /// </para>
        /// </summary>
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
        /// The URL returned to the AWS CodePipeline console that contains a link to the page
        /// where customers can update or change the configuration of the external action.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property ThirdPartyConfigurationUrl. 
        /// <para>
        /// The URL of a sign-up page where users can sign up for an external service and perform
        /// initial configuration of the action provided by that service.
        /// </para>
        /// </summary>
        public string ThirdPartyConfigurationUrl
        {
            get { return this._thirdPartyConfigurationUrl; }
            set { this._thirdPartyConfigurationUrl = value; }
        }

        // Check to see if ThirdPartyConfigurationUrl property is set
        internal bool IsSetThirdPartyConfigurationUrl()
        {
            return this._thirdPartyConfigurationUrl != null;
        }

    }
}