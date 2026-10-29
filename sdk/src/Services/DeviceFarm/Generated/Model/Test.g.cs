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
    /// Represents a condition that is evaluated.
    /// </summary>
    public partial class Test
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The test's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 32, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Counters. 
        /// <para>
        /// The test's result counters.
        /// </para>
        /// </summary>
        public Counters Counters { get; set; }

        /// <summary>
        /// Checks to see if the Counters property is set.
        /// </summary>
        internal bool IsSetCounters() => this.Counters != null;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// When the test was created.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceMinutes. 
        /// <para>
        /// Represents the total (metered or unmetered) minutes used by the test.
        /// </para>
        /// </summary>
        public DeviceMinutes DeviceMinutes { get; set; }

        /// <summary>
        /// Checks to see if the DeviceMinutes property is set.
        /// </summary>
        internal bool IsSetDeviceMinutes() => this.DeviceMinutes != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the test's result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16384)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The test's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The test's result.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PASSED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// WARNED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// FAILED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SKIPPED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ERRORED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPED
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecutionResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property Started. 
        /// <para>
        /// The test's start time.
        /// </para>
        /// </summary>
        public DateTime? Started { get; set; }

        /// <summary>
        /// Checks to see if the Started property is set.
        /// </summary>
        internal bool IsSetStarted() => this.Started.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The test's status.
        /// </para>
        ///  
        /// <para>
        /// Allowed values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PENDING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_CONCURRENCY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PENDING_DEVICE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PROCESSING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SCHEDULING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PREPARING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RUNNING
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// COMPLETED
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// STOPPING
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Stopped. 
        /// <para>
        /// The test's stop time.
        /// </para>
        /// </summary>
        public DateTime? Stopped { get; set; }

        /// <summary>
        /// Checks to see if the Stopped property is set.
        /// </summary>
        internal bool IsSetStopped() => this.Stopped.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The test's type.
        /// </para>
        ///  
        /// <para>
        /// Must be one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// BUILTIN_FUZZ
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_JUNIT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_JAVA_TESTNG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_PYTHON
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_NODE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_RUBY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_JUNIT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_JAVA_TESTNG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_PYTHON
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_NODE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// APPIUM_WEB_RUBY
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTRUMENTATION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// XCTEST_UI
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TestType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
