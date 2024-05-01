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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Provides the runtime system, policy definition, and whether debug logging enabled.
    /// You can specify the following CustomPolicyDetails parameter values only for Config
    /// Custom Policy rules.
    /// </summary>
    public partial class CustomPolicyDetails
    {
        private bool? _enableDebugLogDelivery;
        private string _policyRuntime;
        private string _policyText;

        /// <summary>
        /// Gets and sets the property EnableDebugLogDelivery. 
        /// <para>
        /// The boolean expression for enabling debug logging for your Config Custom Policy rule.
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? EnableDebugLogDelivery
        {
            get { return this._enableDebugLogDelivery; }
            set { this._enableDebugLogDelivery = value; }
        }

        // Check to see if EnableDebugLogDelivery property is set
        internal bool IsSetEnableDebugLogDelivery()
        {
            return this._enableDebugLogDelivery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PolicyRuntime. 
        /// <para>
        /// The runtime system for your Config Custom Policy rule. Guard is a policy-as-code language
        /// that allows you to write policies that are enforced by Config Custom Policy rules.
        /// For more information about Guard, see the <a href="https://github.com/aws-cloudformation/cloudformation-guard">Guard
        /// GitHub Repository</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PolicyRuntime
        {
            get { return this._policyRuntime; }
            set { this._policyRuntime = value; }
        }

        // Check to see if PolicyRuntime property is set
        internal bool IsSetPolicyRuntime()
        {
            return this._policyRuntime != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyText. 
        /// <para>
        /// The policy definition containing the logic for your Config Custom Policy rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10000)]
        public string PolicyText
        {
            get { return this._policyText; }
            set { this._policyText = value; }
        }

        // Check to see if PolicyText property is set
        internal bool IsSetPolicyText()
        {
            return this._policyText != null;
        }

    }
}