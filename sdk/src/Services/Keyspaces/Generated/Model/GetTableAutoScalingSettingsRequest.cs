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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// Container for the parameters to the GetTableAutoScalingSettings operation.
    /// Returns auto scaling related settings of the specified table in JSON format. If the
    /// table is a multi-Region table, the Amazon Web Services Region specific auto scaling
    /// settings of the table are included.
    /// 
    ///  
    /// <para>
    /// Amazon Keyspaces auto scaling helps you provision throughput capacity for variable
    /// workloads efficiently by increasing and decreasing your table's read and write capacity
    /// automatically in response to application traffic. For more information, see <a href="https://docs.aws.amazon.com/keyspaces/latest/devguide/autoscaling.html">Managing
    /// throughput capacity automatically with Amazon Keyspaces auto scaling</a> in the <i>Amazon
    /// Keyspaces Developer Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    ///  <c>GetTableAutoScalingSettings</c> can't be used as an action in an IAM policy.
    /// </para>
    ///  </important> 
    /// <para>
    /// To define permissions for <c>GetTableAutoScalingSettings</c>, you must allow the following
    /// two actions in the IAM policy statement's <c>Action</c> element:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>application-autoscaling:DescribeScalableTargets</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>application-autoscaling:DescribeScalingPolicies</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class GetTableAutoScalingSettingsRequest : AmazonKeyspacesRequest
    {
        private string _keyspaceName;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        /// The name of the keyspace.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

    }
}