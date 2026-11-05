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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains summary information about a test run.
    /// </summary>
    public partial class TestRunSummary
    {
        /// <summary>
        /// Gets and sets the property AccountTargeting. 
        /// <para>
        /// Indicates whether the test run targets resources in a single AWS account or across
        /// multiple accounts.
        /// </para>
        /// </summary>
        public AccountTargeting AccountTargeting { get; set; }

        /// <summary>
        /// Checks to see if the AccountTargeting property is set.
        /// </summary>
        internal bool IsSetAccountTargeting() => this.AccountTargeting != null;

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The timestamp when the test run ended.
        /// </para>
        /// </summary>
        public DateTime? EndedAt { get; set; }

        /// <summary>
        /// Checks to see if the EndedAt property is set.
        /// </summary>
        internal bool IsSetEndedAt() => this.EndedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// A human-readable reason for test run failure. Only present when the status is FAILED
        /// or ERROR.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service the test run belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the test run started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TestRunId. 
        /// <para>
        /// The unique identifier of the test run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string TestRunId { get; set; }

        /// <summary>
        /// Checks to see if the TestRunId property is set.
        /// </summary>
        internal bool IsSetTestRunId() => this.TestRunId != null;

        /// <summary>
        /// Gets and sets the property TestTemplateArn. 
        /// <para>
        /// The ARN of the test template the test run was based on.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string TestTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TestTemplateArn property is set.
        /// </summary>
        internal bool IsSetTestTemplateArn() => this.TestTemplateArn != null;
    }
}
