/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Configuration for accessing Amazon SetQueueAttributes service
    /// </summary>
    public partial class SetQueueAttributesResponse : SetQueueAttributesResult
    {
        /// <summary>
        /// Gets and sets the SetQueueAttributesResult property.
        /// Represents the output of a SetQueueAttributes operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the SetQueueAttributesResult class are now available on the SetQueueAttributesResponse class. You should use the properties on SetQueueAttributesResponse instead of accessing them through SetQueueAttributesResult.")]
        public SetQueueAttributesResult SetQueueAttributesResult
        {
            get
            {
                return this;
            }
        }
    }
}