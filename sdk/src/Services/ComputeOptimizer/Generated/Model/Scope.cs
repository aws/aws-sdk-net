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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
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
namespace Amazon.ComputeOptimizer.Model
{
    /// <summary>
    /// Describes the scope of a recommendation preference.
    /// 
    ///  
    /// <para>
    /// Recommendation preferences can be created at the organization level (for management
    /// accounts of an organization only), account level, and resource level. For more information,
    /// see <a href="https://docs.aws.amazon.com/compute-optimizer/latest/ug/enhanced-infrastructure-metrics.html">Activating
    /// enhanced infrastructure metrics</a> in the <i>Compute Optimizer User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// You cannot create recommendation preferences for Auto Scaling groups at the organization
    /// and account levels. You can create recommendation preferences for Auto Scaling groups
    /// only at the resource level by specifying a scope name of <c>ResourceArn</c> and a
    /// scope value of the Auto Scaling group Amazon Resource Name (ARN). This will configure
    /// the preference for all instances that are part of the specified Auto Scaling group.
    /// You also cannot create recommendation preferences at the resource level for instances
    /// that are part of an Auto Scaling group. You can create recommendation preferences
    /// at the resource level only for standalone instances.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class Scope
    {
        private ScopeName _name;
        private string _value;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the scope.
        /// </para>
        ///  
        /// <para>
        /// The following scopes are possible:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Organization</c> - Specifies that the recommendation preference applies at the
        /// organization level, for all member accounts of an organization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccountId</c> - Specifies that the recommendation preference applies at the account
        /// level, for all resources of a given resource type in an account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceArn</c> - Specifies that the recommendation preference applies at the
        /// individual resource level.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ScopeName Name
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
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the scope.
        /// </para>
        ///  
        /// <para>
        /// If you specified the <c>name</c> of the scope as:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Organization</c> - The <c>value</c> must be <c>ALL_ACCOUNTS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AccountId</c> - The <c>value</c> must be a 12-digit Amazon Web Services account
        /// ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceArn</c> - The <c>value</c> must be the Amazon Resource Name (ARN) of an
        /// EC2 instance or an Auto Scaling group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only EC2 instance and Auto Scaling group ARNs are currently supported.
        /// </para>
        /// </summary>
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}