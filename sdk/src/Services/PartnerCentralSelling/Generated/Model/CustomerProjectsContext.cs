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
    /// The CustomerProjects structure in Engagements offers a flexible framework for managing
    /// customer-project relationships. It supports multiple customers per Engagement and
    /// multiple projects per customer, while also allowing for customers without projects
    /// and projects without specific customers. 
    /// 
    ///  
    /// <para>
    /// All Engagement members have full visibility of customers and their associated projects,
    /// enabling the capture of relevant context even when project details are not fully defined.
    /// This structure also facilitates targeted invitations, allowing partners to focus on
    /// specific customers and their business problems when sending Engagement invitations.
    /// 
    /// </para>
    /// </summary>
    public partial class CustomerProjectsContext
    {
        private EngagementCustomer _customer;
        private EngagementCustomerProjectDetails _project;

        /// <summary>
        /// Gets and sets the property Customer.
        /// </summary>
        public EngagementCustomer Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }

        // Check to see if Customer property is set
        internal bool IsSetCustomer()
        {
            return this._customer != null;
        }

        /// <summary>
        /// Gets and sets the property Project. 
        /// <para>
        /// Information about the customer project associated with the Engagement.
        /// </para>
        /// </summary>
        public EngagementCustomerProjectDetails Project
        {
            get { return this._project; }
            set { this._project = value; }
        }

        // Check to see if Project property is set
        internal bool IsSetProject()
        {
            return this._project != null;
        }

    }
}