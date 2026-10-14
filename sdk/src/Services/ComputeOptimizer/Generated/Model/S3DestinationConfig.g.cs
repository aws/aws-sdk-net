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

namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the destination Amazon Simple Storage Service (Amazon S3) bucket name and
    /// key prefix for a recommendations export job.
    /// 
    ///  
    /// <para>
    /// You must create the destination Amazon S3 bucket for your recommendations export before
    /// you create the export job. Compute Optimizer does not create the S3 bucket for you.
    /// After you create the S3 bucket, ensure that it has the required permission policy
    /// to allow Compute Optimizer to write the export file to it. If you plan to specify
    /// an object prefix when you create the export job, you must include the object prefix
    /// in the policy that you add to the S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/create-s3-bucket-policy-for-compute-optimizer.html">Amazon
    /// S3 Bucket Policy for Compute Optimizer</a> in the <i>Compute Optimizer User Guide</i>.
    /// </para>
    /// </summary>
    public partial class S3DestinationConfig
    {
        /// <summary>
        /// Gets and sets the property Bucket. 
        /// <para>
        /// The name of the Amazon S3 bucket to use as the destination for an export job.
        /// </para>
        /// </summary>
        public string Bucket { get; set; }

        /// <summary>
        /// Checks to see if the Bucket property is set.
        /// </summary>
        internal bool IsSetBucket() => this.Bucket != null;

        /// <summary>
        /// Gets and sets the property KeyPrefix. 
        /// <para>
        /// The Amazon S3 bucket prefix for an export job.
        /// </para>
        /// </summary>
        public string KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the KeyPrefix property is set.
        /// </summary>
        internal bool IsSetKeyPrefix() => this.KeyPrefix != null;
    }
}
