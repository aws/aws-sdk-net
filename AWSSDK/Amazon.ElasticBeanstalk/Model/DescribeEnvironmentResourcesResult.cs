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
    /// <para>Result message containing a list of environment resource descriptions. </para>
    /// </summary>
    public class DescribeEnvironmentResourcesResult  
    {
        
        private EnvironmentResourceDescription environmentResources;

        /// <summary>
        /// A list of <a>EnvironmentResourceDescription</a>.
        ///  
        /// </summary>
        public EnvironmentResourceDescription EnvironmentResources
        {
            get { return this.environmentResources; }
            set { this.environmentResources = value; }
        }

        /// <summary>
        /// Sets the EnvironmentResources property
        /// </summary>
        /// <param name="environmentResources">The value to set for the EnvironmentResources property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DescribeEnvironmentResourcesResult WithEnvironmentResources(EnvironmentResourceDescription environmentResources)
        {
            this.environmentResources = environmentResources;
            return this;
        }
            

        // Check to see if EnvironmentResources property is set
        internal bool IsSetEnvironmentResources()
        {
            return this.environmentResources != null;       
        }
    }
}
