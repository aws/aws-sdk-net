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

using System;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Configuration for accessing Amazon RemovePermission service
    /// </summary>
    public partial class RemovePermissionResponse : RemovePermissionResult
    {
        /// <summary>
        /// Gets and sets the RemovePermissionResult property.
        /// Represents the output of a RemovePermission operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the RemovePermissionResult class are now available on the RemovePermissionResponse class. You should use the properties on RemovePermissionResponse instead of accessing them through RemovePermissionResult.")]
        public RemovePermissionResult RemovePermissionResult
        {
            get
            {
                return this;
            }
        }
    }
}