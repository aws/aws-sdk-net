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

namespace Amazon.BedrockDataAutomation.Model
{
    /// <summary>
    /// Contains the information of a DataAutomationLibraryIngestionJob
    /// </summary>
    public partial class DataAutomationLibraryIngestionJob
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. Timestamp when the DataAutomationLibraryIngestionJob
        /// was completed
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. Timestamp when the DataAutomationLibraryIngestionJob
        /// was created
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EntityType. The entity type associated with DataAutomationLibraryIngestionJob
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. Error message
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property ErrorType. Error type
        /// </summary>
        public string ErrorType { get; set; }

        /// <summary>
        /// Checks to see if the ErrorType property is set.
        /// </summary>
        internal bool IsSetErrorType() => this.ErrorType != null;

        /// <summary>
        /// Gets and sets the property JobArn. ARN of the DataAutomationLibraryIngestionJob
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobStatus. The status of the DataAutomationLibraryIngestionJob
        /// </summary>
        [AWSProperty(Required = true)]
        public LibraryIngestionJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property OperationType. The operation associated with DataAutomationLibraryIngestionJob
        /// </summary>
        [AWSProperty(Required = true)]
        public LibraryIngestionJobOperationType OperationType { get; set; }

        /// <summary>
        /// Checks to see if the OperationType property is set.
        /// </summary>
        internal bool IsSetOperationType() => this.OperationType != null;

        /// <summary>
        /// Gets and sets the property OutputConfiguration. Output configuration of DataAutomationLibraryIngestionJob
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputConfiguration OutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfiguration property is set.
        /// </summary>
        internal bool IsSetOutputConfiguration() => this.OutputConfiguration != null;
    }
}
