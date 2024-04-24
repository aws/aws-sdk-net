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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOrganization operation.
    /// Creates an Amazon Web Services organization. The account whose user is calling the
    /// <c>CreateOrganization</c> operation automatically becomes the <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#account">management
    /// account</a> of the new organization.
    /// 
    ///  
    /// <para>
    /// This operation must be called using credentials from the account that is to become
    /// the new organization's management account. The principal must also have the relevant
    /// IAM permissions.
    /// </para>
    ///  
    /// <para>
    /// By default (or if you set the <c>FeatureSet</c> parameter to <c>ALL</c>), the new
    /// organization is created with all features enabled and service control policies automatically
    /// enabled in the root. If you instead choose to create the organization supporting only
    /// the consolidated billing features by setting the <c>FeatureSet</c> parameter to <c>CONSOLIDATED_BILLING</c>,
    /// no policy types are enabled by default and you can't use organization policies.
    /// </para>
    /// </summary>
    public partial class CreateOrganizationRequest : AmazonOrganizationsRequest
    {
        private OrganizationFeatureSet _featureSet;

        /// <summary>
        /// Gets and sets the property FeatureSet. 
        /// <para>
        /// Specifies the feature set supported by the new organization. Each feature set supports
        /// different levels of functionality.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONSOLIDATED_BILLING</c>: All member accounts have their bills consolidated to
        /// and paid by the management account. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set-cb-only">Consolidated
        /// billing</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  The consolidated billing feature subset isn't available for organizations in the
        /// Amazon Web Services GovCloud (US) Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALL</c>: In addition to all the features supported by the consolidated billing
        /// feature set, the management account can also apply any policy type to any member account
        /// in the organization. For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set-all">All
        /// features</a> in the <i>Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OrganizationFeatureSet FeatureSet
        {
            get { return this._featureSet; }
            set { this._featureSet = value; }
        }

        // Check to see if FeatureSet property is set
        internal bool IsSetFeatureSet()
        {
            return this._featureSet != null;
        }

    }
}