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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSSupport.Model
{
    /// <summary>
    /// Container for the parameters to the RefreshTrustedAdvisorCheck operation.
    /// <para>This action enables you to query the service to request a refresh for a specific Trusted Advisor check. Your request body contains a
    /// <i>CheckId</i> for which you are querying. The response body contains a RefreshTrustedAdvisorCheckResult object containing <i>Status</i> and
    /// <i>TimeUntilNextRefresh</i> fields.</para>
    /// </summary>
    /// <seealso cref="Amazon.AWSSupport.AmazonAWSSupport.RefreshTrustedAdvisorCheck"/>
    public class RefreshTrustedAdvisorCheckRequest : AmazonWebServiceRequest
    {
        private string checkId;

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string CheckId
        {
            get { return this.checkId; }
            set { this.checkId = value; }
        }

        /// <summary>
        /// Sets the CheckId property
        /// </summary>
        /// <param name="checkId">The value to set for the CheckId property </param>
        /// <returns>this instance</returns>
        public RefreshTrustedAdvisorCheckRequest WithCheckId(string checkId)
        {
            this.checkId = checkId;
            return this;
        }
            

        // Check to see if CheckId property is set
        internal bool IsSetCheckId()
        {
            return this.checkId != null;
        }
    }
}
    
