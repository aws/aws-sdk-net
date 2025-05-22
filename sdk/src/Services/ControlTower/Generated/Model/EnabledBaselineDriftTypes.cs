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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// The types of drift that can be detected for an enabled baseline.
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  Amazon Web Services Control Tower detects inheritance drift on the enabled baselines
    /// that target OUs: <c>AWSControlTowerBaseline</c> and <c>BackupBaseline</c>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Amazon Web Services Control Tower does not detect drift on the baselines that apply
    /// to your landing zone: <c>IdentityCenterBaseline</c>, <c>AuditBaseline</c>, <c>LogArchiveBaseline</c>,
    /// <c>BackupCentralVaultBaseline</c>, or <c>BackupAdminBaseline</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/types-of-baselines.html">Types
    /// of baselines</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Baselines enabled on an OU are inherited by its member accounts as child <c>EnabledBaseline</c>
    /// resources. The baseline on the OU serves as the parent <c>EnabledBaseline</c>, which
    /// governs the configuration of each child <c>EnabledBaseline</c>.
    /// </para>
    ///  
    /// <para>
    /// If the baseline configuration of a member account in an OU does not match the configuration
    /// of the parent OU, the parent and child baseline is in a state of inheritance drift.
    /// This drift could occur in the <c>AWSControlTowerBaseline</c> or the <c>BackupBaseline</c>
    /// related to that account.
    /// </para>
    /// </summary>
    public partial class EnabledBaselineDriftTypes
    {
        private EnabledBaselineInheritanceDrift _inheritance;

        /// <summary>
        /// Gets and sets the property Inheritance. 
        /// <para>
        /// At least one account within the target OU does not match the baseline configuration
        /// defined on that OU. An account is in inheritance drift when it does not match the
        /// configuration of a parent OU, possibly a new parent OU, if the account is moved. 
        /// </para>
        /// </summary>
        public EnabledBaselineInheritanceDrift Inheritance
        {
            get { return this._inheritance; }
            set { this._inheritance = value; }
        }

        // Check to see if Inheritance property is set
        internal bool IsSetInheritance()
        {
            return this._inheritance != null;
        }

    }
}