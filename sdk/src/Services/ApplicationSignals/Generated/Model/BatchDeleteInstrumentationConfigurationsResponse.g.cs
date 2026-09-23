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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteInstrumentationConfigurations operation.
    /// </summary>
    public partial class BatchDeleteInstrumentationConfigurationsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DeletedCount. Number of configurations successfully deleted.
        /// When deleting by scope, this is the total count of deleted items. When deleting by
        /// ARN list, this equals the length of SuccessfulDeletions.
        /// </summary>
        [AWSProperty(Required = true)]
        public int? DeletedCount { get; set; }

        /// <summary>
        /// Checks to see if the DeletedCount property is set.
        /// </summary>
        internal bool IsSetDeletedCount() => this.DeletedCount.HasValue;

        /// <summary>
        /// Gets and sets the property Errors. List of configurations that failed to delete.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchDeleteError> Errors { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchDeleteError>() : null;

        /// <summary>
        /// Checks to see if the Errors property is set.
        /// </summary>
        internal bool IsSetErrors() => this.Errors != null && (this.Errors.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SuccessfulDeletions. List of successfully deleted configurations.
        /// Deleting by scope populates SignalType and LocationHash per item. Deleting by ARN
        /// list populates ResourceArn per item.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<BatchDeleteSuccessfulDeletion> SuccessfulDeletions { get; set; } = AWSConfigs.InitializeCollections ? new List<BatchDeleteSuccessfulDeletion>() : null;

        /// <summary>
        /// Checks to see if the SuccessfulDeletions property is set.
        /// </summary>
        internal bool IsSetSuccessfulDeletions() => this.SuccessfulDeletions != null && (this.SuccessfulDeletions.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
