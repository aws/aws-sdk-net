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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RebootDBInstance operation.
    /// <para> Reboots a previously provisioned RDS instance. This API results in the application of modified DBParameterGroup parameters with
    /// ApplyStatus of pending-reboot to the RDS instance. This action is taken as soon as possible, and results in a momentary outage to the RDS
    /// instance during which the RDS instance status is set to rebooting. If the RDS instance is configured for MultiAZ, it is possible that the
    /// reboot will be conducted through a failover. A DBInstance event is created when the reboot is completed. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.RebootDBInstance"/>
    public class RebootDBInstanceRequest : AmazonWebServiceRequest
    {
        private string dBInstanceIdentifier;
        private bool? forceFailover;

        /// <summary>
        /// The DB Instance identifier. This parameter is stored as a lowercase string. Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric
        /// characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li>
        /// </ul>
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="dBInstanceIdentifier">The value to set for the DBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RebootDBInstanceRequest WithDBInstanceIdentifier(string dBInstanceIdentifier)
        {
            this.dBInstanceIdentifier = dBInstanceIdentifier;
            return this;
        }
            

        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;
        }

        /// <summary>
        /// When <c>true</c>, the reboot will be conducted through a MultiAZ failover. Constraint: You cannot specify <c>true</c> if the instance is not
        /// configured for MultiAZ.
        ///  
        /// </summary>
        public bool ForceFailover
        {
            get { return this.forceFailover ?? default(bool); }
            set { this.forceFailover = value; }
        }

        /// <summary>
        /// Sets the ForceFailover property
        /// </summary>
        /// <param name="forceFailover">The value to set for the ForceFailover property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RebootDBInstanceRequest WithForceFailover(bool forceFailover)
        {
            this.forceFailover = forceFailover;
            return this;
        }
            

        // Check to see if ForceFailover property is set
        internal bool IsSetForceFailover()
        {
            return this.forceFailover.HasValue;
        }
    }
}
    
