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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// This is the response object from the GetBulkPublishDetails operation.
    /// </summary>
    public partial class GetBulkPublishDetailsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BulkPublishCompleteTime. If BulkPublishStatus is SUCCEEDED,
        /// the time the last bulk publish operation completed.
        /// </summary>
        public DateTime? BulkPublishCompleteTime { get; set; }

        /// <summary>
        /// Checks to see if the BulkPublishCompleteTime property is set.
        /// </summary>
        internal bool IsSetBulkPublishCompleteTime() => this.BulkPublishCompleteTime.HasValue;

        /// <summary>
        /// Gets and sets the property BulkPublishStartTime. The date/time at which the last bulk
        /// publish was initiated.
        /// </summary>
        public DateTime? BulkPublishStartTime { get; set; }

        /// <summary>
        /// Checks to see if the BulkPublishStartTime property is set.
        /// </summary>
        internal bool IsSetBulkPublishStartTime() => this.BulkPublishStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property BulkPublishStatus. Status of the last bulk publish operation,
        /// valid values are: 
        /// <para>
        /// NOT_STARTED - No bulk publish has been requested for this identity pool
        /// </para>
        ///  
        /// <para>
        /// IN_PROGRESS - Data is being published to the configured stream
        /// </para>
        ///  
        /// <para>
        /// SUCCEEDED - All data for the identity pool has been published to the configured stream
        /// </para>
        ///  
        /// <para>
        /// FAILED - Some portion of the data has failed to publish, check FailureMessage for
        /// the cause.
        /// </para>
        /// </summary>
        public BulkPublishStatus BulkPublishStatus { get; set; }

        /// <summary>
        /// Checks to see if the BulkPublishStatus property is set.
        /// </summary>
        internal bool IsSetBulkPublishStatus() => this.BulkPublishStatus != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. If BulkPublishStatus is FAILED this field
        /// will contain the error message that caused the bulk publish to fail.
        /// </summary>
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE)
        /// created by Amazon Cognito. GUID generation is unique within a region.
        /// </summary>
        [AWSProperty(Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;
    }
}
