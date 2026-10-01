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
    /// The driver that the job runs on.
    /// </summary>
    public partial class JobDriver
    {
        /// <summary>
        /// Gets and sets the property Hive. 
        /// <para>
        /// The job driver parameters specified for Hive.
        /// </para>
        /// </summary>
        public Hive Hive { get; set; }

        /// <summary>
        /// Checks to see if the Hive property is set.
        /// </summary>
        internal bool IsSetHive() => this.Hive != null;

        /// <summary>
        /// Gets and sets the property SparkSubmit. 
        /// <para>
        /// The job driver parameters specified for Spark.
        /// </para>
        /// </summary>
        public SparkSubmit SparkSubmit { get; set; }

        /// <summary>
        /// Checks to see if the SparkSubmit property is set.
        /// </summary>
        internal bool IsSetSparkSubmit() => this.SparkSubmit != null;
    }
}
