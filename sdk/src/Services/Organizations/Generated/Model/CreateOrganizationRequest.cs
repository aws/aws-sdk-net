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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOrganization operation.
    /// Creates an AWS organization. The account whose user is calling the CreateOrganization
    /// operation automatically becomes the <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/orgs_getting-started_concepts.html#account">master
    /// account</a> of the new organization.
    /// 
    ///  
    /// <para>
    /// This operation must be called using credentials from the account that is to become
    /// the new organization's master account. The principal must also have the relevant IAM
    /// permissions.
    /// </para>
    ///  
    /// <para>
    /// By default (or if you set the <code>FeatureSet</code> parameter to <code>ALL</code>),
    /// the new organization is created with all features enabled and service control policies
    /// automatically enabled in the root. If you instead choose to create the organization
    /// supporting only the consolidated billing features by setting the <code>FeatureSet</code>
    /// parameter to <code>CONSOLIDATED_BILLING"</code>, then no policy types are enabled
    /// by default and you cannot use organization policies.
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
        ///  <i>CONSOLIDATED_BILLING</i>: All member accounts have their bills consolidated to
        /// and paid by the master account. For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set-cb-only">Consolidated
        /// Billing</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>ALL</i>: In addition to all the features supported by the consolidated billing
        /// feature set, the master account can also apply any type of policy to any member account
        /// in the organization. For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#feature-set-all">All
        /// features</a> in the <i>AWS Organizations User Guide</i>.
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