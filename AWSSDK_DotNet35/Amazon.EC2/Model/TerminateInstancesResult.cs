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
    public partial class TerminateInstancesResult : AmazonWebServiceResponse
    {
        private List<InstanceStateChange> _terminatingInstances = new List<InstanceStateChange>();

        /// <summary>
        /// Gets and sets the property TerminatingInstances. 
        /// <para>
        /// Information about one or more terminated instances.
        /// </para>
        /// </summary>
        public List<InstanceStateChange> TerminatingInstances
        {
            get { return this._terminatingInstances; }
            set { this._terminatingInstances = value; }
        }

        // Check to see if TerminatingInstances property is set
        internal bool IsSetTerminatingInstances()
        {
            return this._terminatingInstances != null && this._terminatingInstances.Count > 0; 
        }

    }
}