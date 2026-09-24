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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The Spark Amazon Web Services Glue properties.
    /// </summary>
    public partial class SparkGluePropertiesOutput
    {
        /// <summary>
        /// Gets and sets the property AdditionalArgs. 
        /// <para>
        /// The additional args in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public SparkGlueArgs AdditionalArgs { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalArgs property is set.
        /// </summary>
        internal bool IsSetAdditionalArgs() => this.AdditionalArgs != null;

        /// <summary>
        /// Gets and sets the property GlueConnectionName. 
        /// <para>
        /// The Amazon Web Services Glue connection name in the Spark Amazon Web Services Glue
        /// properties. 
        /// </para>
        /// </summary>
        public string GlueConnectionName { get; set; }

        /// <summary>
        /// Checks to see if the GlueConnectionName property is set.
        /// </summary>
        internal bool IsSetGlueConnectionName() => this.GlueConnectionName != null;

        /// <summary>
        /// Gets and sets the property GlueConnectionNames. 
        /// <para>
        /// The Amazon Web Services Glue connection names in the Spark Amazon Web Services Glue
        /// properties.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 16)]
        public List<string> GlueConnectionNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the GlueConnectionNames property is set.
        /// </summary>
        internal bool IsSetGlueConnectionNames() => this.GlueConnectionNames != null && (this.GlueConnectionNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// The Amazon Web Services Glue version in the Spark Amazon Web Services Glue properties.
        /// 
        /// </para>
        /// </summary>
        public string GlueVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlueVersion property is set.
        /// </summary>
        internal bool IsSetGlueVersion() => this.GlueVersion != null;

        /// <summary>
        /// Gets and sets the property IdleTimeout. 
        /// <para>
        /// The idle timeout in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// Checks to see if the IdleTimeout property is set.
        /// </summary>
        internal bool IsSetIdleTimeout() => this.IdleTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property JavaVirtualEnv. 
        /// <para>
        /// The Java virtual env in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public string JavaVirtualEnv { get; set; }

        /// <summary>
        /// Checks to see if the JavaVirtualEnv property is set.
        /// </summary>
        internal bool IsSetJavaVirtualEnv() => this.JavaVirtualEnv != null;

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property PythonVirtualEnv. 
        /// <para>
        /// The Python virtual env in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public string PythonVirtualEnv { get; set; }

        /// <summary>
        /// Checks to see if the PythonVirtualEnv property is set.
        /// </summary>
        internal bool IsSetPythonVirtualEnv() => this.PythonVirtualEnv != null;

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The worker type in the Spark Amazon Web Services Glue properties. 
        /// </para>
        /// </summary>
        public string WorkerType { get; set; }

        /// <summary>
        /// Checks to see if the WorkerType property is set.
        /// </summary>
        internal bool IsSetWorkerType() => this.WorkerType != null;
    }
}
