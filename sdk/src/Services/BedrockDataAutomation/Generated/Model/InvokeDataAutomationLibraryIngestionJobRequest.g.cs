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
    /// Container for the parameters to the InvokeDataAutomationLibraryIngestionJob operation.
    /// Async API: Invoke data automation library ingestion job
    /// </summary>
    public partial class InvokeDataAutomationLibraryIngestionJobRequest : AmazonBedrockDataAutomationRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. Idempotency token
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property EntityType. The entity type for which DataAutomationLibraryIngestionJob
        /// is being run
        /// </summary>
        [AWSProperty(Required = true)]
        public EntityType EntityType { get; set; }

        /// <summary>
        /// Checks to see if the EntityType property is set.
        /// </summary>
        internal bool IsSetEntityType() => this.EntityType != null;

        /// <summary>
        /// Gets and sets the property InputConfiguration. Input configuration of DataAutomationLibraryIngestionJob
        /// request
        /// </summary>
        [AWSProperty(Required = true)]
        public InputConfiguration InputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the InputConfiguration property is set.
        /// </summary>
        internal bool IsSetInputConfiguration() => this.InputConfiguration != null;

        /// <summary>
        /// Gets and sets the property LibraryArn. ARN generated at the server side when a DataAutomationLibrary
        /// is created
        /// </summary>
        [AWSProperty(Required = true, Max = 128)]
        public string LibraryArn { get; set; }

        /// <summary>
        /// Checks to see if the LibraryArn property is set.
        /// </summary>
        internal bool IsSetLibraryArn() => this.LibraryArn != null;

        /// <summary>
        /// Gets and sets the property NotificationConfiguration. Notification configuration.
        /// </summary>
        public NotificationConfiguration NotificationConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfiguration property is set.
        /// </summary>
        internal bool IsSetNotificationConfiguration() => this.NotificationConfiguration != null;

        /// <summary>
        /// Gets and sets the property OperationType. The operation to be performed by DataAutomationLibraryIngestionJob
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

        /// <summary>
        /// Gets and sets the property Tags. List of tags
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
