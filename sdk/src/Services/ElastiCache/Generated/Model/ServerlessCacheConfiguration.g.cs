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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// The configuration settings for a specific serverless cache.
    /// </summary>
    public partial class ServerlessCacheConfiguration
    {
        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The engine that the serverless cache is configured with.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property MajorEngineVersion. 
        /// <para>
        /// The engine version number that the serverless cache is configured with.
        /// </para>
        /// </summary>
        public string MajorEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MajorEngineVersion property is set.
        /// </summary>
        internal bool IsSetMajorEngineVersion() => this.MajorEngineVersion != null;

        /// <summary>
        /// Gets and sets the property ServerlessCacheName. 
        /// <para>
        /// The identifier of a serverless cache.
        /// </para>
        /// </summary>
        public string ServerlessCacheName { get; set; }

        /// <summary>
        /// Checks to see if the ServerlessCacheName property is set.
        /// </summary>
        internal bool IsSetServerlessCacheName() => this.ServerlessCacheName != null;
    }
}
