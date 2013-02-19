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

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeServiceErrors</c> request.</para>
    /// </summary>
    public class DescribeServiceErrorsResult
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
        /// <summary>
        /// Adds elements to the ServiceErrors collection
        /// </summary>
        /// <param name="serviceErrors">The values to add to the ServiceErrors collection </param>
        /// <returns>this instance</returns>
        public DescribeServiceErrorsResult WithServiceErrors(params ServiceError[] serviceErrors)
        {
            foreach (ServiceError element in serviceErrors)
            {
                this.serviceErrors.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the ServiceErrors collection
        /// </summary>
        /// <param name="serviceErrors">The values to add to the ServiceErrors collection </param>
        /// <returns>this instance</returns>
        public DescribeServiceErrorsResult WithServiceErrors(IEnumerable<ServiceError> serviceErrors)
        {
            foreach (ServiceError element in serviceErrors)
            {
                this.serviceErrors.Add(element);
            }

            return this;
        }

        // Check to see if ServiceErrors property is set
        internal bool IsSetServiceErrors()
        {
            return this.serviceErrors.Count > 0;
        }
    }
}
