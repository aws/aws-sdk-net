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
    /// Represents a code review job, which is an execution instance of a code review. A code
    /// review job progresses through preflight, static analysis, and finalizing steps.
    /// </summary>
    public partial class CodeReviewJob
    {
        private CodeRemediationStrategy _codeRemediationStrategy;
        private string _codeReviewId;
        private string _codeReviewJobId;
        private DateTime? _createdAt;
        private List<DocumentInfo> _documents = AWSConfigs.InitializeCollections ? new List<DocumentInfo>() : null;
        private ErrorInformation _errorInformation;
        private List<ExecutionContext> _executionContext = AWSConfigs.InitializeCollections ? new List<ExecutionContext>() : null;
        private List<IntegratedRepository> _integratedRepositories = AWSConfigs.InitializeCollections ? new List<IntegratedRepository>() : null;
        private CloudWatchLog _logConfig;
        private string _overview;
        private string _serviceRole;
        private List<SourceCodeRepository> _sourceCode = AWSConfigs.InitializeCollections ? new List<SourceCodeRepository>() : null;
        private JobStatus _status;
        private List<Step> _steps = AWSConfigs.InitializeCollections ? new List<Step>() : null;
        private string _title;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property CodeRemediationStrategy. 
        /// <para>
        /// The code remediation strategy for the code review job.
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
        /// Gets and sets the property CodeReviewId. 
        /// <para>
        /// The unique identifier of the code review associated with the job.
        /// </para>
        /// </summary>
        public string CodeReviewId
        {
            get { return this._codeReviewId; }
            set { this._codeReviewId = value; }
        }

        // Check to see if CodeReviewId property is set
        internal bool IsSetCodeReviewId()
        {
            return this._codeReviewId != null;
        }

        /// <summary>
        /// Gets and sets the property CodeReviewJobId. 
        /// <para>
        /// The unique identifier of the code review job.
        /// </para>
        /// </summary>
        public string CodeReviewJobId
        {
            get { return this._codeReviewJobId; }
            set { this._codeReviewJobId = value; }
        }

        // Check to see if CodeReviewJobId property is set
        internal bool IsSetCodeReviewJobId()
        {
            return this._codeReviewJobId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the code review job was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Documents. 
        /// <para>
        /// The list of documents providing context for the code review job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DocumentInfo> Documents
        {
            get { return this._documents; }
            set { this._documents = value; }
        }

        // Check to see if Documents property is set
        internal bool IsSetDocuments()
        {
            return this._documents != null && (this._documents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ErrorInformation. 
        /// <para>
        /// Error information if the code review job encountered an error.
        /// </para>
        /// </summary>
        public ErrorInformation ErrorInformation
        {
            get { return this._errorInformation; }
            set { this._errorInformation = value; }
        }

        // Check to see if ErrorInformation property is set
        internal bool IsSetErrorInformation()
        {
            return this._errorInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionContext. 
        /// <para>
        /// The execution context messages for the code review job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExecutionContext> ExecutionContext
        {
            get { return this._executionContext; }
            set { this._executionContext = value; }
        }

        // Check to see if ExecutionContext property is set
        internal bool IsSetExecutionContext()
        {
            return this._executionContext != null && (this._executionContext.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IntegratedRepositories. 
        /// <para>
        /// The list of integrated repositories associated with the code review job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<IntegratedRepository> IntegratedRepositories
        {
            get { return this._integratedRepositories; }
            set { this._integratedRepositories = value; }
        }

        // Check to see if IntegratedRepositories property is set
        internal bool IsSetIntegratedRepositories()
        {
            return this._integratedRepositories != null && (this._integratedRepositories.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LogConfig. 
        /// <para>
        /// The CloudWatch Logs configuration for the code review job.
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
        /// Gets and sets the property Overview. 
        /// <para>
        /// An overview of the code review job results.
        /// </para>
        /// </summary>
        public string Overview
        {
            get { return this._overview; }
            set { this._overview = value; }
        }

        // Check to see if Overview property is set
        internal bool IsSetOverview()
        {
            return this._overview != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceRole. 
        /// <para>
        /// The IAM service role used for the code review job.
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
        /// Gets and sets the property SourceCode. 
        /// <para>
        /// The list of source code repositories analyzed during the code review job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SourceCodeRepository> SourceCode
        {
            get { return this._sourceCode; }
            set { this._sourceCode = value; }
        }

        // Check to see if SourceCode property is set
        internal bool IsSetSourceCode()
        {
            return this._sourceCode != null && (this._sourceCode.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code review job.
        /// </para>
        /// </summary>
        public JobStatus Status
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
        /// Gets and sets the property Steps. 
        /// <para>
        /// The list of steps in the code review job execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Step> Steps
        {
            get { return this._steps; }
            set { this._steps = value; }
        }

        // Check to see if Steps property is set
        internal bool IsSetSteps()
        {
            return this._steps != null && (this._steps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the code review job.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the code review job was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}