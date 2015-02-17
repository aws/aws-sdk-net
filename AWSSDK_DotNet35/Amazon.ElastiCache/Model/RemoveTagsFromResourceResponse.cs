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
 * Do not modify this file. This file is generated from the elasticache-2015-02-02.normal.json service model.
 */

using System;

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// Configuration for accessing Amazon RemoveTagsFromResource service
    /// </summary>
    public partial class RemoveTagsFromResourceResponse : RemoveTagsFromResourceResult
    {
        /// <summary>
        /// Gets and sets the RemoveTagsFromResourceResult property.
        /// Represents the output of a RemoveTagsFromResource operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the RemoveTagsFromResourceResult class are now available on the RemoveTagsFromResourceResponse class. You should use the properties on RemoveTagsFromResourceResponse instead of accessing them through RemoveTagsFromResourceResult.")]
        public RemoveTagsFromResourceResult RemoveTagsFromResourceResult
        {
            get
            {
                return this;
            }
        }
    }
}