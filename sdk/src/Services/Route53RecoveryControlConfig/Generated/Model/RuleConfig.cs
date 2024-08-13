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
    /// The rule configuration for an assertion rule. That is, the criteria that you set for
    /// specific assertion controls (routing controls) that specify how many control states
    /// must be ON after a transaction completes.
    /// </summary>
    public partial class RuleConfig
    {
        private bool? _inverted;
        private int? _threshold;
        private RuleType _type;

        /// <summary>
        /// Gets and sets the property Inverted. 
        /// <para>
        /// Logical negation of the rule. If the rule would usually evaluate true, it's evaluated
        /// as false, and vice versa.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Inverted
        {
            get { return this._inverted; }
            set { this._inverted = value; }
        }

        // Check to see if Inverted property is set
        internal bool IsSetInverted()
        {
            return this._inverted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The value of N, when you specify an ATLEAST rule type. That is, Threshold is the number
        /// of controls that must be set when you specify an ATLEAST type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// A rule can be one of the following: ATLEAST, AND, or OR.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}