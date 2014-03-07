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

namespace Amazon.ElasticLoadBalancing.Model
{
    /// <summary>
    /// <para>The <c>LoadBalancerAttributes</c> data type.</para>
    /// </summary>
    public partial class LoadBalancerAttributes
    {
        
        private CrossZoneLoadBalancing crossZoneLoadBalancing;
        private AccessLog accessLog;


        /// <summary>
        /// The name of the load balancer attribute.
        ///  
        /// </summary>
        public CrossZoneLoadBalancing CrossZoneLoadBalancing
        {
            get { return this.crossZoneLoadBalancing; }
            set { this.crossZoneLoadBalancing = value; }
        }

        // Check to see if CrossZoneLoadBalancing property is set
        internal bool IsSetCrossZoneLoadBalancing()
        {
            return this.crossZoneLoadBalancing != null;
        }

        /// <summary>
        /// The name of the load balancer attribute.
        ///  
        /// </summary>
        public AccessLog AccessLog
        {
            get { return this.accessLog; }
            set { this.accessLog = value; }
        }

        // Check to see if AccessLog property is set
        internal bool IsSetAccessLog()
        {
            return this.accessLog != null;
        }
    }
}
