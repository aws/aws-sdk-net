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
    /// Returns information about the UpdateApplicationResult response and response metadata.
    /// </summary>
    public class UpdateApplicationResponse : AmazonWebServiceResponse
    {
        private UpdateApplicationResult _updateApplicationResult;

        /// <summary>
        /// Gets and sets the UpdateApplicationResult property.
        /// Represents the output of a UpdateApplication operation.
        /// </summary>
        public UpdateApplicationResult UpdateApplicationResult
        {
            get
            {
                if(this._updateApplicationResult == null)
                {
                    this._updateApplicationResult = new UpdateApplicationResult();
                }
                return this._updateApplicationResult;
            }
            set { this._updateApplicationResult = value; }
        }
    }
}