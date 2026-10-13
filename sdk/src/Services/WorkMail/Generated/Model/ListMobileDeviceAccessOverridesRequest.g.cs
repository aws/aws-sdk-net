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
    /// Container for the parameters to the ListMobileDeviceAccessOverrides operation. Lists
    /// all the mobile device access overrides for any given combination of WorkMail organization,
    /// user, or device.
    /// </summary>
    public partial class ListMobileDeviceAccessOverridesRequest : AmazonWorkMailRequest
    {
        /// <summary>
        /// Gets and sets the property DeviceId. 
        /// <para>
        /// The mobile device to which the access override applies.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Checks to see if the DeviceId property is set.
        /// </summary>
        internal bool IsSetDeviceId() => this.DeviceId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to use to retrieve the next page of results. The first call does not require
        /// a token.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The WorkMail organization under which to list mobile device access overrides.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 34, Max = 34)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The WorkMail user under which you list the mobile device access overrides. Accepts
        /// the following types of user identities:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User ID: <c>12345678-1234-1234-1234-123456789012</c> or <c>S-1-1-12-1234567890-123456789-123456789-1234</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Email address: <c>user@domain.tld</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// User name: <c>user</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string UserId { get; set; }

        /// <summary>
        /// Checks to see if the UserId property is set.
        /// </summary>
        internal bool IsSetUserId() => this.UserId != null;
    }
}
