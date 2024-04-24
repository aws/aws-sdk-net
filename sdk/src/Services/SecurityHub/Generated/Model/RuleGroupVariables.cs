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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Additional settings to use in the specified rules.
    /// </summary>
    public partial class RuleGroupVariables
    {
        private RuleGroupVariablesIpSetsDetails _ipSets;
        private RuleGroupVariablesPortSetsDetails _portSets;

        /// <summary>
        /// Gets and sets the property IpSets. 
        /// <para>
        /// A list of IP addresses and address ranges, in CIDR notation.
        /// </para>
        /// </summary>
        public RuleGroupVariablesIpSetsDetails IpSets
        {
            get { return this._ipSets; }
            set { this._ipSets = value; }
        }

        // Check to see if IpSets property is set
        internal bool IsSetIpSets()
        {
            return this._ipSets != null;
        }

        /// <summary>
        /// Gets and sets the property PortSets. 
        /// <para>
        /// A list of port ranges.
        /// </para>
        /// </summary>
        public RuleGroupVariablesPortSetsDetails PortSets
        {
            get { return this._portSets; }
            set { this._portSets = value; }
        }

        // Check to see if PortSets property is set
        internal bool IsSetPortSets()
        {
            return this._portSets != null;
        }

    }
}