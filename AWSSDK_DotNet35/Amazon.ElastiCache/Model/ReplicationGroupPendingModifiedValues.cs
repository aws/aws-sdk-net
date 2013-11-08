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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>The settings to be applied to the replication group, either immediately or during the next maintenance window.</para>
    /// </summary>
    public class ReplicationGroupPendingModifiedValues
    {
        
        private string primaryClusterId;


        /// <summary>
        /// The primary cluster ID which will be applied immediately (if <c>--apply-immediately</c> was specified), or during the next maintenance
        /// window.
        ///  
        /// </summary>
        public string PrimaryClusterId
        {
            get { return this.primaryClusterId; }
            set { this.primaryClusterId = value; }
        }

        // Check to see if PrimaryClusterId property is set
        internal bool IsSetPrimaryClusterId()
        {
            return this.primaryClusterId != null;
        }
    }
}
