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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Contains the output from pipeline test operations, including processed records and
    /// any errors encountered.
    /// </summary>
    public partial class PipelineOutput
    {
        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// Any error that occurred during the pipeline test operation for this record.
        /// </para>
        /// </summary>
        public PipelineOutputError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Record. 
        /// <para>
        /// The processed record output from the pipeline test operation.
        /// </para>
        /// </summary>
        public Record Record { get; set; }

        /// <summary>
        /// Checks to see if the Record property is set.
        /// </summary>
        internal bool IsSetRecord() => this.Record != null;
    }
}
