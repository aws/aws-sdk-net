/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRule operation.
    /// Deletes the specified rule.
    /// 
    ///  
    /// <para>
    /// Before you can delete the rule, you must remove all targets, using <a>RemoveTargets</a>.
    /// </para>
    ///  
    /// <para>
    /// When you delete a rule, incoming events might continue to match to the deleted rule.
    /// Allow a short period of time for changes to take effect.
    /// </para>
    ///  
    /// <para>
    /// Managed rules are rules created and managed by another AWS service on your behalf.
    /// These rules are created by those other AWS services to support functionality in those
    /// services. You can delete these rules using the <code>Force</code> option, but you
    /// should do so only if you are sure the other service is not still using that rule.
    /// </para>
    /// </summary>
    public partial class DeleteRuleRequest : AmazonCloudWatchEventsRequest
    {
        private bool? _force;
        private string _name;

        /// <summary>
        /// Gets and sets the property Force. 
        /// <para>
        /// If this is a managed rule, created by an AWS service on your behalf, you must specify
        /// <code>Force</code> as <code>True</code> to delete the rule. This parameter is ignored
        /// for rules that are not managed rules. You can check whether a rule is a managed rule
        /// by using <code>DescribeRule</code> or <code>ListRules</code> and checking the <code>ManagedBy</code>
        /// field of the response.
        /// </para>
        /// </summary>
        public bool Force
        {
            get { return this._force.GetValueOrDefault(); }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule.
        /// </para>
        /// </summary>
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