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

#pragma warning disable CS0612,CS0618,CS1570
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
    ///  
    /// <para>
    ///  <b>For all Systems Manager tools:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Key=tag-key,Values=tag-value-1,tag-value-2</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>For Automation and Change Manager:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Key=tag:tag-key,Values=tag-value</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=ResourceGroup,Values=resource-group-name</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=ParameterValues,Values=value-1,value-2,value-3</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To target all instances in the Amazon Web Services Region:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Key=AWS::EC2::Instance,Values=*</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=InstanceIds,Values=*</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>For Run Command and Maintenance Windows:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Key=InstanceIds,Values=instance-id-1,instance-id-2,instance-id-3</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=tag:tag-key,Values=tag-value-1,tag-value-2</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=resource-groups:Name,Values=resource-group-name</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Additionally, Maintenance Windows support targeting resource types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Key=resource-groups:ResourceTypeFilters,Values=resource-type-1,resource-type-2</c>
    /// 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    ///  <b>For State Manager:</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Key=InstanceIds,Values=instance-id-1,instance-id-2,instance-id-3</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Key=tag:tag-key,Values=tag-value-1,tag-value-2</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To target all instances in the Amazon Web Services Region:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>Key=InstanceIds,Values=*</c> 
    /// </para>
    ///  </li> </ul> </li> </ul> 
    /// <para>
    /// For more information about how to send commands that target managed nodes using <c>Key,Value</c>
    /// parameters, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/send-commands-multiple.html#send-commands-targeting">Targeting
    /// multiple managed nodes</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
    /// </para>
    /// </summary>
    public partial class Target
    {
        private string _key;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

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
        /// User-defined criteria that maps to <c>Key</c>. For example, if you specified <c>tag:ServerRole</c>,
        /// you could specify <c>value:WebServer</c> to run a command on instances that include
        /// EC2 tags of <c>ServerRole,WebServer</c>. 
        /// </para>
        ///  
        /// <para>
        /// Depending on the type of target, the maximum number of values for a key might be lower
        /// than the global maximum of 50.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._values != null && (this._values.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}