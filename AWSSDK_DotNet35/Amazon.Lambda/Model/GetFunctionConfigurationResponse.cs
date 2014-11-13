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
 * Do not modify this file. This file is generated from the lambda-2014-11-11.normal.json service model.
 */

using System;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Configuration for accessing Amazon GetFunctionConfiguration service
    /// </summary>
    public partial class GetFunctionConfigurationResponse : GetFunctionConfigurationResult
    {
        /// <summary>
        /// Gets and sets the GetFunctionConfigurationResult property.
        /// Represents the output of a GetFunctionConfiguration operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the GetFunctionConfigurationResult class are now available on the GetFunctionConfigurationResponse class. You should use the properties on GetFunctionConfigurationResponse instead of accessing them through GetFunctionConfigurationResult.")]
        public GetFunctionConfigurationResult GetFunctionConfigurationResult
        {
            get
            {
                return this;
            }
        }
    }
}