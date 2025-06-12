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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the DeleteQueuedReservedInstances operation.
    /// </summary>
    public partial class DeleteQueuedReservedInstancesResponse : AmazonWebServiceResponse
    {
        private List<FailedQueuedPurchaseDeletion> _failedQueuedPurchaseDeletions = AWSConfigs.InitializeCollections ? new List<FailedQueuedPurchaseDeletion>() : null;
        private List<SuccessfulQueuedPurchaseDeletion> _successfulQueuedPurchaseDeletions = AWSConfigs.InitializeCollections ? new List<SuccessfulQueuedPurchaseDeletion>() : null;

        /// <summary>
        /// Gets and sets the property FailedQueuedPurchaseDeletions. 
        /// <para>
        /// Information about the queued purchases that could not be deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FailedQueuedPurchaseDeletion> FailedQueuedPurchaseDeletions
        {
            get { return this._failedQueuedPurchaseDeletions; }
            set { this._failedQueuedPurchaseDeletions = value; }
        }

        // Check to see if FailedQueuedPurchaseDeletions property is set
        internal bool IsSetFailedQueuedPurchaseDeletions()
        {
            return this._failedQueuedPurchaseDeletions != null && (this._failedQueuedPurchaseDeletions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulQueuedPurchaseDeletions. 
        /// <para>
        /// Information about the queued purchases that were successfully deleted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SuccessfulQueuedPurchaseDeletion> SuccessfulQueuedPurchaseDeletions
        {
            get { return this._successfulQueuedPurchaseDeletions; }
            set { this._successfulQueuedPurchaseDeletions = value; }
        }

        // Check to see if SuccessfulQueuedPurchaseDeletions property is set
        internal bool IsSetSuccessfulQueuedPurchaseDeletions()
        {
            return this._successfulQueuedPurchaseDeletions != null && (this._successfulQueuedPurchaseDeletions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}