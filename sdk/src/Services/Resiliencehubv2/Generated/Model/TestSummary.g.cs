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
    /// Contains summary information about a test.
    /// </summary>
    public partial class TestSummary
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the test was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service the test belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property SuccessfulTestRuns. 
        /// <para>
        /// The number of successful runs of the test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? SuccessfulTestRuns { get; set; }

        /// <summary>
        /// Checks to see if the SuccessfulTestRuns property is set.
        /// </summary>
        internal bool IsSetSuccessfulTestRuns() => this.SuccessfulTestRuns.HasValue;

        /// <summary>
        /// Gets and sets the property TestId. 
        /// <para>
        /// The unique identifier of the test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string TestId { get; set; }

        /// <summary>
        /// Checks to see if the TestId property is set.
        /// </summary>
        internal bool IsSetTestId() => this.TestId != null;

        /// <summary>
        /// Gets and sets the property TestTemplateArn. 
        /// <para>
        /// The ARN of the test template the test was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string TestTemplateArn { get; set; }

        /// <summary>
        /// Checks to see if the TestTemplateArn property is set.
        /// </summary>
        internal bool IsSetTestTemplateArn() => this.TestTemplateArn != null;

        /// <summary>
        /// Gets and sets the property TotalTestRuns. 
        /// <para>
        /// The total number of runs of the test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TotalTestRuns { get; set; }

        /// <summary>
        /// Checks to see if the TotalTestRuns property is set.
        /// </summary>
        internal bool IsSetTotalTestRuns() => this.TotalTestRuns.HasValue;
    }
}
