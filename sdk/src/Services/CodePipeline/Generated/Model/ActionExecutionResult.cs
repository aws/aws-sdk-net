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
    /// Execution result information, such as the external execution ID.
    /// </summary>
    public partial class ActionExecutionResult
    {
        private ErrorDetails _errorDetails;
        private string _externalExecutionId;
        private string _externalExecutionSummary;
        private string _externalExecutionUrl;
        private string _logStreamARN;

        /// <summary>
        /// Gets and sets the property ErrorDetails.
        /// </summary>
        public ErrorDetails ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalExecutionId. 
        /// <para>
        /// The action provider's external ID for the action execution.
        /// </para>
        /// </summary>
        public string ExternalExecutionId
        {
            get { return this._externalExecutionId; }
            set { this._externalExecutionId = value; }
        }

        // Check to see if ExternalExecutionId property is set
        internal bool IsSetExternalExecutionId()
        {
            return this._externalExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalExecutionSummary. 
        /// <para>
        /// The action provider's summary for the action execution.
        /// </para>
        /// </summary>
        public string ExternalExecutionSummary
        {
            get { return this._externalExecutionSummary; }
            set { this._externalExecutionSummary = value; }
        }

        // Check to see if ExternalExecutionSummary property is set
        internal bool IsSetExternalExecutionSummary()
        {
            return this._externalExecutionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalExecutionUrl. 
        /// <para>
        /// The deepest external link to the external resource (for example, a repository URL
        /// or deployment endpoint) that is used when running the action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ExternalExecutionUrl
        {
            get { return this._externalExecutionUrl; }
            set { this._externalExecutionUrl = value; }
        }

        // Check to see if ExternalExecutionUrl property is set
        internal bool IsSetExternalExecutionUrl()
        {
            return this._externalExecutionUrl != null;
        }

        /// <summary>
        /// Gets and sets the property LogStreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the log stream for the action compute.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string LogStreamARN
        {
            get { return this._logStreamARN; }
            set { this._logStreamARN = value; }
        }

        // Check to see if LogStreamARN property is set
        internal bool IsSetLogStreamARN()
        {
            return this._logStreamARN != null;
        }

    }
}