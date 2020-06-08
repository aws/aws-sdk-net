/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies code executed when a job is run.
    /// </summary>
    public partial class JobCommand
    {
        private string _name;
        private string _pythonVersion;
        private string _scriptLocation;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job command. For an Apache Spark ETL job, this must be <code>glueetl</code>.
        /// For a Python shell job, it must be <code>pythonshell</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PythonVersion. 
        /// <para>
        /// The Python version being used to execute a Python shell job. Allowed values are 2
        /// or 3.
        /// </para>
        /// </summary>
        public string PythonVersion
        {
            get { return this._pythonVersion; }
            set { this._pythonVersion = value; }
        }

        // Check to see if PythonVersion property is set
        internal bool IsSetPythonVersion()
        {
            return this._pythonVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ScriptLocation. 
        /// <para>
        /// Specifies the Amazon Simple Storage Service (Amazon S3) path to a script that executes
        /// a job.
        /// </para>
        /// </summary>
        public string ScriptLocation
        {
            get { return this._scriptLocation; }
            set { this._scriptLocation = value; }
        }

        // Check to see if ScriptLocation property is set
        internal bool IsSetScriptLocation()
        {
            return this._scriptLocation != null;
        }

    }
}