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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplications operation.
    /// Returns the descriptions of existing applications.
    /// </summary>
    public partial class DescribeApplicationsRequest : AmazonElasticBeanstalkRequest
    {
        private List<string> _applicationNames = new List<string>();


        /// <summary>
        /// Gets and sets the property ApplicationNames. 
        /// <para>
        ///          If specified, AWS Elastic Beanstalk         restricts the returned descriptions
        /// to         only include those with the         specified names.      
        /// </para>
        /// </summary>
        public List<string> ApplicationNames
        {
            get { return this._applicationNames; }
            set { this._applicationNames = value; }
        }

        // Check to see if ApplicationNames property is set
        internal bool IsSetApplicationNames()
        {
            return this._applicationNames != null && this._applicationNames.Count > 0; 
        }

    }
}