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
    public partial class DescribeApplicationsRequest : AmazonElasticBeanstalkRequest
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

        // Check to see if ApplicationNames property is set
        internal bool IsSetApplicationNames()
        {
            return this.applicationNames.Count > 0;
        }

    }
}
    
