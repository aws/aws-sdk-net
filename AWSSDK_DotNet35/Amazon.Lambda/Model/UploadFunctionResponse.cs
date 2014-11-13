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
    /// Configuration for accessing Amazon UploadFunction service
    /// </summary>
    public partial class UploadFunctionResponse : UploadFunctionResult
    {
        /// <summary>
        /// Gets and sets the UploadFunctionResult property.
        /// Represents the output of a UploadFunction operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the UploadFunctionResult class are now available on the UploadFunctionResponse class. You should use the properties on UploadFunctionResponse instead of accessing them through UploadFunctionResult.")]
        public UploadFunctionResult UploadFunctionResult
        {
            get
            {
                return this;
            }
        }
    }
}