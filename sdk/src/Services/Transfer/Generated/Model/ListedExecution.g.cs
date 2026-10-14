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

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Returns properties of the execution that is specified.
    /// </summary>
    public partial class ListedExecution
    {
        /// <summary>
        /// Gets and sets the property ExecutionId. 
        /// <para>
        /// A unique identifier for the execution of a workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string ExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionId property is set.
        /// </summary>
        internal bool IsSetExecutionId() => this.ExecutionId != null;

        /// <summary>
        /// Gets and sets the property InitialFileLocation. 
        /// <para>
        /// A structure that describes the Amazon S3 or EFS file location. This is the file location
        /// when the execution begins: if the file is being copied, this is the initial (as opposed
        /// to destination) file location.
        /// </para>
        /// </summary>
        public FileLocation InitialFileLocation { get; set; }

        /// <summary>
        /// Checks to see if the InitialFileLocation property is set.
        /// </summary>
        internal bool IsSetInitialFileLocation() => this.InitialFileLocation != null;

        /// <summary>
        /// Gets and sets the property ServiceMetadata. 
        /// <para>
        /// A container object for the session details that are associated with a workflow.
        /// </para>
        /// </summary>
        public ServiceMetadata ServiceMetadata { get; set; }

        /// <summary>
        /// Checks to see if the ServiceMetadata property is set.
        /// </summary>
        internal bool IsSetServiceMetadata() => this.ServiceMetadata != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status is one of the execution. Can be in progress, completed, exception encountered,
        /// or handling the exception.
        /// </para>
        /// </summary>
        public ExecutionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
