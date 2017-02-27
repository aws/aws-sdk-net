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
    /// By default, a new organization is created in full-control mode and service control
    /// policies are automatically enabled in the root. If you instead choose to create the
    /// organization in billing mode by setting the <code>Mode</code> parameter to <code>BILLING"</code>,
    /// then no policy types are enabled by default.
    /// </para>
    /// </summary>
    public partial class CreateOrganizationRequest : AmazonOrganizationsRequest
    {
        private OrganizationMode _mode;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// Specifies the mode that the new organization is in. Each mode supports different levels
        /// of functionality.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>BILLING</i>: All member accounts have their bills consolidated to and paid by
        /// the master account. For more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#billing-mode">Billing
        /// mode</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you use the AWS Organizations console, you can create an organization only in full-control
        /// mode. To create an organization in billing mode, you must call this API through a
        /// tool such as the AWS CLI or an AWS SDK.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <i>FULL_CONTROL</i>: In addition to all the features of billing mode, the master
        /// account can apply any type of policy to any member account in the organization. For
        /// more information, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_getting-started_concepts.html#full-control-mode">Full-control
        /// mode</a> in the <i>AWS Organizations User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OrganizationMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}