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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// The rule that a simulated user matches.
    /// </summary>
    public partial class MobileDeviceAccessMatchedRule
    {
        private string _mobileDeviceAccessRuleId;
        private string _name;

        /// <summary>
        /// Gets and sets the property MobileDeviceAccessRuleId. 
        /// <para>
        /// Identifier of the rule that a simulated user matches.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string MobileDeviceAccessRuleId
        {
            get { return this._mobileDeviceAccessRuleId; }
            set { this._mobileDeviceAccessRuleId = value; }
        }

        // Check to see if MobileDeviceAccessRuleId property is set
        internal bool IsSetMobileDeviceAccessRuleId()
        {
            return this._mobileDeviceAccessRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of a rule that a simulated user matches.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}