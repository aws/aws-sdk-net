/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */

using System;

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DeleteSnapshotSchedule service
    /// </summary>
    public partial class DeleteSnapshotScheduleResponse : DeleteSnapshotScheduleResult
    {
        /// <summary>
        /// Gets and sets the DeleteSnapshotScheduleResult property.
        /// Represents the output of a DeleteSnapshotSchedule operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DeleteSnapshotScheduleResult class are now available on the DeleteSnapshotScheduleResponse class. You should use the properties on DeleteSnapshotScheduleResponse instead of accessing them through DeleteSnapshotScheduleResult.")]
        public DeleteSnapshotScheduleResult DeleteSnapshotScheduleResult
        {
            get
            {
                return this;
            }
        }
    }
}