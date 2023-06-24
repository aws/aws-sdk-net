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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// The deregistration policy for the data that's stored in Audit Manager. You can use
    /// this attribute to determine how your data is handled when you <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_DeregisterAccount.html">deregister
    /// Audit Manager</a>.
    /// 
    ///  
    /// <para>
    /// By default, Audit Manager retains evidence data for two years from the time of its
    /// creation. Other Audit Manager resources (including assessments, custom controls, and
    /// custom frameworks) remain in Audit Manager indefinitely, and are available if you
    /// <a href="https://docs.aws.amazon.com/audit-manager/latest/APIReference/API_RegisterAccount.html">re-register
    /// Audit Manager</a> in the future. For more information about data retention, see <a
    /// href="https://docs.aws.amazon.com/audit-manager/latest/userguide/data-protection.html">Data
    /// Protection</a> in the <i>Audit Manager User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// If you choose to delete all data, this action permanently deletes all evidence data
    /// in your account within seven days. It also deletes all of the Audit Manager resources
    /// that you created, including assessments, custom controls, and custom frameworks. Your
    /// data will not be available if you re-register Audit Manager in the future.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeregistrationPolicy
    {
        private DeleteResources _deleteResources;

        /// <summary>
        /// Gets and sets the property DeleteResources. 
        /// <para>
        /// Specifies which Audit Manager data will be deleted when you deregister Audit Manager.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you set the value to <code>ALL</code>, all of your data is deleted within seven
        /// days of deregistration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you set the value to <code>DEFAULT</code>, none of your data is deleted at the
        /// time of deregistration. However, keep in mind that the Audit Manager data retention
        /// policy still applies. As a result, any evidence data will be deleted two years after
        /// its creation date. Your other Audit Manager resources will continue to exist indefinitely.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DeleteResources DeleteResources
        {
            get { return this._deleteResources; }
            set { this._deleteResources = value; }
        }

        // Check to see if DeleteResources property is set
        internal bool IsSetDeleteResources()
        {
            return this._deleteResources != null;
        }

    }
}