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
    /// An array of search criteria that targets instances using a Key,Value combination that
    /// you specify.
    /// 
    ///  <note> 
    /// <para>
    ///  One or more targets must be specified for maintenance window Run Command-type tasks.
    /// Depending on the task, targets are optional for other maintenance window task types
    /// (Automation, AWS Lambda, and AWS Step Functions). For more information about running
    /// tasks that do not specify targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">Registering
    /// maintenance window tasks without targets</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Supported formats include the following.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Key=InstanceIds,Values=<i>instance-id-1</i>,<i>instance-id-2</i>,<i>instance-id-3</i>
    /// </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Key=tag:<i>my-tag-key</i>,Values=<i>my-tag-value-1</i>,<i>my-tag-value-2</i>
    /// </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Key=tag-key,Values=<i>my-tag-key-1</i>,<i>my-tag-key-2</i> </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Run Command and Maintenance window targets only</b>: <code>Key=resource-groups:Name,Values=<i>resource-group-name</i>
    /// </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Maintenance window targets only</b>: <code>Key=resource-groups:ResourceTypeFilters,Values=<i>resource-type-1</i>,<i>resource-type-2</i>
    /// </code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Automation targets only</b>: <code>Key=ResourceGroup;Values=<i>resource-group-name</i>
    /// </code> 
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
    ///  <b>Maintenance window targets only</b>: <code>Key=resource-groups:ResourceTypeFilters,Values=<i>AWS::EC2::INSTANCE</i>,<i>AWS::EC2::VPC</i>
    /// </code> 
    /// </para>
    ///  
    /// <para>
    /// This example demonstrates how to target only EC2 instances and VPCs in your maintenance
    /// window.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Automation targets only</b>: <code>Key=ResourceGroup,Values=MyResourceGroup</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>State Manager association targets only</b>: <code>Key=InstanceIds,Values=<i>*</i>
    /// </code> 
    /// </para>
    ///  
    /// <para>
    /// This example demonstrates how to target all managed instances in the AWS Region where
    /// the association was created.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about how to send commands that target instances using <code>Key,Value</code>
    /// parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html#send-commands-targeting">Targeting
    /// multiple instances</a> in the <i>AWS Systems Manager User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Target
    {
        private string _key;
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// User-defined criteria for sending commands that target instances that meet the criteria.
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