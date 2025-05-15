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
    /// The drift summary of the enabled baseline. Amazon Web Services Control Tower reports
    /// inheritance drift when an enabled baseline configuration of a member account is different
    /// than the configuration that applies to the OU. Amazon Web Services Control Tower reports
    /// this type of drift for a parent or child enabled baseline. One way to repair this
    /// drift by resetting the parent enabled baseline, on the OU.
    /// 
    ///  
    /// <para>
    /// For example, you may see this type of drift if you move accounts between OUs, but
    /// the accounts are not yet (re-)enrolled.
    /// </para>
    /// </summary>
    public partial class EnabledBaselineDriftStatusSummary
    {
        private EnabledBaselineDriftTypes _types;

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// The types of drift that can be detected for an enabled baseline. Amazon Web Services
        /// Control Tower detects inheritance drift on enabled baselines that apply at the OU
        /// level. 
        /// </para>
        /// </summary>
        public EnabledBaselineDriftTypes Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null;
        }

    }
}