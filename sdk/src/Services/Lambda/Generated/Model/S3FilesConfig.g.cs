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

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Setting controls how your function accesses data from an Amazon S3 file system.
    /// </summary>
    public partial class S3FilesConfig
    {
        /// <summary>
        /// Gets and sets the property DirectS3Read. 
        /// <para>
        /// Specifies if a function reads from the file system for the lowest latency, or through
        /// Amazon S3 Files feature "direct Amazon S3 bucket reads" for the highest throughput.
        /// Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AUTO</c> (default) – Direct reads are active for functions you configure with
        /// 512 MB or more of memory.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED</c> – Enforces all reads are directly from the Amazon S3 bucket, regardless
        /// of available memory (less than 512 MB).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> – Routes all reads through the file system, regardless of memory
        /// configuration.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use direct reads, you must grant the execution role the <c>s3:GetObject</c> and
        /// <c>s3:GetObjectVersion</c> permissions. If a direct read fails, Lambda automatically
        /// falls back to reading through the file system.
        /// </para>
        /// </summary>
        public DirectS3Read DirectS3Read { get; set; }

        /// <summary>
        /// Checks to see if the DirectS3Read property is set.
        /// </summary>
        internal bool IsSetDirectS3Read() => this.DirectS3Read != null;
    }
}
