/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Provides limits of code size and concurrency associated with the current account and
    /// region.
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
        /// Size, in bytes, of code/dependencies that you can zip into a deployment package (uncompressed
        /// zip/jar size) for uploading. The default limit is 250 MB.
        /// </para>
        /// </summary>
        public long CodeSizeUnzipped
        {
            get { return this._codeSizeUnzipped.GetValueOrDefault(); }
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
        /// Size, in bytes, of a single zipped code/dependencies package you can upload for your
        /// Lambda function(.zip/.jar file). Try using Amazon S3 for uploading larger files. Default
        /// limit is 50 MB.
        /// </para>
        /// </summary>
        public long CodeSizeZipped
        {
            get { return this._codeSizeZipped.GetValueOrDefault(); }
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
        /// Number of simultaneous executions of your function per region. For more information
        /// or to request a limit increase for concurrent executions, see <a href="http://docs.aws.amazon.com/lambda/latest/dg/concurrent-executions.html">Lambda
        /// Function Concurrent Executions</a>. The default limit is 1000.
        /// </para>
        /// </summary>
        public int ConcurrentExecutions
        {
            get { return this._concurrentExecutions.GetValueOrDefault(); }
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
        /// Maximum size, in bytes, of a code package you can upload per region. The default size
        /// is 75 GB. 
        /// </para>
        /// </summary>
        public long TotalCodeSize
        {
            get { return this._totalCodeSize.GetValueOrDefault(); }
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
        /// The number of concurrent executions available to functions that do not have concurrency
        /// limits set.
        /// </para>
        /// </summary>
        public int UnreservedConcurrentExecutions
        {
            get { return this._unreservedConcurrentExecutions.GetValueOrDefault(); }
            set { this._unreservedConcurrentExecutions = value; }
        }

        // Check to see if UnreservedConcurrentExecutions property is set
        internal bool IsSetUnreservedConcurrentExecutions()
        {
            return this._unreservedConcurrentExecutions.HasValue; 
        }

    }
}