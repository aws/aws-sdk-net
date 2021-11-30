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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An array of search criteria that targets managed nodes using a key-value pair that
    /// you specify.
    /// 
    ///  <note> 
    /// <para>
    ///  One or more targets must be specified for maintenance window Run Command-type tasks.
    /// Depending on the task, targets are optional for other maintenance window task types
    /// (Automation, Lambda, and Step Functions). For more information about running tasks
    /// that don't specify targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">Registering
    /// maintenance window tasks without targets</a> in the <i>Amazon Web Services Systems
    /// Manager User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Supported formats include the following.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Key=InstanceIds,Values=&lt;instance-id-1&gt;,&lt;instance-id-2&gt;,&lt;instance-id-3&gt;</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Key=tag:&lt;my-tag-key&gt;,Values=&lt;my-tag-value-1&gt;,&lt;my-tag-value-2&gt;</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Key=tag-key,Values=&lt;my-tag-key-1&gt;,&lt;my-tag-key-2&gt;</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Run Command and Maintenance window targets only</b>: <code>Key=resource-groups:Name,Values=&lt;resource-group-name&gt;</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Maintenance window targets only</b>: <code>Key=resource-groups:ResourceTypeFilters,Values=&lt;resource-type-1&gt;,&lt;resource-type-2&gt;</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Automation targets only</b>: <code>Key=ResourceGroup;Values=&lt;resource-group-name&gt;</code>
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For example:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Key=InstanceIds,Values=i-02573cafcfEXAMPLE,i-0471e04240EXAMPLE,i-07782c72faEXAMPLE</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Key=tag:CostCenter,Values=CostCenter1,CostCenter2,CostCenter3</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Key=tag-key,Values=Name,Instance-Type,CostCenter</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Run Command and Maintenance window targets only</b>: <code>Key=resource-groups:Name,Values=ProductionResourceGroup</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// This example demonstrates how to target all resources in the resource group <b>ProductionResourceGroup</b>
    /// in your maintenance window.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Maintenance window targets only</b>: <code>Key=resource-groups:ResourceTypeFilters,Values=AWS::EC2::INSTANCE,AWS::EC2::VPC</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// This example demonstrates how to target only Amazon Elastic Compute Cloud (Amazon
    /// EC2) instances and VPCs in your maintenance window.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Automation targets only</b>: <code>Key=ResourceGroup,Values=MyResourceGroup</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>State Manager association targets only</b>: <code>Key=InstanceIds,Values=*</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// This example demonstrates how to target all managed instances in the Amazon Web Services
    /// Region where the association was created.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about how to send commands that target managed nodes using <code>Key,Value</code>
    /// parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html#send-commands-targeting">Targeting
    /// multiple instances</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Target
    {
        private string _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// User-defined criteria for sending commands that target managed nodes that meet the
        /// criteria.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=163)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// User-defined criteria that maps to <code>Key</code>. For example, if you specified
        /// <code>tag:ServerRole</code>, you could specify <code>value:WebServer</code> to run
        /// a command on instances that include EC2 tags of <code>ServerRole,WebServer</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Depending on the type of target, the maximum number of values for a key might be lower
        /// than the global maximum of 50.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}