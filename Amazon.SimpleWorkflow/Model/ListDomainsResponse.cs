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
namespace Amazon.SimpleWorkflow.Model
{
    /// <summary>
    /// Returns information about the ListDomains response and response metadata.
    /// </summary>
    public class ListDomainsResponse : AmazonWebServiceResponse
    {
        private ListDomainsResult listDomainsResult;

        /// 
        /// Gets and sets the ListDomainsResult property.
        /// Contains the result of a successful invocation of the ListDomains
        /// action.
        /// 
        public ListDomainsResult ListDomainsResult
        {
            get 
            {
                if(this.listDomainsResult == null)
                {
                    this.listDomainsResult = new ListDomainsResult();
                }

                return this.listDomainsResult; 
            }
            set { this.listDomainsResult = value; }
        }
    }
}
    
