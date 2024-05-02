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
    /// The details of the actions taken and results produced on an artifact as it passes
    /// through stages in the pipeline.
    /// </summary>
    public partial class ExecutionDetails
    {
        private string _externalExecutionId;
        private int? _percentComplete;
        private string _summary;

        /// <summary>
        /// Gets and sets the property ExternalExecutionId. 
        /// <para>
        /// The system-generated unique ID of this action used to identify this job worker in
        /// any external systems, such as CodeDeploy.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1500)]
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
        /// Gets and sets the property PercentComplete. 
        /// <para>
        /// The percentage of work completed on the action, represented on a scale of 0 to 100
        /// percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? PercentComplete
        {
            get { return this._percentComplete; }
            set { this._percentComplete = value; }
        }

        // Check to see if PercentComplete property is set
        internal bool IsSetPercentComplete()
        {
            return this._percentComplete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Summary. 
        /// <para>
        /// The summary of the current status of the actions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}