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
using Amazon.Runtime;

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Returns information about the CreateEnvironmentResult response and response metadata.
    /// </summary>
    public class CreateEnvironmentResponse : AmazonWebServiceResponse
    {
        private CreateEnvironmentResult _createEnvironmentResult;

        /// <summary>
        /// Gets and sets the CreateEnvironmentResult property.
        /// Represents the output of a CreateEnvironment operation.
        /// </summary>
        public CreateEnvironmentResult CreateEnvironmentResult
        {
            get
            {
                if(this._createEnvironmentResult == null)
                {
                    this._createEnvironmentResult = new CreateEnvironmentResult();
                }
                return this._createEnvironmentResult;
            }
            set { this._createEnvironmentResult = value; }
        }
    }
}