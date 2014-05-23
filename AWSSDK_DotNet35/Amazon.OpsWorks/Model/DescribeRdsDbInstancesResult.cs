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
    /// Contains the response to a <code>DescribeRdsDbInstances</code> request.
    /// </summary>
    public partial class DescribeRdsDbInstancesResult : AmazonWebServiceResponse
    {
        private List<RdsDbInstance> _rdsDbInstances = new List<RdsDbInstance>();


        /// <summary>
        /// Gets and sets the property RdsDbInstances. 
        /// <para>
        /// An a array of <code>RdsDbInstance</code> objects that describe the instances.
        /// </para>
        /// </summary>
        public List<RdsDbInstance> RdsDbInstances
        {
            get { return this._rdsDbInstances; }
            set { this._rdsDbInstances = value; }
        }

        // Check to see if RdsDbInstances property is set
        internal bool IsSetRdsDbInstances()
        {
            return this._rdsDbInstances != null && this._rdsDbInstances.Count > 0; 
        }

    }
}