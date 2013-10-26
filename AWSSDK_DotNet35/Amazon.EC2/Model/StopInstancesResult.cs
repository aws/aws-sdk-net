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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The result of calling the StopInstances operation. Contains details on how the specified instances are changing state. </para>
    /// </summary>
    public partial class StopInstancesResult : AmazonWebServiceResponse
    {
        
        private List<InstanceStateChange> stoppingInstances = new List<InstanceStateChange>();


        /// <summary>
        /// The list of the stopping instances and details on how their state has changed.
        ///  
        /// </summary>
        public List<InstanceStateChange> StoppingInstances
        {
            get { return this.stoppingInstances; }
            set { this.stoppingInstances = value; }
        }

        // Check to see if StoppingInstances property is set
        internal bool IsSetStoppingInstances()
        {
            return this.stoppingInstances.Count > 0;
        }
    }
}
