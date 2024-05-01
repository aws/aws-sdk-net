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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The <c>SessionCommand</c> that runs the job.
    /// </summary>
    public partial class SessionCommand
    {
        private string _name;
        private string _pythonVersion;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the SessionCommand. Can be 'glueetl' or 'gluestreaming'.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Specifies the Python version. The Python version indicates the version supported for
        /// jobs of type Spark.
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

    }
}