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
 * Do not modify this file. This file is generated from the partnercentral-selling-2022-07-26.normal.json service model.
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
namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Represents the payload of an Engagement context. The structure of this payload varies
    /// based on the context type specified in the EngagementContextDetails.
    /// </summary>
    public partial class EngagementContextPayload
    {
        private CustomerProjectsContext _customerProject;

        /// <summary>
        /// Gets and sets the property CustomerProject. 
        /// <para>
        /// Contains detailed information about a customer project when the context type is "CustomerProject".
        /// This field is present only when the Type in EngagementContextDetails is set to "CustomerProject".
        /// 
        /// </para>
        /// </summary>
        public CustomerProjectsContext CustomerProject
        {
            get { return this._customerProject; }
            set { this._customerProject = value; }
        }

        // Check to see if CustomerProject property is set
        internal bool IsSetCustomerProject()
        {
            return this._customerProject != null;
        }

    }
}