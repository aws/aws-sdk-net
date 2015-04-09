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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */

using System;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration for accessing Amazon CreateEventSourceMapping service
    /// </summary>
    public partial class CreateEventSourceMappingResponse : CreateEventSourceMappingResult
    {
        /// <summary>
        /// Gets and sets the CreateEventSourceMappingResult property.
        /// Represents the output of a CreateEventSourceMapping operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the CreateEventSourceMappingResult class are now available on the CreateEventSourceMappingResponse class. You should use the properties on CreateEventSourceMappingResponse instead of accessing them through CreateEventSourceMappingResult.")]
        public CreateEventSourceMappingResult CreateEventSourceMappingResult
        {
            get
            {
                return this;
            }
        }
    }
}