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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
 */

using System;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DecodeAuthorizationMessage service
    /// </summary>
    public partial class DecodeAuthorizationMessageResponse : DecodeAuthorizationMessageResult
    {
        /// <summary>
        /// Gets and sets the DecodeAuthorizationMessageResult property.
        /// Represents the output of a DecodeAuthorizationMessage operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DecodeAuthorizationMessageResult class are now available on the DecodeAuthorizationMessageResponse class. You should use the properties on DecodeAuthorizationMessageResponse instead of accessing them through DecodeAuthorizationMessageResult.")]
        public DecodeAuthorizationMessageResult DecodeAuthorizationMessageResult
        {
            get
            {
                return this;
            }
        }
    }
}