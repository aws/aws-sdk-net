/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about the AwsOrganizationsSource resource data sync source. A sync source
    /// of this type can synchronize data from AWS Organizations or, if an AWS Organization
    /// is not present, from multiple AWS Regions.
    /// </summary>
    public partial class ResourceDataSyncAwsOrganizationsSource
    {
        private List<ResourceDataSyncOrganizationalUnit> _organizationalUnits = new List<ResourceDataSyncOrganizationalUnit>();
        private string _organizationSourceType;

        /// <summary>
        /// Gets and sets the property OrganizationalUnits. 
        /// <para>
        /// The AWS Organizations organization units included in the sync.
        /// </para>
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
            return this._organizationalUnits != null && this._organizationalUnits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OrganizationSourceType. 
        /// <para>
        /// If an AWS Organization is present, this is either <code>OrganizationalUnits</code>
        /// or <code>EntireOrganization</code>. For <code>OrganizationalUnits</code>, the data
        /// is aggregated from a set of organization units. For <code>EntireOrganization</code>,
        /// the data is aggregated from the entire AWS Organization. 
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