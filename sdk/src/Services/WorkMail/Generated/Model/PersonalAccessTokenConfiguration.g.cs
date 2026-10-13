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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Displays the Personal Access Token status.
    /// </summary>
    public partial class PersonalAccessTokenConfiguration
    {
        /// <summary>
        /// Gets and sets the property LifetimeInDays. 
        /// <para>
        ///  The validity of the Personal Access Token status in days. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 3653)]
        public int? LifetimeInDays { get; set; }

        /// <summary>
        /// Checks to see if the LifetimeInDays property is set.
        /// </summary>
        internal bool IsSetLifetimeInDays() => this.LifetimeInDays.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The status of the Personal Access Token allowed for the organization. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Active</i> - Mailbox users can login to the web application and choose <i>Settings</i>
        /// to see the new <i>Personal Access Tokens</i> page to create and delete the Personal
        /// Access Tokens. Mailbox users can use the Personal Access Tokens to set up mailbox
        /// connection from desktop or mobile email clients.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Inactive</i> - Personal Access Tokens are disabled for your organization. Mailbox
        /// users can’t create, list, or delete Personal Access Tokens and can’t use them to connect
        /// to their mailboxes from desktop or mobile email clients.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PersonalAccessTokenConfigurationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
