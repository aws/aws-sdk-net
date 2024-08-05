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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Controls on the query specifications that can be run on an associated configured
    /// table.
    /// </summary>
    public partial class ConfiguredTableAssociationAnalysisRulePolicy
    {
        private ConfiguredTableAssociationAnalysisRulePolicyV1 _v1;

        /// <summary>
        /// Gets and sets the property V1. 
        /// <para>
        ///  The policy for the configured table association analysis rule.
        /// </para>
        /// </summary>
        public ConfiguredTableAssociationAnalysisRulePolicyV1 V1
        {
            get { return this._v1; }
            set { this._v1 = value; }
        }

        // Check to see if V1 property is set
        internal bool IsSetV1()
        {
            return this._v1 != null;
        }

    }
}