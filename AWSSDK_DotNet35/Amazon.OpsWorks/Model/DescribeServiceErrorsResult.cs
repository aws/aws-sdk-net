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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeServiceErrors</c> request.</para>
    /// </summary>
    public partial class DescribeServiceErrorsResult : AmazonWebServiceResponse
    {
        
        private List<ServiceError> serviceErrors = new List<ServiceError>();


        /// <summary>
        /// An array of <c>ServiceError</c> objects that describe the specified service errors.
        ///  
        /// </summary>
        public List<ServiceError> ServiceErrors
        {
            get { return this.serviceErrors; }
            set { this.serviceErrors = value; }
        }

        // Check to see if ServiceErrors property is set
        internal bool IsSetServiceErrors()
        {
            return this.serviceErrors.Count > 0;
        }
    }
}
