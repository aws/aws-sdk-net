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
    /// Represents a specific warning or failure.
    /// </summary>
    public partial class Problem
    {
        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// Information about the associated device.
        /// </para>
        /// </summary>
        public Device Device { get; set; }

        /// <summary>
        /// Checks to see if the Device property is set.
        /// </summary>
        internal bool IsSetDevice() => this.Device != null;

        /// <summary>
        /// Gets and sets the property Job. 
        /// <para>
        /// Information about the associated job.
        /// </para>
        /// </summary>
        public ProblemDetail Job { get; set; }

        /// <summary>
        /// Checks to see if the Job property is set.
        /// </summary>
        internal bool IsSetJob() => this.Job != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the problem's result.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16384)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The problem's result.
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
        /// Gets and sets the property Run. 
        /// <para>
        /// Information about the associated run.
        /// </para>
        /// </summary>
        public ProblemDetail Run { get; set; }

        /// <summary>
        /// Checks to see if the Run property is set.
        /// </summary>
        internal bool IsSetRun() => this.Run != null;

        /// <summary>
        /// Gets and sets the property Suite. 
        /// <para>
        /// Information about the associated suite.
        /// </para>
        /// </summary>
        public ProblemDetail Suite { get; set; }

        /// <summary>
        /// Checks to see if the Suite property is set.
        /// </summary>
        internal bool IsSetSuite() => this.Suite != null;

        /// <summary>
        /// Gets and sets the property Test. 
        /// <para>
        /// Information about the associated test.
        /// </para>
        /// </summary>
        public ProblemDetail Test { get; set; }

        /// <summary>
        /// Checks to see if the Test property is set.
        /// </summary>
        internal bool IsSetTest() => this.Test != null;
    }
}
