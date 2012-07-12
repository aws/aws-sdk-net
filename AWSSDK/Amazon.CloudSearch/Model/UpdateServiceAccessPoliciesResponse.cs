/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Returns information about the  UpdateServiceAccessPoliciesResult response and response metadata.
    /// </summary>
    public class UpdateServiceAccessPoliciesResponse : AmazonWebServiceResponse
    {
        private UpdateServiceAccessPoliciesResult updateServiceAccessPoliciesResult;

        /// <summary>
        /// Gets and sets the UpdateServiceAccessPoliciesResult property.
        /// A response message that contains the status of updated access policies.
        /// </summary>
        public UpdateServiceAccessPoliciesResult UpdateServiceAccessPoliciesResult
        {
            get 
            {
                if(this.updateServiceAccessPoliciesResult == null)
                {
                    this.updateServiceAccessPoliciesResult = new UpdateServiceAccessPoliciesResult();
                }

                return this.updateServiceAccessPoliciesResult; 
            }
            set { this.updateServiceAccessPoliciesResult = value; }
        }
    }
}
    
