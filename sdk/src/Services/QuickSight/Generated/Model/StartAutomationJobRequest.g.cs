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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the StartAutomationJob operation. Starts a new job
    /// for a specified automation. The job runs the automation with the provided input payload.
    /// </summary>
    public partial class StartAutomationJobRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AutomationGroupId. 
        /// <para>
        /// The ID of the automation group that contains the automation to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AutomationGroupId { get; set; }

        /// <summary>
        /// Checks to see if the AutomationGroupId property is set.
        /// </summary>
        internal bool IsSetAutomationGroupId() => this.AutomationGroupId != null;

        /// <summary>
        /// Gets and sets the property AutomationId. 
        /// <para>
        /// The ID of the automation to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AutomationId { get; set; }

        /// <summary>
        /// Checks to see if the AutomationId property is set.
        /// </summary>
        internal bool IsSetAutomationId() => this.AutomationId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that contains the automation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property InputPayload. 
        /// <para>
        /// The input payload for the automation job, provided as a JSON string.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 7000000)]
        public string InputPayload { get; set; }

        /// <summary>
        /// Checks to see if the InputPayload property is set.
        /// </summary>
        internal bool IsSetInputPayload() => this.InputPayload != null;
    }
}
