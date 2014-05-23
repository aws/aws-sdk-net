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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeServiceErrors</code> request.
    /// </summary>
    public partial class DescribeServiceErrorsResult
    {
        private List<ServiceError> _serviceErrors = new List<ServiceError>();


        /// <summary>
        /// Gets and sets the property ServiceErrors. 
        /// <para>
        /// An array of <code>ServiceError</code> objects that describe the specified service
        /// errors.
        /// </para>
        /// </summary>
        public List<ServiceError> ServiceErrors
        {
            get { return this._serviceErrors; }
            set { this._serviceErrors = value; }
        }

        /// <summary>
        /// Sets the ServiceErrors property
        /// </summary>
        /// <param name="serviceErrors">The values to add to the ServiceErrors collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeServiceErrorsResult WithServiceErrors(params ServiceError[] serviceErrors)
        {
            foreach (var element in serviceErrors)
            {
                this._serviceErrors.Add(element);
            }
            return this;
        }

        /// <summary>
        /// Sets the ServiceErrors property
        /// </summary>
        /// <param name="serviceErrors">The values to add to the ServiceErrors collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeServiceErrorsResult WithServiceErrors(IEnumerable<ServiceError> serviceErrors)
        {
            foreach (var element in serviceErrors)
            {
                this._serviceErrors.Add(element);
            }
            return this;
        }
        // Check to see if ServiceErrors property is set
        internal bool IsSetServiceErrors()
        {
            return this._serviceErrors != null && this._serviceErrors.Count > 0; 
        }

    }
}