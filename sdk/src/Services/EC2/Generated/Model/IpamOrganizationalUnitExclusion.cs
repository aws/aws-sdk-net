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
    /// If your IPAM is integrated with Amazon Web Services Organizations and you add an organizational
    /// unit (OU) exclusion, IPAM will not manage the IP addresses in accounts in that OU
    /// exclusion.
    /// </summary>
    public partial class IpamOrganizationalUnitExclusion
    {
        private string _organizationsEntityPath;

        /// <summary>
        /// Gets and sets the property OrganizationsEntityPath. 
        /// <para>
        /// An Amazon Web Services Organizations entity path. For more information on the entity
        /// path, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_last-accessed-view-data-orgs.html#access_policies_access-advisor-viewing-orgs-entity-path">Understand
        /// the Amazon Web Services Organizations entity path</a> in the <i>Amazon Web Services
        /// Identity and Access Management User Guide</i>.
        /// </para>
        /// </summary>
        public string OrganizationsEntityPath
        {
            get { return this._organizationsEntityPath; }
            set { this._organizationsEntityPath = value; }
        }

        // Check to see if OrganizationsEntityPath property is set
        internal bool IsSetOrganizationsEntityPath()
        {
            return this._organizationsEntityPath != null;
        }

    }
}