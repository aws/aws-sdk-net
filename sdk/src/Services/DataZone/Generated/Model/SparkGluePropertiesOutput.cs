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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Spark Amazon Web Services Glue properties.
    /// </summary>
    public partial class SparkGluePropertiesOutput
    {
        private SparkGlueArgs _additionalArgs;
        private string _glueConnectionName;
        private string _glueVersion;
        private int? _idleTimeout;
        private string _javaVirtualEnv;
        private int? _numberOfWorkers;
        private string _pythonVirtualEnv;
        private string _workerType;

        /// <summary>
        /// Gets and sets the property AdditionalArgs. 
        /// <para>
        /// The additional args in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public SparkGlueArgs AdditionalArgs
        {
            get { return this._additionalArgs; }
            set { this._additionalArgs = value; }
        }

        // Check to see if AdditionalArgs property is set
        internal bool IsSetAdditionalArgs()
        {
            return this._additionalArgs != null;
        }

        /// <summary>
        /// Gets and sets the property GlueConnectionName. 
        /// <para>
        /// The Amazon Web Services Glue connection name in the Spark Amazon Web Services Glue
        /// properties. 
        /// </para>
        /// </summary>
        public string GlueConnectionName
        {
            get { return this._glueConnectionName; }
            set { this._glueConnectionName = value; }
        }

        // Check to see if GlueConnectionName property is set
        internal bool IsSetGlueConnectionName()
        {
            return this._glueConnectionName != null;
        }

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// The Amazon Web Services Glue version in the Spark Amazon Web Services Glue properties.
        /// 
        /// </para>
        /// </summary>
        public string GlueVersion
        {
            get { return this._glueVersion; }
            set { this._glueVersion = value; }
        }

        // Check to see if GlueVersion property is set
        internal bool IsSetGlueVersion()
        {
            return this._glueVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IdleTimeout. 
        /// <para>
        /// The idle timeout in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public int? IdleTimeout
        {
            get { return this._idleTimeout; }
            set { this._idleTimeout = value; }
        }

        // Check to see if IdleTimeout property is set
        internal bool IsSetIdleTimeout()
        {
            return this._idleTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JavaVirtualEnv. 
        /// <para>
        /// The Java virtual env in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public string JavaVirtualEnv
        {
            get { return this._javaVirtualEnv; }
            set { this._javaVirtualEnv = value; }
        }

        // Check to see if JavaVirtualEnv property is set
        internal bool IsSetJavaVirtualEnv()
        {
            return this._javaVirtualEnv != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public int? NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
            set { this._numberOfWorkers = value; }
        }

        // Check to see if NumberOfWorkers property is set
        internal bool IsSetNumberOfWorkers()
        {
            return this._numberOfWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PythonVirtualEnv. 
        /// <para>
        /// The Python virtual env in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public string PythonVirtualEnv
        {
            get { return this._pythonVirtualEnv; }
            set { this._pythonVirtualEnv = value; }
        }

        // Check to see if PythonVirtualEnv property is set
        internal bool IsSetPythonVirtualEnv()
        {
            return this._pythonVirtualEnv != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The worker type in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public string WorkerType
        {
            get { return this._workerType; }
            set { this._workerType = value; }
        }

        // Check to see if WorkerType property is set
        internal bool IsSetWorkerType()
        {
            return this._workerType != null;
        }

    }
}