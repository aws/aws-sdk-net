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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the <c>AwsOrganizationsSource</c> resource data sync source. A sync
    /// source of this type can synchronize data from Organizations or, if an Amazon Web Services
    /// organization isn't present, from multiple Amazon Web Services Regions.
    /// </summary>
    public partial class ResourceDataSyncAwsOrganizationsSource
    {
        private List<ResourceDataSyncOrganizationalUnit> _organizationalUnits = AWSConfigs.InitializeCollections ? new List<ResourceDataSyncOrganizationalUnit>() : null;
        private string _organizationSourceType;

        /// <summary>
        /// Gets and sets the property OrganizationalUnits. 
        /// <para>
        /// The Organizations organization units included in the sync.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<ResourceDataSyncOrganizationalUnit> OrganizationalUnits
        {
            get { return this._organizationalUnits; }
            set { this._organizationalUnits = value; }
        }

        // Check to see if OrganizationalUnits property is set
        internal bool IsSetOrganizationalUnits()
        {
            return this._organizationalUnits != null && (this._organizationalUnits.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OrganizationSourceType. 
        /// <para>
        /// If an Amazon Web Services organization is present, this is either <c>OrganizationalUnits</c>
        /// or <c>EntireOrganization</c>. For <c>OrganizationalUnits</c>, the data is aggregated
        /// from a set of organization units. For <c>EntireOrganization</c>, the data is aggregated
        /// from the entire Amazon Web Services organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string OrganizationSourceType
        {
            get { return this._organizationSourceType; }
            set { this._organizationSourceType = value; }
        }

        // Check to see if OrganizationSourceType property is set
        internal bool IsSetOrganizationSourceType()
        {
            return this._organizationSourceType != null;
        }

    }
}