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
    /// Represents a specific warning or failure.
    /// </summary>
    public partial class Problem
    {
        private Device _device;
        private ProblemDetail _job;
        private string _message;
        private ExecutionResult _result;
        private ProblemDetail _run;
        private ProblemDetail _suite;
        private ProblemDetail _test;

        /// <summary>
        /// Gets and sets the property Device. 
        /// <para>
        /// Information about the associated device.
        /// </para>
        /// </summary>
        public Device Device
        {
            get { return this._device; }
            set { this._device = value; }
        }

        // Check to see if Device property is set
        internal bool IsSetDevice()
        {
            return this._device != null;
        }

        /// <summary>
        /// Gets and sets the property Job. 
        /// <para>
        /// Information about the associated job.
        /// </para>
        /// </summary>
        public ProblemDetail Job
        {
            get { return this._job; }
            set { this._job = value; }
        }

        // Check to see if Job property is set
        internal bool IsSetJob()
        {
            return this._job != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message about the problem's result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16384)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

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
        public ExecutionResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property Run. 
        /// <para>
        /// Information about the associated run.
        /// </para>
        /// </summary>
        public ProblemDetail Run
        {
            get { return this._run; }
            set { this._run = value; }
        }

        // Check to see if Run property is set
        internal bool IsSetRun()
        {
            return this._run != null;
        }

        /// <summary>
        /// Gets and sets the property Suite. 
        /// <para>
        /// Information about the associated suite.
        /// </para>
        /// </summary>
        public ProblemDetail Suite
        {
            get { return this._suite; }
            set { this._suite = value; }
        }

        // Check to see if Suite property is set
        internal bool IsSetSuite()
        {
            return this._suite != null;
        }

        /// <summary>
        /// Gets and sets the property Test. 
        /// <para>
        /// Information about the associated test.
        /// </para>
        /// </summary>
        public ProblemDetail Test
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