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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The stop CIS session message.
    /// </summary>
    public partial class StopCisSessionMessage
    {
        /// <summary>
        /// Gets and sets the property BenchmarkProfile. 
        /// <para>
        /// The message benchmark profile.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 128)]
        public string BenchmarkProfile { get; set; }

        /// <summary>
        /// Checks to see if the BenchmarkProfile property is set.
        /// </summary>
        internal bool IsSetBenchmarkProfile() => this.BenchmarkProfile != null;

        /// <summary>
        /// Gets and sets the property BenchmarkVersion. 
        /// <para>
        /// The message benchmark version.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 8)]
        public string BenchmarkVersion { get; set; }

        /// <summary>
        /// Checks to see if the BenchmarkVersion property is set.
        /// </summary>
        internal bool IsSetBenchmarkVersion() => this.BenchmarkVersion != null;

        /// <summary>
        /// Gets and sets the property ComputePlatform. 
        /// <para>
        /// The message compute platform.
        /// </para>
        /// </summary>
        public ComputePlatform ComputePlatform { get; set; }

        /// <summary>
        /// Checks to see if the ComputePlatform property is set.
        /// </summary>
        internal bool IsSetComputePlatform() => this.ComputePlatform != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StopCisMessageProgress Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the message.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StopCisSessionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
