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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Returns information about the  CreateRole response and response metadata.
    /// </summary>
    public class CreateRoleResponse : CreateRoleResult
    {
        /// <summary>
        /// Gets and sets the CreateRoleResult property.
        /// Contains the result of a successful invocation of the CreateRole action.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the CreateRoleResult class are now available on the CreateRoleResponse class. You should use the properties on CreateRoleResponse instead of accessing them through CreateRoleResult.")]
        public CreateRoleResult CreateRoleResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
