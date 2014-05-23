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
    /// Returns information about the TerminateEnvironmentResult response and response metadata.
    /// </summary>
    public class TerminateEnvironmentResponse : AmazonWebServiceResponse
    {
        private TerminateEnvironmentResult _terminateEnvironmentResult;

        /// <summary>
        /// Gets and sets the TerminateEnvironmentResult property.
        /// Represents the output of a TerminateEnvironment operation.
        /// </summary>
        public TerminateEnvironmentResult TerminateEnvironmentResult
        {
            get
            {
                if(this._terminateEnvironmentResult == null)
                {
                    this._terminateEnvironmentResult = new TerminateEnvironmentResult();
                }
                return this._terminateEnvironmentResult;
            }
            set { this._terminateEnvironmentResult = value; }
        }
    }
}