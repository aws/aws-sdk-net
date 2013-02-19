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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Returns information about the  CreateAppResult response and response metadata.
    /// </summary>
    public class CreateAppResponse : AmazonWebServiceResponse
    {
        private CreateAppResult createAppResult;

        /// <summary>
        /// Gets and sets the CreateAppResult property.
        /// Contains the response to a CreateApp request.
        /// </summary>
        public CreateAppResult CreateAppResult
        {
            get
            {
                if(this.createAppResult == null)
                {
                    this.createAppResult = new CreateAppResult();
                }

                return this.createAppResult;
            }
            set { this.createAppResult = value; }
        }
    }
}
    
