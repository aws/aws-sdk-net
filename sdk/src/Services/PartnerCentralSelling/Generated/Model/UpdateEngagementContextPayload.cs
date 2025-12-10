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
    /// Represents the updated payload of an engagement context. The structure of this payload
    /// varies based on the context type being updated.
    /// </summary>
    public partial class UpdateEngagementContextPayload
    {
        private CustomerProjectsContext _customerProject;
        private UpdateLeadContext _lead;

        /// <summary>
        /// Gets and sets the property CustomerProject.
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

        /// <summary>
        /// Gets and sets the property Lead. 
        /// <para>
        /// Contains updated information about a lead when the context type is "Lead". This field
        /// is present only when updating a lead context within the engagement.
        /// </para>
        /// </summary>
        public UpdateLeadContext Lead
        {
            get { return this._lead; }
            set { this._lead = value; }
        }

        // Check to see if Lead property is set
        internal bool IsSetLead()
        {
            return this._lead != null;
        }

    }
}