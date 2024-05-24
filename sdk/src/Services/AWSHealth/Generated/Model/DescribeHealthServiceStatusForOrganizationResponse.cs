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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// This is the response object from the DescribeHealthServiceStatusForOrganization operation.
    /// </summary>
    public partial class DescribeHealthServiceStatusForOrganizationResponse : AmazonWebServiceResponse
    {
        private string _healthServiceAccessStatusForOrganization;

        /// <summary>
        /// Gets and sets the property HealthServiceAccessStatusForOrganization. 
        /// <para>
        /// Information about the status of enabling or disabling the Health organizational view
        /// feature in your organization.
        /// </para>
        ///  
        /// <para>
        /// Valid values are <c>ENABLED | DISABLED | PENDING</c>. 
        /// </para>
        /// </summary>
        public string HealthServiceAccessStatusForOrganization
        {
            get { return this._healthServiceAccessStatusForOrganization; }
            set { this._healthServiceAccessStatusForOrganization = value; }
        }

        // Check to see if HealthServiceAccessStatusForOrganization property is set
        internal bool IsSetHealthServiceAccessStatusForOrganization()
        {
            return this._healthServiceAccessStatusForOrganization != null;
        }

    }
}