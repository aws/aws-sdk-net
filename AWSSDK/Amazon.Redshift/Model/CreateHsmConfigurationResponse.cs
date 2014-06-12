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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about the CreateHsmConfigurationResult response and response metadata.
    /// </summary>
    public class CreateHsmConfigurationResponse : AmazonWebServiceResponse
    {
        private CreateHsmConfigurationResult _createHsmConfigurationResult;

        /// <summary>
        /// Gets and sets the CreateHsmConfigurationResult property.
        /// Represents the output of a CreateHsmConfiguration operation.
        /// </summary>
        public CreateHsmConfigurationResult CreateHsmConfigurationResult
        {
            get
            {
                if(this._createHsmConfigurationResult == null)
                {
                    this._createHsmConfigurationResult = new CreateHsmConfigurationResult();
                }
                return this._createHsmConfigurationResult;
            }
            set { this._createHsmConfigurationResult = value; }
        }
    }
}