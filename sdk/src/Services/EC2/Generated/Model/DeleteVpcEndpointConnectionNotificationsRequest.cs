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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the DeleteVpcEndpointConnectionNotifications operation.
    /// Deletes one or more VPC endpoint connection notifications.
    /// </summary>
    public partial class DeleteVpcEndpointConnectionNotificationsRequest : AmazonEC2Request
    {
        private List<string> _connectionNotificationIds = new List<string>();

        /// <summary>
        /// Gets and sets the property ConnectionNotificationIds. 
        /// <para>
        /// One or more notification IDs.
        /// </para>
        /// </summary>
        public List<string> ConnectionNotificationIds
        {
            get { return this._connectionNotificationIds; }
            set { this._connectionNotificationIds = value; }
        }

        // Check to see if ConnectionNotificationIds property is set
        internal bool IsSetConnectionNotificationIds()
        {
            return this._connectionNotificationIds != null && this._connectionNotificationIds.Count > 0; 
        }

    }
}