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
    /// Container for the parameters to the DescribeApplicationVersions operation.
    /// <para>Returns descriptions for existing application versions.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticBeanstalk.AmazonElasticBeanstalk.DescribeApplicationVersions"/>
    public class DescribeApplicationVersionsRequest : AmazonWebServiceRequest
    {
        private string applicationName;
        private List<string> versionLabels = new List<string>();

        /// <summary>
        /// If specified, AWS Elastic Beanstalk restricts the returned descriptions to only include ones that are associated with the specified
        /// application.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 100</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        /// <summary>
        /// Sets the ApplicationName property
        /// </summary>
        /// <param name="applicationName">The value to set for the ApplicationName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationVersionsRequest WithApplicationName(string applicationName)
        {
            this.applicationName = applicationName;
            return this;
        }
            

        // Check to see if ApplicationName property is set
        internal bool IsSetApplicationName()
        {
            return this.applicationName != null;       
        }

        /// <summary>
        /// If specified, restricts the returned descriptions to only include ones that have the specified version labels.
        ///  
        /// </summary>
        public List<string> VersionLabels
        {
            get { return this.versionLabels; }
            set { this.versionLabels = value; }
        }
        /// <summary>
        /// Adds elements to the VersionLabels collection
        /// </summary>
        /// <param name="versionLabels">The values to add to the VersionLabels collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationVersionsRequest WithVersionLabels(params string[] versionLabels)
        {
            foreach (string element in versionLabels)
            {
                this.versionLabels.Add(element);
            }

            return this;
        }
        
        /// <summary>
        /// Adds elements to the VersionLabels collection
        /// </summary>
        /// <param name="versionLabels">The values to add to the VersionLabels collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeApplicationVersionsRequest WithVersionLabels(IEnumerable<string> versionLabels)
        {
            foreach (string element in versionLabels)
            {
                this.versionLabels.Add(element);
            }

            return this;
        }

        // Check to see if VersionLabels property is set
        internal bool IsSetVersionLabels()
        {
            return this.versionLabels.Count > 0;       
        }
    }
}
    
