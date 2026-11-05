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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Describes the details of the script.
    /// </summary>
    public partial class ScriptDetails
    {
        /// <summary>
        /// Gets and sets the property ExecutableParameters. 
        /// <para>
        /// The runtime parameters passed to the run path for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ExecutableParameters { get; set; }

        /// <summary>
        /// Checks to see if the ExecutableParameters property is set.
        /// </summary>
        internal bool IsSetExecutableParameters() => this.ExecutableParameters != null;

        /// <summary>
        /// Gets and sets the property ExecutablePath. 
        /// <para>
        /// The run path for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string ExecutablePath { get; set; }

        /// <summary>
        /// Checks to see if the ExecutablePath property is set.
        /// </summary>
        internal bool IsSetExecutablePath() => this.ExecutablePath != null;

        /// <summary>
        /// Gets and sets the property ScriptS3Location. 
        /// <para>
        /// The S3 object location for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public S3Location ScriptS3Location { get; set; }

        /// <summary>
        /// Checks to see if the ScriptS3Location property is set.
        /// </summary>
        internal bool IsSetScriptS3Location() => this.ScriptS3Location != null;

        /// <summary>
        /// Gets and sets the property TimeoutInSeconds. 
        /// <para>
        /// The run timeout, in seconds, for the script.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? TimeoutInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the TimeoutInSeconds property is set.
        /// </summary>
        internal bool IsSetTimeoutInSeconds() => this.TimeoutInSeconds.HasValue;
    }
}
