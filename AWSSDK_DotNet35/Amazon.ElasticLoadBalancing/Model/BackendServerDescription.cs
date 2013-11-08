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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para> This data type is used as a response element in the DescribeLoadBalancers action to describe the configuration of the back-end
    /// server. </para>
    /// </summary>
    public class BackendServerDescription
    {
        
        private int? instancePort;
        private List<string> policyNames = new List<string>();


        /// <summary>
        /// Provides the port on which the back-end server is listening.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Range</term>
        ///         <description>1 - 65535</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public int InstancePort
        {
            get { return this.instancePort ?? default(int); }
            set { this.instancePort = value; }
        }

        // Check to see if InstancePort property is set
        internal bool IsSetInstancePort()
        {
            return this.instancePort.HasValue;
        }

        /// <summary>
        /// Provides a list of policy names enabled for the back-end server.
        ///  
        /// </summary>
        public List<string> PolicyNames
        {
            get { return this.policyNames; }
            set { this.policyNames = value; }
        }

        // Check to see if PolicyNames property is set
        internal bool IsSetPolicyNames()
        {
            return this.policyNames.Count > 0;
        }
    }
}
