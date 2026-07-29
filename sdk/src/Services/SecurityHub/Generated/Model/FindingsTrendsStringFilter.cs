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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// A filter for string-based fields in findings trend data.
    /// </summary>
    public partial class FindingsTrendsStringFilter
    {
        private FindingsTrendsStringField _fieldName;
        private StringFilter _filter;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The name of the findings field to filter on. You can specify one of the following
        /// fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account_id</c> – The Amazon Web Services account ID associated with the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>region</c> – The Amazon Web Services Region associated with the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>finding_types</c> – The finding types associated with the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>finding_status</c> – The status of the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>finding_cve_ids</c> – The Common Vulnerabilities and Exposures (CVE) identifiers
        /// associated with the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>finding_compliance_status</c> – The compliance status of the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>finding_control_id</c> – The identifier of the security control associated with
        /// the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>finding_class_name</c> – The finding class, such as <c>Compliance Finding</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>finding_provider</c> – The name of the product that generated the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>finding_activity_name</c> – The activity name associated with the finding.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource_cloud_providers</c> – The cloud providers of the resources that the finding
        /// is associated with. Valid values are <c>AWS</c> and <c>Azure</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource_regions</c> – The Regions of the associated resources. For an Amazon
        /// Web Services resource, this is the Amazon Web Services Region. For an Azure resource,
        /// this is the Azure Region, such as <c>eastus</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource_owner_ids</c> – The identifiers of the accounts that own the associated
        /// resources. For an Amazon Web Services resource, this is the Amazon Web Services account
        /// ID. For an Azure resource, this is the Azure subscription ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resource_owner_organization_ids</c> – The identifiers of the organizations that
        /// own the associated resources. For an Amazon Web Services resource, this is the Amazon
        /// Web Services organization ID. For an Azure resource, this is the Azure tenant ID.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public FindingsTrendsStringField FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public StringFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

    }
}