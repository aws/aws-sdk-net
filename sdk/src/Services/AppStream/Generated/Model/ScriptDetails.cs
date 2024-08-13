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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the details of the script.
    /// </summary>
    public partial class ScriptDetails
    {
        private string _executableParameters;
        private string _executablePath;
        private S3Location _scriptS3Location;
        private int? _timeoutInSeconds;

        /// <summary>
        /// Gets and sets the property ExecutableParameters. 
        /// <para>
        /// The runtime parameters passed to the run path for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ExecutableParameters
        {
            get { return this._executableParameters; }
            set { this._executableParameters = value; }
        }

        // Check to see if ExecutableParameters property is set
        internal bool IsSetExecutableParameters()
        {
            return this._executableParameters != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutablePath. 
        /// <para>
        /// The run path for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string ExecutablePath
        {
            get { return this._executablePath; }
            set { this._executablePath = value; }
        }

        // Check to see if ExecutablePath property is set
        internal bool IsSetExecutablePath()
        {
            return this._executablePath != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptS3Location. 
        /// <para>
        /// The S3 object location for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location ScriptS3Location
        {
            get { return this._scriptS3Location; }
            set { this._scriptS3Location = value; }
        }

        // Check to see if ScriptS3Location property is set
        internal bool IsSetScriptS3Location()
        {
            return this._scriptS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The run timeout, in seconds, for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TimeoutInSeconds
        {
            get { return this._timeoutInSeconds; }
            set { this._timeoutInSeconds = value; }
        }

        // Check to see if TimeoutInSeconds property is set
        internal bool IsSetTimeoutInSeconds()
        {
            return this._timeoutInSeconds.HasValue; 
        }

    }
}