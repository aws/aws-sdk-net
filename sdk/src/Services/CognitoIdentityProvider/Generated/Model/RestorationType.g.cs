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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// The details of a point-in-time recovery of a user pool.
    /// </summary>
    public partial class RestorationType
    {
        /// <summary>
        /// Gets and sets the property RestoreId. 
        /// <para>
        /// The ID of the recovery. Use this ID in requests to describe, start, or cancel the
        /// recovery.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string RestoreId { get; set; }

        /// <summary>
        /// Checks to see if the RestoreId property is set.
        /// </summary>
        internal bool IsSetRestoreId() => this.RestoreId != null;

        /// <summary>
        /// Gets and sets the property RestorePreview. 
        /// <para>
        /// The recovery preview. For each type of entity, the preview shows the number of entities
        /// that the recovery creates, updates, and deletes. The preview doesn't include user
        /// data. Amazon Cognito returns the preview when it's available.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RestorePreviewType> RestorePreview { get; set; } = AWSConfigs.InitializeCollections ? new List<RestorePreviewType>() : null;

        /// <summary>
        /// Checks to see if the RestorePreview property is set.
        /// </summary>
        internal bool IsSetRestorePreview() => this.RestorePreview != null && (this.RestorePreview.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RestoreStatus. 
        /// <para>
        /// The status of the recovery. Can be one of the following values.
        /// </para>
        ///  <dl> <dt>PREVIEW_GENERATING</dt> <dd> 
        /// <para>
        /// Amazon Cognito is waiting for available capacity in the Amazon Web Services Region
        /// or is generating the recovery preview. Write operations in the user pool are paused.
        /// </para>
        ///  </dd> <dt>PREVIEW_GENERATED</dt> <dd> 
        /// <para>
        /// The recovery preview is ready for review. Write operations in the user pool are paused.
        /// Within 24 hours after you initiate the recovery, apply it with a <c>StartPointInTimeRecovery</c>
        /// request or discard it with a <c>CancelPointInTimeRecovery</c> request.
        /// </para>
        ///  </dd> <dt>PREVIEW_CANCELLED</dt> <dd> 
        /// <para>
        /// You canceled the recovery. Amazon Cognito resumed write operations and didn't change
        /// your user pool data.
        /// </para>
        ///  </dd> <dt>PREVIEW_GENERATION_FAILED</dt> <dd> 
        /// <para>
        /// Amazon Cognito couldn't generate the recovery preview. Amazon Cognito resumed write
        /// operations and didn't change your user pool data. You can initiate a new recovery.
        /// </para>
        ///  </dd> <dt>PREVIEW_EXPIRED</dt> <dd> 
        /// <para>
        /// You didn't start or cancel the recovery within 24 hours after you initiated it. Amazon
        /// Cognito resumed write operations and didn't change your user pool data.
        /// </para>
        ///  </dd> <dt>RESTORING</dt> <dd> 
        /// <para>
        /// Amazon Cognito is restoring user data in the user pool to its state at the recovery
        /// point. Write operations in the user pool are paused.
        /// </para>
        ///  </dd> <dt>RESTORE_COMPLETED</dt> <dd> 
        /// <para>
        /// Amazon Cognito restored your user pool to its state at the recovery point and resumed
        /// write operations.
        /// </para>
        ///  </dd> <dt>TEMPORARY_INTERNAL_ERROR_SEE_SUPPORT_CASE</dt> <dd> 
        /// <para>
        /// The recovery encountered an internal error. Write operations in the user pool remain
        /// paused. Amazon Web Services Support contacts you through a support case to resolve
        /// the issue.
        /// </para>
        ///  </dd> <dt>AWS_ABORTED</dt> <dd> 
        /// <para>
        /// Amazon Cognito stopped the recovery because of an internal failure. Write operations
        /// in the user pool remain paused, and you can't cancel or retry the recovery. Amazon
        /// Web Services Support contacts you through a support case to resolve the issue.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public RestoreStatusType RestoreStatus { get; set; }

        /// <summary>
        /// Checks to see if the RestoreStatus property is set.
        /// </summary>
        internal bool IsSetRestoreStatus() => this.RestoreStatus != null;

        /// <summary>
        /// Gets and sets the property RestoreTimestamp. 
        /// <para>
        /// The point in time that the recovery restores the user pool to.
        /// </para>
        /// </summary>
        public DateTime? RestoreTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTimestamp property is set.
        /// </summary>
        internal bool IsSetRestoreTimestamp() => this.RestoreTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property TriggerTimestamp. 
        /// <para>
        /// The end of the period of changes that the recovery reverts. This time is shortly after
        /// the time that you initiated the recovery. The recovery reverts changes to user data
        /// that occurred between <c>RestoreTimestamp</c> and <c>TriggerTimestamp</c>.
        /// </para>
        /// </summary>
        public DateTime? TriggerTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the TriggerTimestamp property is set.
        /// </summary>
        internal bool IsSetTriggerTimestamp() => this.TriggerTimestamp.HasValue;
    }
}
