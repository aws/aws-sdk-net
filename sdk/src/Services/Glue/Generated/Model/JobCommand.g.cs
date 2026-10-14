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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies code that runs when a job is run.
    /// </summary>
    public partial class JobCommand
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job command. For an Apache Spark ETL job, this must be <c>glueetl</c>.
        /// For a Python shell job, it must be <c>pythonshell</c>. For an Apache Spark streaming
        /// ETL job, this must be <c>gluestreaming</c>. For a Ray job, this must be <c>glueray</c>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PythonVersion. 
        /// <para>
        /// The Python version being used to run a Python shell job. Allowed values are 2 or 3.
        /// </para>
        /// </summary>
        public string PythonVersion { get; set; }

        /// <summary>
        /// Checks to see if the PythonVersion property is set.
        /// </summary>
        internal bool IsSetPythonVersion() => this.PythonVersion != null;

        /// <summary>
        /// Gets and sets the property Runtime. 
        /// <para>
        /// In Ray jobs, Runtime is used to specify the versions of Ray, Python and additional
        /// libraries available in your environment. This field is not used in other job types.
        /// For supported runtime environment values, see <a href="https://docs.aws.amazon.com/glue/latest/dg/ray-jobs-section.html">Supported
        /// Ray runtime environments</a> in the Glue Developer Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Runtime { get; set; }

        /// <summary>
        /// Checks to see if the Runtime property is set.
        /// </summary>
        internal bool IsSetRuntime() => this.Runtime != null;

        /// <summary>
        /// Gets and sets the property ScriptLocation. 
        /// <para>
        /// Specifies the Amazon Simple Storage Service (Amazon S3) path to a script that runs
        /// a job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 400000)]
        public string ScriptLocation { get; set; }

        /// <summary>
        /// Checks to see if the ScriptLocation property is set.
        /// </summary>
        internal bool IsSetScriptLocation() => this.ScriptLocation != null;
    }
}
