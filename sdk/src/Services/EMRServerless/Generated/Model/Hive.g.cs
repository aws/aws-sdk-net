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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// The configurations for the Hive job driver.
    /// </summary>
    public partial class Hive
    {
        /// <summary>
        /// Gets and sets the property InitQueryFile. 
        /// <para>
        /// The query file for the Hive job run.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string InitQueryFile { get; set; }

        /// <summary>
        /// Checks to see if the InitQueryFile property is set.
        /// </summary>
        internal bool IsSetInitQueryFile() => this.InitQueryFile != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// The parameters for the Hive job run.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 102400)]
        public string Parameters { get; set; }

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query for the Hive job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 10280)]
        public string Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;
    }
}
