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
    /// <para>The <c>ConnectionDraining</c> data type.</para>
    /// </summary>
    public partial class ConnectionDraining
    {
        
        private bool? enabled;
        private int? timeout;

        /// <summary>
        /// Specifies whether connection draining is enabled for the load balancer.
        ///  
        /// </summary>
        public bool Enabled
        {
            get { return this.enabled ?? default(bool); }
            set { this.enabled = value; }
        }

        /// <summary>
        /// Sets the Enabled property
        /// </summary>
        /// <param name="enabled">The value to set for the Enabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConnectionDraining WithEnabled(bool enabled)
        {
            this.enabled = enabled;
            return this;
        }
            

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this.enabled.HasValue;
        }

        /// <summary>
        /// Specifies the maximum time (in seconds) to keep the existing connections open before deregistering the instances.
        ///  
        /// </summary>
        public int Timeout
        {
            get { return this.timeout ?? default(int); }
            set { this.timeout = value; }
        }

        /// <summary>
        /// Sets the Timeout property
        /// </summary>
        /// <param name="timeout">The value to set for the Timeout property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConnectionDraining WithTimeout(int timeout)
        {
            this.timeout = timeout;
            return this;
        }
            

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this.timeout.HasValue;
        }
    }
}
