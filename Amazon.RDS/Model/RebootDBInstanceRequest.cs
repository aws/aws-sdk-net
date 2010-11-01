/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> The RebootDBInstance API reboots a previously provisioned RDS
    /// instance. This API results in the application of modified
    /// DBParameterGroup parameters with ApplyStatus of pending-reboot to the
    /// RDS instance. This action is taken as soon as possible, and results in
    /// a momentary outage to the RDS instance during which the RDS instance
    /// status is set to rebooting. A DBInstance event is created when the
    /// reboot is completed. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.RebootDBInstance"/>
    public class RebootDBInstanceRequest : AmazonWebServiceRequest
    {
        private string dBInstanceIdentifier;

        /// <summary>
        /// The DB Instance identifier. This parameter is stored as a lowercase
        /// string.
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
    }
}
    
