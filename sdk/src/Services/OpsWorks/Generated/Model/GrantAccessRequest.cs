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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
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
    /// Container for the parameters to the GrantAccess operation.
    /// <note> 
    /// <para>
    /// This action can be used only with Windows stacks.
    /// </para>
    ///  </note> 
    /// <para>
    /// Grants RDP access to a Windows instance for a specified time period.
    /// </para>
    /// </summary>
    public partial class GrantAccessRequest : AmazonOpsWorksRequest
    {
        private string _instanceId;
        private int? _validForInMinutes;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance's AWS OpsWorks Stacks ID.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ValidForInMinutes. 
        /// <para>
        /// The length of time (in minutes) that the grant is valid. When the grant expires at
        /// the end of this period, the user will no longer be able to use the credentials to
        /// log in. If the user is logged in at the time, he or she automatically will be logged
        /// out.
        /// </para>
        /// </summary>
        public int ValidForInMinutes
        {
            get { return this._validForInMinutes.GetValueOrDefault(); }
            set { this._validForInMinutes = value; }
        }

        // Check to see if ValidForInMinutes property is set
        internal bool IsSetValidForInMinutes()
        {
            return this._validForInMinutes.HasValue; 
        }

    }
}