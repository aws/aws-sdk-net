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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// CPU utilization metrics for an instance.
    /// </summary>
    public partial class CPUUtilization
    {
        /// <summary>
        /// Gets and sets the property IOWait. 
        /// <para>
        /// Available on Linux environments only.
        /// </para>
        ///  
        /// <para>
        /// Percentage of time that the CPU has spent in the <c>I/O Wait</c> state over the last
        /// 10 seconds.
        /// </para>
        /// </summary>
        public double? IOWait { get; set; }

        /// <summary>
        /// Checks to see if the IOWait property is set.
        /// </summary>
        internal bool IsSetIOWait() => this.IOWait.HasValue;

        /// <summary>
        /// Gets and sets the property IRQ. 
        /// <para>
        /// Available on Linux environments only.
        /// </para>
        ///  
        /// <para>
        /// Percentage of time that the CPU has spent in the <c>IRQ</c> state over the last 10
        /// seconds.
        /// </para>
        /// </summary>
        public double? IRQ { get; set; }

        /// <summary>
        /// Checks to see if the IRQ property is set.
        /// </summary>
        internal bool IsSetIRQ() => this.IRQ.HasValue;

        /// <summary>
        /// Gets and sets the property Idle. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <c>Idle</c> state over the last 10
        /// seconds.
        /// </para>
        /// </summary>
        public double? Idle { get; set; }

        /// <summary>
        /// Checks to see if the Idle property is set.
        /// </summary>
        internal bool IsSetIdle() => this.Idle.HasValue;

        /// <summary>
        /// Gets and sets the property Nice. 
        /// <para>
        /// Available on Linux environments only.
        /// </para>
        ///  
        /// <para>
        /// Percentage of time that the CPU has spent in the <c>Nice</c> state over the last 10
        /// seconds.
        /// </para>
        /// </summary>
        public double? Nice { get; set; }

        /// <summary>
        /// Checks to see if the Nice property is set.
        /// </summary>
        internal bool IsSetNice() => this.Nice.HasValue;

        /// <summary>
        /// Gets and sets the property Privileged. 
        /// <para>
        /// Available on Windows environments only.
        /// </para>
        ///  
        /// <para>
        /// Percentage of time that the CPU has spent in the <c>Privileged</c> state over the
        /// last 10 seconds.
        /// </para>
        /// </summary>
        public double? Privileged { get; set; }

        /// <summary>
        /// Checks to see if the Privileged property is set.
        /// </summary>
        internal bool IsSetPrivileged() => this.Privileged.HasValue;

        /// <summary>
        /// Gets and sets the property SoftIRQ. 
        /// <para>
        /// Available on Linux environments only.
        /// </para>
        ///  
        /// <para>
        /// Percentage of time that the CPU has spent in the <c>SoftIRQ</c> state over the last
        /// 10 seconds.
        /// </para>
        /// </summary>
        public double? SoftIRQ { get; set; }

        /// <summary>
        /// Checks to see if the SoftIRQ property is set.
        /// </summary>
        internal bool IsSetSoftIRQ() => this.SoftIRQ.HasValue;

        /// <summary>
        /// Gets and sets the property System. 
        /// <para>
        /// Available on Linux environments only.
        /// </para>
        ///  
        /// <para>
        /// Percentage of time that the CPU has spent in the <c>System</c> state over the last
        /// 10 seconds.
        /// </para>
        /// </summary>
        public double? System { get; set; }

        /// <summary>
        /// Checks to see if the System property is set.
        /// </summary>
        internal bool IsSetSystem() => this.System.HasValue;

        /// <summary>
        /// Gets and sets the property User. 
        /// <para>
        /// Percentage of time that the CPU has spent in the <c>User</c> state over the last 10
        /// seconds.
        /// </para>
        /// </summary>
        public double? User { get; set; }

        /// <summary>
        /// Checks to see if the User property is set.
        /// </summary>
        internal bool IsSetUser() => this.User.HasValue;
    }
}
