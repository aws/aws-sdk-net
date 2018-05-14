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
    /// Container for the parameters to the EnableAllFeatures operation.
    /// Enables all features in an organization. This enables the use of organization policies
    /// that can restrict the services and actions that can be called in each account. Until
    /// you enable all features, you have access only to consolidated billing, and you can't
    /// use any of the advanced account administration features that AWS Organizations supports.
    /// For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_org_support-all-features.html">Enabling
    /// All Features in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// This operation is required only for organizations that were created explicitly with
    /// only the consolidated billing features enabled. Calling this operation sends a handshake
    /// to every invited account in the organization. The feature set change can be finalized
    /// and the additional features enabled only after all administrators in the invited accounts
    /// approve the change by accepting the handshake.
    /// </para>
    ///  </important> 
    /// <para>
    /// After you enable all features, you can separately enable or disable individual policy
    /// types in a root using <a>EnablePolicyType</a> and <a>DisablePolicyType</a>. To see
    /// the status of policy types in a root, use <a>ListRoots</a>.
    /// </para>
    ///  
    /// <para>
    /// After all invited member accounts accept the handshake, you finalize the feature set
    /// change by accepting the handshake that contains <code>"Action": "ENABLE_ALL_FEATURES"</code>.
    /// This completes the change.
    /// </para>
    ///  
    /// <para>
    /// After you enable all features in your organization, the master account in the organization
    /// can apply policies on all member accounts. These policies can restrict what users
    /// and even administrators in those accounts can do. The master account can apply policies
    /// that prevent accounts from leaving the organization. Ensure that your account administrators
    /// are aware of this.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account. 
    /// </para>
    /// </summary>
    public partial class EnableAllFeaturesRequest : AmazonOrganizationsRequest
    {

    }
}