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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// The job driver for job type.
    /// </summary>
    public partial class SparkSqlJobDriver
    {
        /// <summary>
        /// Gets and sets the property EntryPoint. 
        /// <para>
        /// The SQL file to be executed.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string EntryPoint { get; set; }

        /// <summary>
        /// Checks to see if the EntryPoint property is set.
        /// </summary>
        internal bool IsSetEntryPoint() => this.EntryPoint != null;

        /// <summary>
        /// Gets and sets the property SparkSqlParameters. 
        /// <para>
        /// The Spark parameters to be included in the Spark SQL command.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 102400)]
        public string SparkSqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the SparkSqlParameters property is set.
        /// </summary>
        internal bool IsSetSparkSqlParameters() => this.SparkSqlParameters != null;
    }
}
