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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Contains the configuration to write the query results to S3.
    /// </summary>
    public partial class ProtectedQueryS3OutputConfiguration
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The S3 bucket to unload the protected query results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 63)]
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// The S3 prefix to unload the protected query results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the KeyPrefix property is set.
        /// </summary>
        internal bool IsSetKeyPrefix() => this.KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property ResultFormat. 
        /// <para>
        /// Intended file format of the result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResultFormat ResultFormat { get; set; }

        /// <summary>
        /// Checks to see if the ResultFormat property is set.
        /// </summary>
        internal bool IsSetResultFormat() => this.ResultFormat != null;

        /// <summary>
        /// Gets and sets the property SingleFileOutput. 
        /// <para>
        /// Indicates whether files should be output as a single file (<c>TRUE</c>) or output
        /// as multiple files (<c>FALSE</c>). This parameter is only supported for analyses with
        /// the Spark analytics engine.
        /// </para>
        /// </summary>
        public bool? SingleFileOutput { get; set; }

        /// <summary>
        /// Checks to see if the SingleFileOutput property is set.
        /// </summary>
        internal bool IsSetSingleFileOutput() => this.SingleFileOutput.HasValue;
    }
}
