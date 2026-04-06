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
    /// Container for the parameters to the StartAutomationJob operation.
    /// Starts a new job for a specified automation. The job runs the automation with the
    /// provided input payload.
    /// </summary>
    public partial class StartAutomationJobRequest : AmazonQuickSightRequest
    {
        private string _automationGroupId;
        private string _automationId;
        private string _awsAccountId;
        private string _inputPayload;

        /// <summary>
        /// Gets and sets the property AutomationGroupId. 
        /// <para>
        /// The ID of the automation group that contains the automation to run.
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
        /// The ID of the automation to run.
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
        /// The ID of the Amazon Web Services account that contains the automation.
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
        /// Gets and sets the property InputPayload. 
        /// <para>
        /// The input payload for the automation job, provided as a JSON string.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=7000000)]
        public string InputPayload
        {
            get { return this._inputPayload; }
            set { this._inputPayload = value; }
        }

        // Check to see if InputPayload property is set
        internal bool IsSetInputPayload()
        {
            return this._inputPayload != null;
        }

    }
}