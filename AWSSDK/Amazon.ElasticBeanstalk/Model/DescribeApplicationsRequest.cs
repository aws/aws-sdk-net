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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplications operation.
    /// <para>Returns the descriptions of existing applications.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeApplications"/>
    public class DescribeApplicationsRequest : AmazonWebServiceRequest
    {
        private List<string> applicationNames = new List<string>();

        /// <summary>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to only include those with the specified names.
        ///  
        /// </summary>
        public List<string> ApplicationNames
        {
            get { return this.applicationNames; }
            set { this.applicationNames = value; }
        }
        /// <summary>
        /// Adds elements to the ApplicationNames collection
        /// </summary>
        /// <param name="applicationNames">The values to add to the ApplicationNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationsRequest WithApplicationNames(params string[] applicationNames)
        {
            foreach (string element in applicationNames)
            {
                this.applicationNames.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ApplicationNames collection
        /// </summary>
        /// <param name="applicationNames">The values to add to the ApplicationNames collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationsRequest WithApplicationNames(IEnumerable<string> applicationNames)
        {
            foreach (string element in applicationNames)
            {
                this.applicationNames.Add(element);
            }

            return this;
        }

        // Check to see if ApplicationNames property is set
        internal bool IsSetApplicationNames()
        {
            return this.applicationNames.Count > 0;       
        }
    }
}
    
