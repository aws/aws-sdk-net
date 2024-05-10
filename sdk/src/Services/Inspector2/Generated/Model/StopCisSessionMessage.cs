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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
        private string _benchmarkProfile;
        private string _benchmarkVersion;
        private ComputePlatform _computePlatform;
        private StopCisMessageProgress _progress;
        private string _reason;
        private StopCisSessionStatus _status;

        /// <summary>
        /// Gets and sets the property BenchmarkProfile. 
        /// <para>
        /// The message benchmark profile.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string BenchmarkProfile
        {
            get { return this._benchmarkProfile; }
            set { this._benchmarkProfile = value; }
        }

        // Check to see if BenchmarkProfile property is set
        internal bool IsSetBenchmarkProfile()
        {
            return this._benchmarkProfile != null;
        }

        /// <summary>
        /// Gets and sets the property BenchmarkVersion. 
        /// <para>
        /// The message benchmark version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8)]
        public string BenchmarkVersion
        {
            get { return this._benchmarkVersion; }
            set { this._benchmarkVersion = value; }
        }

        // Check to see if BenchmarkVersion property is set
        internal bool IsSetBenchmarkVersion()
        {
            return this._benchmarkVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ComputePlatform. 
        /// <para>
        /// The message compute platform.
        /// </para>
        /// </summary>
        public ComputePlatform ComputePlatform
        {
            get { return this._computePlatform; }
            set { this._computePlatform = value; }
        }

        // Check to see if ComputePlatform property is set
        internal bool IsSetComputePlatform()
        {
            return this._computePlatform != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StopCisMessageProgress Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StopCisSessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}