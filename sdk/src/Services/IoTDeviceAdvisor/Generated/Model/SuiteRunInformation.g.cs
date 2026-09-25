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
    /// Information about the suite run.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">SuiteRunInformation</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class SuiteRunInformation
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date (in Unix epoch time) when the suite run was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property EndAt. 
        /// <para>
        /// Date (in Unix epoch time) when the suite run ended.
        /// </para>
        /// </summary>
        public DateTime? EndAt { get; set; }

        /// <summary>
        /// Checks to see if the EndAt property is set.
        /// </summary>
        internal bool IsSetEndAt() => this.EndAt.HasValue;

        /// <summary>
        /// Gets and sets the property Failed. 
        /// <para>
        /// Number of test cases that failed in the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public int? Failed { get; set; }

        /// <summary>
        /// Checks to see if the Failed property is set.
        /// </summary>
        internal bool IsSetFailed() => this.Failed.HasValue;

        /// <summary>
        /// Gets and sets the property Passed. 
        /// <para>
        /// Number of test cases that passed in the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public int? Passed { get; set; }

        /// <summary>
        /// Checks to see if the Passed property is set.
        /// </summary>
        internal bool IsSetPassed() => this.Passed.HasValue;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// Date (in Unix epoch time) when the suite run was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the suite run.
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
        /// Suite definition ID of the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string SuiteDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionId property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionId() => this.SuiteDefinitionId != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionName. 
        /// <para>
        /// Suite definition name of the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string SuiteDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionName property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionName() => this.SuiteDefinitionName != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionVersion. 
        /// <para>
        /// Suite definition version of the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 255)]
        public string SuiteDefinitionVersion { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionVersion property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionVersion() => this.SuiteDefinitionVersion != null;

        /// <summary>
        /// Gets and sets the property SuiteRunId. 
        /// <para>
        /// Suite run ID of the suite run.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 36)]
        public string SuiteRunId { get; set; }

        /// <summary>
        /// Checks to see if the SuiteRunId property is set.
        /// </summary>
        internal bool IsSetSuiteRunId() => this.SuiteRunId != null;
    }
}
