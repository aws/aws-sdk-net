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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
        private int? _deletedCount;
        private List<BatchDeleteError> _errors = AWSConfigs.InitializeCollections ? new List<BatchDeleteError>() : null;
        private List<BatchDeleteSuccessfulDeletion> _successfulDeletions = AWSConfigs.InitializeCollections ? new List<BatchDeleteSuccessfulDeletion>() : null;

        /// <summary>
        /// Gets and sets the property DeletedCount. 
        /// <para>
        /// Number of configurations successfully deleted. When deleting by scope, this is the
        /// total count of deleted items. When deleting by ARN list, this equals the length of
        /// SuccessfulDeletions.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? DeletedCount
        {
            get { return this._deletedCount; }
            set { this._deletedCount = value; }
        }

        // Check to see if DeletedCount property is set
        internal bool IsSetDeletedCount()
        {
            return this._deletedCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// List of configurations that failed to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDeleteError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulDeletions. 
        /// <para>
        /// List of successfully deleted configurations. Deleting by scope populates SignalType
        /// and LocationHash per item. Deleting by ARN list populates ResourceArn per item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDeleteSuccessfulDeletion> SuccessfulDeletions
        {
            get { return this._successfulDeletions; }
            set { this._successfulDeletions = value; }
        }

        // Check to see if SuccessfulDeletions property is set
        internal bool IsSetSuccessfulDeletions()
        {
            return this._successfulDeletions != null && (this._successfulDeletions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}