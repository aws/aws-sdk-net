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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// <para>Result message containing a list of application descriptions.</para>
    /// </summary>
    public class DescribeApplicationsResult  
    {
        
        private List<ApplicationDescription> applications = new List<ApplicationDescription>();

        /// <summary>
        /// This parameter contains a list of <a>ApplicationDescription</a>.
        ///  
        /// </summary>
        public List<ApplicationDescription> Applications
        {
            get { return this.applications; }
            set { this.applications = value; }
        }
        /// <summary>
        /// Adds elements to the Applications collection
        /// </summary>
        /// <param name="applications">The values to add to the Applications collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationsResult WithApplications(params ApplicationDescription[] applications)
        {
            foreach (ApplicationDescription element in applications)
            {
                this.applications.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the Applications collection
        /// </summary>
        /// <param name="applications">The values to add to the Applications collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationsResult WithApplications(IEnumerable<ApplicationDescription> applications)
        {
            foreach (ApplicationDescription element in applications)
            {
                this.applications.Add(element);
            }

            return this;
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this.applications.Count > 0;       
        }
    }
}
