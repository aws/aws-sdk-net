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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The current status of the configuration recorder.
    /// 
    ///  
    /// <para>
    /// For a detailed status of recording events over time, add your Config events to CloudWatch
    /// metrics and use CloudWatch metrics.
    /// </para>
    /// </summary>
    public partial class ConfigurationRecorderStatus
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration recorder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property LastErrorCode. 
        /// <para>
        /// The latest error code from when the recorder last failed.
        /// </para>
        /// </summary>
        public string LastErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the LastErrorCode property is set.
        /// </summary>
        internal bool IsSetLastErrorCode() => this.LastErrorCode != null;

        /// <summary>
        /// Gets and sets the property LastErrorMessage. 
        /// <para>
        /// The latest error message from when the recorder last failed.
        /// </para>
        /// </summary>
        public string LastErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the LastErrorMessage property is set.
        /// </summary>
        internal bool IsSetLastErrorMessage() => this.LastErrorMessage != null;

        /// <summary>
        /// Gets and sets the property LastStartTime. 
        /// <para>
        /// The time the recorder was last started.
        /// </para>
        /// </summary>
        public DateTime? LastStartTime { get; set; }

        /// <summary>
        /// Checks to see if the LastStartTime property is set.
        /// </summary>
        internal bool IsSetLastStartTime() => this.LastStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastStatus. 
        /// <para>
        /// The status of the latest recording event processed by the recorder.
        /// </para>
        /// </summary>
        public RecorderStatus LastStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastStatus property is set.
        /// </summary>
        internal bool IsSetLastStatus() => this.LastStatus != null;

        /// <summary>
        /// Gets and sets the property LastStatusChangeTime. 
        /// <para>
        /// The time of the latest change in status of an recording event processed by the recorder.
        /// </para>
        /// </summary>
        public DateTime? LastStatusChangeTime { get; set; }

        /// <summary>
        /// Checks to see if the LastStatusChangeTime property is set.
        /// </summary>
        internal bool IsSetLastStatusChangeTime() => this.LastStatusChangeTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastStopTime. 
        /// <para>
        /// The time the recorder was last stopped.
        /// </para>
        /// </summary>
        public DateTime? LastStopTime { get; set; }

        /// <summary>
        /// Checks to see if the LastStopTime property is set.
        /// </summary>
        internal bool IsSetLastStopTime() => this.LastStopTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the configuration recorder.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Recording. 
        /// <para>
        /// Specifies whether or not the recorder is currently recording.
        /// </para>
        /// </summary>
        public bool? Recording { get; set; }

        /// <summary>
        /// Checks to see if the Recording property is set.
        /// </summary>
        internal bool IsSetRecording() => this.Recording.HasValue;

        /// <summary>
        /// Gets and sets the property ServicePrincipal. 
        /// <para>
        /// For service-linked configuration recorders, the service principal of the linked Amazon
        /// Web Services service.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ServicePrincipal { get; set; }

        /// <summary>
        /// Checks to see if the ServicePrincipal property is set.
        /// </summary>
        internal bool IsSetServicePrincipal() => this.ServicePrincipal != null;
    }
}
