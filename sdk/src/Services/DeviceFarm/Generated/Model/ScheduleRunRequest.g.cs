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

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the ScheduleRun operation. Schedules a run.
    /// </summary>
    public partial class ScheduleRunRequest : AmazonDeviceFarmRequest
    {
        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The ARN of an application package to run tests against, created with <a>CreateUpload</a>.
        /// See <a>ListUploads</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string AppArn { get; set; }

        /// <summary>
        /// Checks to see if the AppArn property is set.
        /// </summary>
        internal bool IsSetAppArn() => this.AppArn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Information about the settings for the run to be scheduled.
        /// </para>
        /// </summary>
        public ScheduleRunConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property DevicePoolArn. 
        /// <para>
        /// The ARN of the device pool for the run to be scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string DevicePoolArn { get; set; }

        /// <summary>
        /// Checks to see if the DevicePoolArn property is set.
        /// </summary>
        internal bool IsSetDevicePoolArn() => this.DevicePoolArn != null;

        /// <summary>
        /// Gets and sets the property DeviceSelectionConfiguration. 
        /// <para>
        /// The filter criteria used to dynamically select a set of devices for a test run and
        /// the maximum number of devices to be included in the run.
        /// </para>
        ///  
        /// <para>
        /// Either <b> <c>devicePoolArn</c> </b> or <b> <c>deviceSelectionConfiguration</c> </b>
        /// is required in a request.
        /// </para>
        /// </summary>
        public DeviceSelectionConfiguration DeviceSelectionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DeviceSelectionConfiguration property is set.
        /// </summary>
        internal bool IsSetDeviceSelectionConfiguration() => this.DeviceSelectionConfiguration != null;

        /// <summary>
        /// Gets and sets the property ExecutionConfiguration. 
        /// <para>
        /// Specifies configuration information about a test run, such as the execution timeout
        /// (in minutes).
        /// </para>
        /// </summary>
        public ExecutionConfiguration ExecutionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionConfiguration property is set.
        /// </summary>
        internal bool IsSetExecutionConfiguration() => this.ExecutionConfiguration != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the run to be scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the project for the run to be scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 32, Max = 1011)]
        public string ProjectArn { get; set; }

        /// <summary>
        /// Checks to see if the ProjectArn property is set.
        /// </summary>
        internal bool IsSetProjectArn() => this.ProjectArn != null;

        /// <summary>
        /// Gets and sets the property Test. 
        /// <para>
        /// Information about the test for the run to be scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ScheduleRunTest Test { get; set; }

        /// <summary>
        /// Checks to see if the Test property is set.
        /// </summary>
        internal bool IsSetTest() => this.Test != null;
    }
}
