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
 * Do not modify this file. This file is generated from the notifications-2018-05-10.normal.json service model.
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
namespace Amazon.Notifications.Model
{
    /// <summary>
    /// Orgs Service trust for User Notifications.
    /// </summary>
    public partial class NotificationsAccessForOrganization
    {
        private AccessStatus _accessStatus;

        /// <summary>
        /// Gets and sets the property AccessStatus. 
        /// <para>
        /// Access Status for the Orgs Service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AccessStatus AccessStatus
        {
            get { return this._accessStatus; }
            set { this._accessStatus = value; }
        }

        // Check to see if AccessStatus property is set
        internal bool IsSetAccessStatus()
        {
            return this._accessStatus != null;
        }

    }
}