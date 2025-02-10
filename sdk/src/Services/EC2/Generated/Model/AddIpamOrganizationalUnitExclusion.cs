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
    /// Add an Organizational Unit (OU) exclusion to your IPAM. If your IPAM is integrated
    /// with Amazon Web Services Organizations and you add an organizational unit (OU) exclusion,
    /// IPAM will not manage the IP addresses in accounts in that OU exclusion. There is a
    /// limit on the number of exclusions you can create. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/ipam/quotas-ipam.html">Quotas
    /// for your IPAM</a> in the <i>Amazon VPC IPAM User Guide</i>.
    /// </summary>
    public partial class AddIpamOrganizationalUnitExclusion
    {
        private string _organizationsEntityPath;

        /// <summary>
        /// Gets and sets the property OrganizationsEntityPath. 
        /// <para>
        /// An Amazon Web Services Organizations entity path. Build the path for the OU(s) using
        /// Amazon Web Services Organizations IDs separated by a <c>/</c>. Include all child OUs
        /// by ending the path with <c>/*</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Example 1
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Path to a child OU: <c>o-a1b2c3d4e5/r-f6g7h8i9j0example/ou-ghi0-awsccccc/ou-jkl0-awsddddd/</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In this example, <c>o-a1b2c3d4e5</c> is the organization ID, <c>r-f6g7h8i9j0example</c>
        /// is the root ID , <c>ou-ghi0-awsccccc</c> is an OU ID, and <c>ou-jkl0-awsddddd</c>
        /// is a child OU ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// IPAM will not manage the IP addresses in accounts in the child OU.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Example 2
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Path where all child OUs will be part of the exclusion: <c>o-a1b2c3d4e5/r-f6g7h8i9j0example/ou-ghi0-awsccccc/*</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// In this example, IPAM will not manage the IP addresses in accounts in the OU (<c>ou-ghi0-awsccccc</c>)
        /// or in accounts in any OUs that are children of the OU.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information on how to construct an entity path, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_policies_last-accessed-view-data-orgs.html#access_policies_access-advisor-viewing-orgs-entity-path">Understand
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