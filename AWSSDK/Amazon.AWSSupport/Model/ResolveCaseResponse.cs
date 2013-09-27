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

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Returns information about the  ResolveCaseResult response and response metadata.
    /// </summary>
    public class ResolveCaseResponse : AmazonWebServiceResponse
    {
        private ResolveCaseResult resolveCaseResult;

        /// <summary>
        /// Gets and sets the ResolveCaseResult property.
        /// Returns the objects or data listed below if successful. Otherwise, returns an error.
        /// </summary>
        public ResolveCaseResult ResolveCaseResult
        {
            get
            {
                if(this.resolveCaseResult == null)
                {
                    this.resolveCaseResult = new ResolveCaseResult();
                }

                return this.resolveCaseResult;
            }
            set { this.resolveCaseResult = value; }
        }
    }
}
    
