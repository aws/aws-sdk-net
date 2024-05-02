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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
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
namespace Amazon.Route53RecoveryControlConfig.Model
{
    /// <summary>
    /// This is the response object from the CreateSafetyRule operation.
    /// </summary>
    public partial class CreateSafetyRuleResponse : AmazonWebServiceResponse
    {
        private AssertionRule _assertionRule;
        private GatingRule _gatingRule;

        /// <summary>
        /// Gets and sets the property AssertionRule. 
        /// <para>
        /// The assertion rule created.
        /// </para>
        /// </summary>
        public AssertionRule AssertionRule
        {
            get { return this._assertionRule; }
            set { this._assertionRule = value; }
        }

        // Check to see if AssertionRule property is set
        internal bool IsSetAssertionRule()
        {
            return this._assertionRule != null;
        }

        /// <summary>
        /// Gets and sets the property GatingRule. 
        /// <para>
        /// The gating rule created.
        /// </para>
        /// </summary>
        public GatingRule GatingRule
        {
            get { return this._gatingRule; }
            set { this._gatingRule = value; }
        }

        // Check to see if GatingRule property is set
        internal bool IsSetGatingRule()
        {
            return this._gatingRule != null;
        }

    }
}