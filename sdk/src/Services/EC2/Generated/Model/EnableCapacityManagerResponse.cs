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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the EnableCapacityManager operation.
    /// </summary>
    public partial class EnableCapacityManagerResponse : AmazonWebServiceResponse
    {
        private CapacityManagerStatus _capacityManagerStatus;
        private bool? _organizationsAccess;

        /// <summary>
        /// Gets and sets the property CapacityManagerStatus. 
        /// <para>
        ///  The current status of Capacity Manager after the enable operation. 
        /// </para>
        /// </summary>
        public CapacityManagerStatus CapacityManagerStatus
        {
            get { return this._capacityManagerStatus; }
            set { this._capacityManagerStatus = value; }
        }

        // Check to see if CapacityManagerStatus property is set
        internal bool IsSetCapacityManagerStatus()
        {
            return this._capacityManagerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationsAccess. 
        /// <para>
        ///  Indicates whether Organizations access is enabled for cross-account data aggregation.
        /// 
        /// </para>
        /// </summary>
        public bool? OrganizationsAccess
        {
            get { return this._organizationsAccess; }
            set { this._organizationsAccess = value; }
        }

        // Check to see if OrganizationsAccess property is set
        internal bool IsSetOrganizationsAccess()
        {
            return this._organizationsAccess.HasValue; 
        }

    }
}