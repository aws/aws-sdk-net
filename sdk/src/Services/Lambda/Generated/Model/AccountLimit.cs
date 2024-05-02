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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
        private long? _codeSizeUnzipped;
        private long? _codeSizeZipped;
        private int? _concurrentExecutions;
        private long? _totalCodeSize;
        private int? _unreservedConcurrentExecutions;

        /// <summary>
        /// Gets and sets the property CodeSizeUnzipped. 
        /// <para>
        /// The maximum size of a function's deployment package and layers when they're extracted.
        /// </para>
        /// </summary>
        public long? CodeSizeUnzipped
        {
            get { return this._codeSizeUnzipped; }
            set { this._codeSizeUnzipped = value; }
        }

        // Check to see if CodeSizeUnzipped property is set
        internal bool IsSetCodeSizeUnzipped()
        {
            return this._codeSizeUnzipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodeSizeZipped. 
        /// <para>
        /// The maximum size of a deployment package when it's uploaded directly to Lambda. Use
        /// Amazon S3 for larger files.
        /// </para>
        /// </summary>
        public long? CodeSizeZipped
        {
            get { return this._codeSizeZipped; }
            set { this._codeSizeZipped = value; }
        }

        // Check to see if CodeSizeZipped property is set
        internal bool IsSetCodeSizeZipped()
        {
            return this._codeSizeZipped.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ConcurrentExecutions. 
        /// <para>
        /// The maximum number of simultaneous function executions.
        /// </para>
        /// </summary>
        public int? ConcurrentExecutions
        {
            get { return this._concurrentExecutions; }
            set { this._concurrentExecutions = value; }
        }

        // Check to see if ConcurrentExecutions property is set
        internal bool IsSetConcurrentExecutions()
        {
            return this._concurrentExecutions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalCodeSize. 
        /// <para>
        /// The amount of storage space that you can use for all deployment packages and layer
        /// archives.
        /// </para>
        /// </summary>
        public long? TotalCodeSize
        {
            get { return this._totalCodeSize; }
            set { this._totalCodeSize = value; }
        }

        // Check to see if TotalCodeSize property is set
        internal bool IsSetTotalCodeSize()
        {
            return this._totalCodeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnreservedConcurrentExecutions. 
        /// <para>
        /// The maximum number of simultaneous function executions, minus the capacity that's
        /// reserved for individual functions with <a>PutFunctionConcurrency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? UnreservedConcurrentExecutions
        {
            get { return this._unreservedConcurrentExecutions; }
            set { this._unreservedConcurrentExecutions = value; }
        }

        // Check to see if UnreservedConcurrentExecutions property is set
        internal bool IsSetUnreservedConcurrentExecutions()
        {
            return this._unreservedConcurrentExecutions.HasValue; 
        }

    }
}