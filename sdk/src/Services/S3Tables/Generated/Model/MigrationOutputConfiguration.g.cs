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

namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// The bucket and prefixes that a migration writes its reports to. Every report goes
    /// to one bucket, each under its own prefix.
    /// </summary>
    public partial class MigrationOutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The general purpose bucket that the migration writes every report to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 1024)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property Prefixes. 
        /// <para>
        /// The key prefix for each report.
        /// </para>
        /// </summary>
        public MigrationReportPrefixes Prefixes { get; set; }

        /// <summary>
        /// Checks to see if the Prefixes property is set.
        /// </summary>
        internal bool IsSetPrefixes() => this.Prefixes != null;
    }
}
