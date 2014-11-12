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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeReservedInstancesResult : AmazonWebServiceResponse
    {
        private List<ReservedInstances> _reservedInstances = new List<ReservedInstances>();

        /// <summary>
        /// Gets and sets the property ReservedInstances. 
        /// <para>
        /// A list of Reserved Instances.
        /// </para>
        /// </summary>
        public List<ReservedInstances> ReservedInstances
        {
            get { return this._reservedInstances; }
            set { this._reservedInstances = value; }
        }

        // Check to see if ReservedInstances property is set
        internal bool IsSetReservedInstances()
        {
            return this._reservedInstances != null && this._reservedInstances.Count > 0; 
        }

    }
}