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
    /// Limits that are related to concurrency and storage. All file and storage sizes are
    /// in bytes.
    /// </summary>
    public partial class AccountLimit
    {
        /// <summary>
        /// Gets and sets the property CodeSizeUnzipped. 
        /// <para>
        /// The maximum size of a function's deployment package and layers when they're extracted.
        /// </para>
        /// </summary>
        public long? CodeSizeUnzipped { get; set; }

        /// <summary>
        /// Checks to see if the CodeSizeUnzipped property is set.
        /// </summary>
        internal bool IsSetCodeSizeUnzipped() => this.CodeSizeUnzipped.HasValue;

        /// <summary>
        /// Gets and sets the property CodeSizeZipped. 
        /// <para>
        /// The maximum size of a deployment package when it's uploaded directly to Lambda. Use
        /// Amazon S3 for larger files.
        /// </para>
        /// </summary>
        public long? CodeSizeZipped { get; set; }

        /// <summary>
        /// Checks to see if the CodeSizeZipped property is set.
        /// </summary>
        internal bool IsSetCodeSizeZipped() => this.CodeSizeZipped.HasValue;

        /// <summary>
        /// Gets and sets the property ConcurrentExecutions. 
        /// <para>
        /// The maximum number of simultaneous function executions.
        /// </para>
        /// </summary>
        public int? ConcurrentExecutions { get; set; }

        /// <summary>
        /// Checks to see if the ConcurrentExecutions property is set.
        /// </summary>
        internal bool IsSetConcurrentExecutions() => this.ConcurrentExecutions.HasValue;

        /// <summary>
        /// Gets and sets the property TotalCodeSize. 
        /// <para>
        /// The amount of storage space that you can use for all deployment packages and layer
        /// archives.
        /// </para>
        /// </summary>
        public long? TotalCodeSize { get; set; }

        /// <summary>
        /// Checks to see if the TotalCodeSize property is set.
        /// </summary>
        internal bool IsSetTotalCodeSize() => this.TotalCodeSize.HasValue;

        /// <summary>
        /// Gets and sets the property UnreservedConcurrentExecutions. 
        /// <para>
        /// The maximum number of simultaneous function executions, minus the capacity that's
        /// reserved for individual functions with <a>PutFunctionConcurrency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public int? UnreservedConcurrentExecutions { get; set; }

        /// <summary>
        /// Checks to see if the UnreservedConcurrentExecutions property is set.
        /// </summary>
        internal bool IsSetUnreservedConcurrentExecutions() => this.UnreservedConcurrentExecutions.HasValue;
    }
}
