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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about errors in a BatchDescribeMergeConflicts operation.
    /// </summary>
    public partial class BatchDescribeMergeConflictsError
    {
        /// <summary>
        /// Gets and sets the property ExceptionName. 
        /// <para>
        /// The name of the exception.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ExceptionName { get; set; }

        /// <summary>
        /// Checks to see if the ExceptionName property is set.
        /// </summary>
        internal bool IsSetExceptionName() => this.ExceptionName != null;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        /// The path to the file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message provided by the exception.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
