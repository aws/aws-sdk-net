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
    /// Represents a test created for a service by configuring a test template.
    /// </summary>
    public partial class Test
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The fault actions the test runs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TestAction> Actions { get; set; } = AWSConfigs.InitializeCollections ? new List<TestAction>() : null;

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null && (this.Actions.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property LoggingConfiguration. 
        /// <para>
        /// The logging configuration for the test.
        /// </para>
        /// </summary>
        public LoggingConfiguration LoggingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LoggingConfiguration property is set.
        /// </summary>
        internal bool IsSetLoggingConfiguration() => this.LoggingConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the test.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameter values configured for the test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 20)]
        public Dictionary<string, List<string>> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, List<string>>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleName. 
        /// <para>
        /// The name of the IAM execution role used to run the test.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 576)]
        public string RoleName { get; set; }

        /// <summary>
        /// Checks to see if the RoleName property is set.
        /// </summary>
        internal bool IsSetRoleName() => this.RoleName != null;

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
        /// Gets and sets the property StopConditions. 
        /// <para>
        /// The stop conditions for the test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StopCondition> StopConditions { get; set; } = AWSConfigs.InitializeCollections ? new List<StopCondition>() : null;

        /// <summary>
        /// Checks to see if the StopConditions property is set.
        /// </summary>
        internal bool IsSetStopConditions() => this.StopConditions != null && (this.StopConditions.Count > 0 || !AWSConfigs.InitializeCollections);

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
