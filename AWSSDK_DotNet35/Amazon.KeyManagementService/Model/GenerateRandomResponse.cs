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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */

using System;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Configuration for accessing Amazon GenerateRandom service
    /// </summary>
    public partial class GenerateRandomResponse : GenerateRandomResult
    {
        /// <summary>
        /// Gets and sets the GenerateRandomResult property.
        /// Represents the output of a GenerateRandom operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the GenerateRandomResult class are now available on the GenerateRandomResponse class. You should use the properties on GenerateRandomResponse instead of accessing them through GenerateRandomResult.")]
        public GenerateRandomResult GenerateRandomResult
        {
            get
            {
                return this;
            }
        }
    }
}