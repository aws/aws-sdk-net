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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the deletion state of an Amazon Route 53 hosted zone for a domain that is
    /// being automatically delegated to an Amazon Lightsail DNS zone.
    /// </summary>
    public partial class R53HostedZoneDeletionState
    {
        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The status code for the deletion state.
        /// </para>
        ///  
        /// <para>
        /// Following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> - The hosted zone was successfully deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - The hosted zone deletion is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The hosted zone deletion failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTED</c> - The hosted zone deletion started.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public R53HostedZoneDeletionStateCode Code { get; set; }

        /// <summary>
        /// Checks to see if the Code property is set.
        /// </summary>
        internal bool IsSetCode() => this.Code != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message that describes the reason for the status code.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
