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

namespace Amazon.Deadline.Model
{
    /// <summary>
    /// The data types for the task parameters.
    /// </summary>
    public partial class TaskParameterValue
    {
        /// <summary>
        /// Gets and sets the property ChunkInt. 
        /// <para>
        /// A range (for example 1-10) or selection of specific (for example 1,3,7,8,10) integers
        /// represented as a string.
        /// </para>
        /// </summary>
        public string ChunkInt { get; set; }

        /// <summary>
        /// Checks to see if the ChunkInt property is set.
        /// </summary>
        internal bool IsSetChunkInt() => this.ChunkInt != null;

        /// <summary>
        /// Gets and sets the property Float. 
        /// <para>
        /// A double precision IEEE-754 floating point number represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 26)]
        public string Float { get; set; }

        /// <summary>
        /// Checks to see if the Float property is set.
        /// </summary>
        internal bool IsSetFloat() => this.Float != null;

        /// <summary>
        /// Gets and sets the property Int. 
        /// <para>
        /// A signed integer represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public string Int { get; set; }

        /// <summary>
        /// Checks to see if the Int property is set.
        /// </summary>
        internal bool IsSetInt() => this.Int != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// A file system path represented as a string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property String. 
        /// <para>
        /// A UTF-8 string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string String { get; set; }

        /// <summary>
        /// Checks to see if the String property is set.
        /// </summary>
        internal bool IsSetString() => this.String != null;
    }
}
