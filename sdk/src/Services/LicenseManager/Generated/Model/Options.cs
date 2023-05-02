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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// The options you can specify when you create a new version of a grant, such as activation
    /// override behavior. For more information, see <a href="https://docs.aws.amazon.com/license-manager/latest/userguide/granted-licenses.html">Granted
    /// licenses in License Manager</a> in the <i>License Manager User Guide</i>.
    /// </summary>
    public partial class Options
    {
        private ActivationOverrideBehavior _activationOverrideBehavior;

        /// <summary>
        /// Gets and sets the property ActivationOverrideBehavior. 
        /// <para>
        /// An activation option for your grant that determines the behavior of activating a grant.
        /// Activation options can only be used with granted licenses sourced from the Amazon
        /// Web Services Marketplace. Additionally, the operation must specify the value of <code>ACTIVE</code>
        /// for the <code>Status</code> parameter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// As a license administrator, you can optionally specify an <code>ActivationOverrideBehavior</code>
        /// when activating a grant.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// As a grantor, you can optionally specify an <code>ActivationOverrideBehavior</code>
        /// when you activate a grant for a grantee account in your organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// As a grantee, if the grantor creating the distributed grant doesn’t specify an <code>ActivationOverrideBehavior</code>,
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
        public ActivationOverrideBehavior ActivationOverrideBehavior
        {
            get { return this._activationOverrideBehavior; }
            set { this._activationOverrideBehavior = value; }
        }

        // Check to see if ActivationOverrideBehavior property is set
        internal bool IsSetActivationOverrideBehavior()
        {
            return this._activationOverrideBehavior != null;
        }

    }
}