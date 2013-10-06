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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Returns information about the  DeleteDomainResult response and response metadata.
    /// </summary>
    public class DeleteDomainResponse : AmazonWebServiceResponse
    {
        private DeleteDomainResult deleteDomainResult;

        /// <summary>
        /// Gets and sets the DeleteDomainResult property.
        /// A response message that contains the status of a newly deleted domain, or no status if the domain has already been completely deleted.
        /// </summary>
        public DeleteDomainResult DeleteDomainResult
        {
            get 
            {
                if(this.deleteDomainResult == null)
                {
                    this.deleteDomainResult = new DeleteDomainResult();
                }

                return this.deleteDomainResult; 
            }
            set { this.deleteDomainResult = value; }
        }
    }
}
    
