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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
    /// Container for the parameters to the ScheduleRun operation.
    /// Schedules a run.
    /// </summary>
    public partial class ScheduleRunRequest : AmazonDeviceFarmRequest
    {
        private string _appArn;
        private ScheduleRunConfiguration _configuration;
        private string _devicePoolArn;
        private DeviceSelectionConfiguration _deviceSelectionConfiguration;
        private ExecutionConfiguration _executionConfiguration;
        private string _name;
        private string _projectArn;
        private ScheduleRunTest _test;

        /// <summary>
        /// Gets and sets the property AppArn. 
        /// <para>
        /// The ARN of an application package to run tests against, created with <a>CreateUpload</a>.
        /// See <a>ListUploads</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string AppArn
        {
            get { return this._appArn; }
            set { this._appArn = value; }
        }

        // Check to see if AppArn property is set
        internal bool IsSetAppArn()
        {
            return this._appArn != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Information about the settings for the run to be scheduled.
        /// </para>
        /// </summary>
        public ScheduleRunConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property DevicePoolArn. 
        /// <para>
        /// The ARN of the device pool for the run to be scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=1011)]
        public string DevicePoolArn
        {
            get { return this._devicePoolArn; }
            set { this._devicePoolArn = value; }
        }

        // Check to see if DevicePoolArn property is set
        internal bool IsSetDevicePoolArn()
        {
            return this._devicePoolArn != null;
        }

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
        public DeviceSelectionConfiguration DeviceSelectionConfiguration
        {
            get { return this._deviceSelectionConfiguration; }
            set { this._deviceSelectionConfiguration = value; }
        }

        // Check to see if DeviceSelectionConfiguration property is set
        internal bool IsSetDeviceSelectionConfiguration()
        {
            return this._deviceSelectionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionConfiguration. 
        /// <para>
        /// Specifies configuration information about a test run, such as the execution timeout
        /// (in minutes).
        /// </para>
        /// </summary>
        public ExecutionConfiguration ExecutionConfiguration
        {
            get { return this._executionConfiguration; }
            set { this._executionConfiguration = value; }
        }

        // Check to see if ExecutionConfiguration property is set
        internal bool IsSetExecutionConfiguration()
        {
            return this._executionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the run to be scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectArn. 
        /// <para>
        /// The ARN of the project for the run to be scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32, Max=1011)]
        public string ProjectArn
        {
            get { return this._projectArn; }
            set { this._projectArn = value; }
        }

        // Check to see if ProjectArn property is set
        internal bool IsSetProjectArn()
        {
            return this._projectArn != null;
        }

        /// <summary>
        /// Gets and sets the property Test. 
        /// <para>
        /// Information about the test for the run to be scheduled.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScheduleRunTest Test
        {
            get { return this._test; }
            set { this._test = value; }
        }

        // Check to see if Test property is set
        internal bool IsSetTest()
        {
            return this._test != null;
        }

    }
}