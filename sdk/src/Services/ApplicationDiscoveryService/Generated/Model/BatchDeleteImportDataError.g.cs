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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Error messages returned for each import task that you deleted as a response for this
    /// command.
    /// </summary>
    public partial class BatchDeleteImportDataError
    {
        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The type of error that occurred for a specific import task.
        /// </para>
        /// </summary>
        public BatchDeleteImportDataErrorCode ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorDescription. 
        /// <para>
        /// The description of the error that occurred for a specific import task.
        /// </para>
        /// </summary>
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDescription property is set.
        /// </summary>
        internal bool IsSetErrorDescription() => this.ErrorDescription != null;

        /// <summary>
        /// Gets and sets the property ImportTaskId. 
        /// <para>
        /// The unique import ID associated with the error that occurred.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string ImportTaskId { get; set; }

        /// <summary>
        /// Checks to see if the ImportTaskId property is set.
        /// </summary>
        internal bool IsSetImportTaskId() => this.ImportTaskId != null;
    }
}
