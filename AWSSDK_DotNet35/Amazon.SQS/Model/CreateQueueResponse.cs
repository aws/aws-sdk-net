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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Configuration for accessing Amazon CreateQueue service
    /// </summary>
    public partial class CreateQueueResponse : CreateQueueResult
    {
        /// <summary>
        /// Gets and sets the CreateQueueResult property.
        /// Represents the output of a CreateQueue operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the CreateQueueResult class are now available on the CreateQueueResponse class. You should use the properties on CreateQueueResponse instead of accessing them through CreateQueueResult.")]
        public CreateQueueResult CreateQueueResult
        {
            get
            {
                return this;
            }
        }
    }
}