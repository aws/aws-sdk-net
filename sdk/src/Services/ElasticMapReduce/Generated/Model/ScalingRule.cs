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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// A scale-in or scale-out rule that defines scaling activity, including the CloudWatch
    /// metric alarm that triggers activity, how Amazon EC2 instances are added or removed,
    /// and the periodicity of adjustments. The automatic scaling policy for an instance group
    /// can comprise one or more automatic scaling rules.
    /// </summary>
    public partial class ScalingRule
    {
        private ScalingAction _action;
        private string _description;
        private string _name;
        private ScalingTrigger _trigger;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The conditions that trigger an automatic scaling activity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A friendly, more verbose description of the automatic scaling rule.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name used to identify an automatic scaling rule. Rule names must be unique within
        /// a scaling policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Trigger. 
        /// <para>
        /// The CloudWatch alarm definition that determines when automatic scaling activity is
        /// triggered.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ScalingTrigger Trigger
        {
            get { return this._trigger; }
            set { this._trigger = value; }
        }

        // Check to see if Trigger property is set
        internal bool IsSetTrigger()
        {
            return this._trigger != null;
        }

    }
}