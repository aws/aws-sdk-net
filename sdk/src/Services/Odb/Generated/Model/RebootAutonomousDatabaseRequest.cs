/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Odb.Model
{
    /// <summary>
    /// Container for the parameters to the RebootAutonomousDatabase operation.
    /// Reboots the specified Autonomous Database.
    /// </summary>
    public partial class RebootAutonomousDatabaseRequest : AmazonOdbRequest
    {
        private string _autonomousDatabaseId;
        private bool? _isOnlineReboot;

        /// <summary>
        /// Gets and sets the property AutonomousDatabaseId. 
        /// <para>
        /// The unique identifier of the Autonomous Database to reboot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=6, Max=2048)]
        public string AutonomousDatabaseId
        {
            get { return this._autonomousDatabaseId; }
            set { this._autonomousDatabaseId = value; }
        }

        // Check to see if AutonomousDatabaseId property is set
        internal bool IsSetAutonomousDatabaseId()
        {
            return this._autonomousDatabaseId != null;
        }

        /// <summary>
        /// Gets and sets the property IsOnlineReboot. 
        /// <para>
        /// Specifies whether to perform an online reboot of the Autonomous Database without interrupting
        /// active connections.
        /// </para>
        /// </summary>
        public bool? IsOnlineReboot
        {
            get { return this._isOnlineReboot; }
            set { this._isOnlineReboot = value; }
        }

        // Check to see if IsOnlineReboot property is set
        internal bool IsSetIsOnlineReboot()
        {
            return this._isOnlineReboot.HasValue; 
        }

    }
}