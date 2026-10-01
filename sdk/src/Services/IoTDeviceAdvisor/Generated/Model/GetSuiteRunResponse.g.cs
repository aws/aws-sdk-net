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

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// This is the response object from the GetSuiteRun operation.
    /// </summary>
    public partial class GetSuiteRunResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Date (in Unix epoch time) when the test suite run ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorReason. 
        /// <para>
        /// Error reason for any test suite run failure.
        /// </para>
        /// </summary>
        public string ErrorReason { get; set; }

        /// <summary>
        /// Checks to see if the ErrorReason property is set.
        /// </summary>
        internal bool IsSetErrorReason() => this.ErrorReason != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Date (in Unix epoch time) when the test suite run started.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the test suite run.
        /// </para>
        /// </summary>
        public SuiteRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// Suite definition ID for the test suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string SuiteDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionId property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionId() => this.SuiteDefinitionId != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionVersion. 
        /// <para>
        /// Suite definition version for the test suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 255)]
        public string SuiteDefinitionVersion { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionVersion property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionVersion() => this.SuiteDefinitionVersion != null;

        /// <summary>
        /// Gets and sets the property SuiteRunArn. 
        /// <para>
        /// The ARN of the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SuiteRunArn { get; set; }

        /// <summary>
        /// Checks to see if the SuiteRunArn property is set.
        /// </summary>
        internal bool IsSetSuiteRunArn() => this.SuiteRunArn != null;

        /// <summary>
        /// Gets and sets the property SuiteRunConfiguration. 
        /// <para>
        /// Suite run configuration for the test suite run.
        /// </para>
        /// </summary>
        public SuiteRunConfiguration SuiteRunConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SuiteRunConfiguration property is set.
        /// </summary>
        internal bool IsSetSuiteRunConfiguration() => this.SuiteRunConfiguration != null;

        /// <summary>
        /// Gets and sets the property SuiteRunId. 
        /// <para>
        /// Suite run ID for the test suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string SuiteRunId { get; set; }

        /// <summary>
        /// Checks to see if the SuiteRunId property is set.
        /// </summary>
        internal bool IsSetSuiteRunId() => this.SuiteRunId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags attached to the suite run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TestResult. 
        /// <para>
        /// Test results for the test suite run.
        /// </para>
        /// </summary>
        public TestResult TestResult { get; set; }

        /// <summary>
        /// Checks to see if the TestResult property is set.
        /// </summary>
        internal bool IsSetTestResult() => this.TestResult != null;
    }
}
