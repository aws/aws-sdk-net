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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Represents the updated payload of an engagement context. The structure of this payload
    /// varies based on the context type being updated.
    /// </summary>
    public partial class UpdateEngagementContextPayload
    {
        /// <summary>
        /// Gets and sets the property CustomerProject.
        /// </summary>
        public CustomerProjectsContext CustomerProject { get; set; }

        /// <summary>
        /// Checks to see if the CustomerProject property is set.
        /// </summary>
        internal bool IsSetCustomerProject() => this.CustomerProject != null;

        /// <summary>
        /// Gets and sets the property Lead. 
        /// <para>
        /// Contains updated information about a lead when the context type is "Lead". This field
        /// is present only when updating a lead context within the engagement.
        /// </para>
        /// </summary>
        public UpdateLeadContext Lead { get; set; }

        /// <summary>
        /// Checks to see if the Lead property is set.
        /// </summary>
        internal bool IsSetLead() => this.Lead != null;

        /// <summary>
        /// Gets and sets the property ProspectingResult. 
        /// <para>
        /// Contains updated prospecting result data when the context type is "ProspectingResult".
        /// This field includes enriched data and insights that the system generates when a partner
        /// runs an autonomous prospecting job on leads.
        /// </para>
        /// </summary>
        public ProspectingResult ProspectingResult { get; set; }

        /// <summary>
        /// Checks to see if the ProspectingResult property is set.
        /// </summary>
        internal bool IsSetProspectingResult() => this.ProspectingResult != null;
    }
}
