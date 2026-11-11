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

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// The options you can specify when you create a grant or a new version of a grant, such
    /// as activation override behavior. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
    /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
    /// </summary>
    public partial class Options
    {
        /// <summary>
        /// Gets and sets the property ActivationOverrideBehavior. 
        /// <para>
        /// An activation option for your grant that determines the behavior of activating a grant.
        /// Activation options can only be used with granted licenses sourced from the Amazon
        /// Web Services Marketplace. Additionally, the operation must activate the grant. For
        /// the <c>CreateGrantVersion</c> operation, specify <c>ACTIVE</c> for the <c>Status</c>
        /// parameter. For the <c>CreateGrant</c> operation, specify <c>ACTIVE</c> for the <c>DesiredStatus</c>
        /// option.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// As a license administrator, you can optionally specify an <c>ActivationOverrideBehavior</c>
        /// when activating a grant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// As a grantor, you can optionally specify an <c>ActivationOverrideBehavior</c> when
        /// you activate a grant for a grantee account in your organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// As a grantee, if the grantor creating the distributed grant doesn’t specify an <c>ActivationOverrideBehavior</c>,
        /// you can optionally specify one when you are activating the grant.
        /// </para>
        ///  </li> </ul> <dl> <dt>DISTRIBUTED_GRANTS_ONLY</dt> <dd> 
        /// <para>
        /// Use this value to activate a grant without replacing any member account’s active grants
        /// for the same product.
        /// </para>
        ///  </dd> <dt>ALL_GRANTS_PERMITTED_BY_ISSUER</dt> <dd> 
        /// <para>
        /// Use this value to activate a grant and disable other active grants in any member accounts
        /// for the same product. This action will also replace their previously activated grants
        /// with this activated grant.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        public ActivationOverrideBehavior ActivationOverrideBehavior { get; set; }

        /// <summary>
        /// Checks to see if the ActivationOverrideBehavior property is set.
        /// </summary>
        internal bool IsSetActivationOverrideBehavior() => this.ActivationOverrideBehavior != null;

        /// <summary>
        /// Gets and sets the property DesiredStatus. 
        /// <para>
        /// The status of the grant after License Manager creates it. The only supported value
        /// is <c>ACTIVE</c>. Specify <c>ACTIVE</c> to create and activate the grant in one request.
        /// </para>
        ///  
        /// <para>
        /// You can specify this option only for the <c>CreateGrant</c> operation, and only when
        /// the grant principal is an organization or an organizational unit (OU). To change the
        /// status of an existing grant, use the <c>Status</c> parameter of the <c>CreateGrantVersion</c>
        /// operation.
        /// </para>
        /// </summary>
        public GrantStatus DesiredStatus { get; set; }

        /// <summary>
        /// Checks to see if the DesiredStatus property is set.
        /// </summary>
        internal bool IsSetDesiredStatus() => this.DesiredStatus != null;
    }
}
