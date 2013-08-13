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
using System.IO;

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>A <c>PolicyDocument</c> that specifies access policies for the search domain's services, and the current status of those
    /// policies.</para>
    /// </summary>
    public class AccessPoliciesStatus  
    {
        
        private string options;
        private OptionStatus status;

        /// <summary>
        /// An IAM access policy as described in <a href="http://docs.amazonwebservices.com/IAM/latest/UserGuide/index.html?AccessPolicyLanguage.html"
        /// target="_blank">The Access Policy Language</a> in <i>Using AWS Identity and Access Management</i>. The maximum size of an access policy
        /// document is 100KB. Example: <c>{"Statement": [{"Effect":"Allow", "Action": "*", "Resource": "arn:aws:cs:us-east-1:1234567890:search/movies",
        /// "Condition": { "IpAddress": { aws:SourceIp": ["203.0.113.1/32"] } }}, {"Effect":"Allow", "Action": "*", "Resource":
        /// "arn:aws:cs:us-east-1:1234567890:documents/movies", "Condition": { "IpAddress": { aws:SourceIp": ["203.0.113.1/32"] } }} ] }</c>
        ///  
        /// </summary>
        public string Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        /// <summary>
        /// Sets the Options property
        /// </summary>
        /// <param name="options">The value to set for the Options property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessPoliciesStatus WithOptions(string options)
        {
            this.options = options;
            return this;
        }
            

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options != null;       
        }

        /// <summary>
        /// The status of an option, including when it was last updated and whether it is actively in use for searches.
        ///  
        /// </summary>
        public OptionStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AccessPoliciesStatus WithStatus(OptionStatus status)
        {
            this.status = status;
            return this;
        }
            

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;       
        }
    }
}
