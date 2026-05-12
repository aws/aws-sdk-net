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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeAutomationJob operation.
    /// Retrieves the status and details of a specified automation job, including its status
    /// and outputs.
    /// </summary>
    public partial class DescribeAutomationJobRequest : AmazonQuickSightRequest
    {
        private string _automationGroupId;
        private string _automationId;
        private string _awsAccountId;
        private bool? _includeInputPayload;
        private bool? _includeOutputPayload;
        private string _jobId;

        /// <summary>
        /// Gets and sets the property AutomationGroupId. 
        /// <para>
        /// The ID of the automation group that contains the automation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AutomationGroupId
        {
            get { return this._automationGroupId; }
            set { this._automationGroupId = value; }
        }

        // Check to see if AutomationGroupId property is set
        internal bool IsSetAutomationGroupId()
        {
            return this._automationGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property AutomationId. 
        /// <para>
        /// The ID of the automation that the job belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AutomationId
        {
            get { return this._automationId; }
            set { this._automationId = value; }
        }

        // Check to see if AutomationId property is set
        internal bool IsSetAutomationId()
        {
            return this._automationId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the automation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeInputPayload. 
        /// <para>
        /// A Boolean value that indicates whether to include the input payload in the response.
        /// If set to <c>true</c>, the input payload will be included. If set to <c>false</c>,
        /// the input payload will be returned as <c>null</c>.
        /// </para>
        /// </summary>
        public bool? IncludeInputPayload
        {
            get { return this._includeInputPayload; }
            set { this._includeInputPayload = value; }
        }

        // Check to see if IncludeInputPayload property is set
        internal bool IsSetIncludeInputPayload()
        {
            return this._includeInputPayload.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeOutputPayload. 
        /// <para>
        /// A Boolean value that indicates whether to include the output payload in the response.
        /// If set to <c>true</c>, the output payload will be included. If set to <c>false</c>,
        /// the output payload will be returned as <c>null</c>.
        /// </para>
        /// </summary>
        public bool? IncludeOutputPayload
        {
            get { return this._includeOutputPayload; }
            set { this._includeOutputPayload = value; }
        }

        // Check to see if IncludeOutputPayload property is set
        internal bool IsSetIncludeOutputPayload()
        {
            return this._includeOutputPayload.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The ID of the automation job to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}