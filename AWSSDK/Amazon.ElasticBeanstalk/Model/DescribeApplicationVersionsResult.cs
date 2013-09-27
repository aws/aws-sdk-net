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
    /// <para>Result message wrapping a list of application version descriptions.</para>
    /// </summary>
    public class DescribeApplicationVersionsResult  
    {
        
        private List<ApplicationVersionDescription> applicationVersions = new List<ApplicationVersionDescription>();

        /// <summary>
        /// A list of <a>ApplicationVersionDescription</a> .
        ///  
        /// </summary>
        public List<ApplicationVersionDescription> ApplicationVersions
        {
            get { return this.applicationVersions; }
            set { this.applicationVersions = value; }
        }
        /// <summary>
        /// Adds elements to the ApplicationVersions collection
        /// </summary>
        /// <param name="applicationVersions">The values to add to the ApplicationVersions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationVersionsResult WithApplicationVersions(params ApplicationVersionDescription[] applicationVersions)
        {
            foreach (ApplicationVersionDescription element in applicationVersions)
            {
                this.applicationVersions.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the ApplicationVersions collection
        /// </summary>
        /// <param name="applicationVersions">The values to add to the ApplicationVersions collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationVersionsResult WithApplicationVersions(IEnumerable<ApplicationVersionDescription> applicationVersions)
        {
            foreach (ApplicationVersionDescription element in applicationVersions)
            {
                this.applicationVersions.Add(element);
            }

            return this;
        }

        // Check to see if ApplicationVersions property is set
        internal bool IsSetApplicationVersions()
        {
            return this.applicationVersions.Count > 0;       
        }
    }
}
