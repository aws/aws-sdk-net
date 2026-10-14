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

namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Provides details of the Redis OSS engine version
    /// </summary>
    public partial class EngineVersionInfo
    {
        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the engine for which version information is provided.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EnginePatchVersion. 
        /// <para>
        /// The patched engine version
        /// </para>
        /// </summary>
        public string EnginePatchVersion { get; set; }

        /// <summary>
        /// Checks to see if the EnginePatchVersion property is set.
        /// </summary>
        internal bool IsSetEnginePatchVersion() => this.EnginePatchVersion != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property ParameterGroupFamily. 
        /// <para>
        /// Specifies the name of the parameter group family to which the engine default parameters
        /// apply.
        /// </para>
        /// </summary>
        public string ParameterGroupFamily { get; set; }

        /// <summary>
        /// Checks to see if the ParameterGroupFamily property is set.
        /// </summary>
        internal bool IsSetParameterGroupFamily() => this.ParameterGroupFamily != null;
    }
}
