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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// This is the response object from the DescribeOrganization operation.
    /// </summary>
    public partial class DescribeOrganizationResponse : AmazonWebServiceResponse
    {
        private Organization _organization;

        /// <summary>
        /// Gets and sets the property Organization. 
        /// <para>
        /// A structure that contains information about the organization.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>AvailablePolicyTypes</c> part of the response is deprecated, and you shouldn't
        /// use it in your apps. It doesn't include any policy type supported by Organizations
        /// other than SCPs. In the China (Ningxia) Region, no policy type is included. To determine
        /// which policy types are enabled in your organization, use the <c> <a>ListRoots</a>
        /// </c> operation.
        /// </para>
        ///  </important>
        /// </summary>
        public Organization Organization
        {
            get { return this._organization; }
            set { this._organization = value; }
        }

        // Check to see if Organization property is set
        internal bool IsSetOrganization()
        {
            return this._organization != null;
        }

    }
}