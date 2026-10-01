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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides details about where a code vulnerability is located in your Lambda function.
    /// </summary>
    public partial class CodeVulnerabilitiesFilePath
    {
        /// <summary>
        /// Gets and sets the property EndLine. 
        /// <para>
        ///  The line number of the last line of code in which the vulnerability is located. 
        /// </para>
        /// </summary>
        public int? EndLine { get; set; }

        /// <summary>
        /// Checks to see if the EndLine property is set.
        /// </summary>
        internal bool IsSetEndLine() => this.EndLine.HasValue;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        ///  The name of the file in which the code vulnerability is located. 
        /// </para>
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property FilePath. 
        /// <para>
        ///  The file path to the code in which the vulnerability is located. 
        /// </para>
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// Checks to see if the FilePath property is set.
        /// </summary>
        internal bool IsSetFilePath() => this.FilePath != null;

        /// <summary>
        /// Gets and sets the property StartLine. 
        /// <para>
        ///  The line number of the first line of code in which the vulnerability is located.
        /// 
        /// </para>
        /// </summary>
        public int? StartLine { get; set; }

        /// <summary>
        /// Checks to see if the StartLine property is set.
        /// </summary>
        internal bool IsSetStartLine() => this.StartLine.HasValue;
    }
}
