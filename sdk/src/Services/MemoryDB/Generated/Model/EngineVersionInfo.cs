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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
        private string _engine;
        private string _enginePatchVersion;
        private string _engineVersion;
        private string _parameterGroupFamily;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the engine for which version information is provided.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EnginePatchVersion. 
        /// <para>
        /// The patched engine version
        /// </para>
        /// </summary>
        public string EnginePatchVersion
        {
            get { return this._enginePatchVersion; }
            set { this._enginePatchVersion = value; }
        }

        // Check to see if EnginePatchVersion property is set
        internal bool IsSetEnginePatchVersion()
        {
            return this._enginePatchVersion != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The engine version
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupFamily. 
        /// <para>
        /// Specifies the name of the parameter group family to which the engine default parameters
        /// apply.
        /// </para>
        /// </summary>
        public string ParameterGroupFamily
        {
            get { return this._parameterGroupFamily; }
            set { this._parameterGroupFamily = value; }
        }

        // Check to see if ParameterGroupFamily property is set
        internal bool IsSetParameterGroupFamily()
        {
            return this._parameterGroupFamily != null;
        }

    }
}