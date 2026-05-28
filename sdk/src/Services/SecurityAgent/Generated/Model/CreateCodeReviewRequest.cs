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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCodeReview operation.
    /// Creates a new code review configuration in an agent space. A code review defines the
    /// parameters for automated security-focused code analysis.
    /// </summary>
    public partial class CreateCodeReviewRequest : AmazonSecurityAgentRequest
    {
        private string _agentSpaceId;
        private Assets _assets;
        private CodeRemediationStrategy _codeRemediationStrategy;
        private CloudWatchLog _logConfig;
        private string _serviceRole;
        private string _title;

        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space to create the code review in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AgentSpaceId
        {
            get { return this._agentSpaceId; }
            set { this._agentSpaceId = value; }
        }

        // Check to see if AgentSpaceId property is set
        internal bool IsSetAgentSpaceId()
        {
            return this._agentSpaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Assets. 
        /// <para>
        /// The assets to include in the code review, such as documents and source code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Assets Assets
        {
            get { return this._assets; }
            set { this._assets = value; }
        }

        // Check to see if Assets property is set
        internal bool IsSetAssets()
        {
            return this._assets != null;
        }

        /// <summary>
        /// Gets and sets the property CodeRemediationStrategy. 
        /// <para>
        /// The code remediation strategy for the code review. Valid values are AUTOMATIC and
        /// DISABLED.
        /// </para>
        /// </summary>
        public CodeRemediationStrategy CodeRemediationStrategy
        {
            get { return this._codeRemediationStrategy; }
            set { this._codeRemediationStrategy = value; }
        }

        // Check to see if CodeRemediationStrategy property is set
        internal bool IsSetCodeRemediationStrategy()
        {
            return this._codeRemediationStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The CloudWatch Logs configuration for the code review.
        /// </para>
        /// </summary>
        public CloudWatchLog LogConfig
        {
            get { return this._logConfig; }
            set { this._logConfig = value; }
        }

        // Check to see if LogConfig property is set
        internal bool IsSetLogConfig()
        {
            return this._logConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM service role to use for the code review.
        /// </para>
        /// </summary>
        public string ServiceRole
        {
            get { return this._serviceRole; }
            set { this._serviceRole = value; }
        }

        // Check to see if ServiceRole property is set
        internal bool IsSetServiceRole()
        {
            return this._serviceRole != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the code review.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}