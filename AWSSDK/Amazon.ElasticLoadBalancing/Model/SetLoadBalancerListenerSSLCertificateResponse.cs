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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// Returns information about the  SetLoadBalancerListenerSSLCertificateResult response and response metadata.
    /// </summary>
    public class SetLoadBalancerListenerSSLCertificateResponse : AmazonWebServiceResponse
    {
        private SetLoadBalancerListenerSSLCertificateResult setLoadBalancerListenerSSLCertificateResult;

        /// <summary>
        /// Gets and sets the SetLoadBalancerListenerSSLCertificateResult property.
        /// The output for the SetLoadBalancerListenerSSLCertificate action.
        /// </summary>
        public SetLoadBalancerListenerSSLCertificateResult SetLoadBalancerListenerSSLCertificateResult
        {
            get 
            {
                if(this.setLoadBalancerListenerSSLCertificateResult == null)
                {
                    this.setLoadBalancerListenerSSLCertificateResult = new SetLoadBalancerListenerSSLCertificateResult();
                }

                return this.setLoadBalancerListenerSSLCertificateResult; 
            }
            set { this.setLoadBalancerListenerSSLCertificateResult = value; }
        }
    }
}
    
