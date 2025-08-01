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
    /// One or more filters. Use a filter to return a more specific list of results.
    /// 
    ///  
    /// <para>
    ///  <b>Example formats for the <c>aws ssm get-inventory</c> command:</b> 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.AgentType,Values=amazon-ssm-agent,Type=Equal</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.AgentVersion,Values=3.3.2299.0,Type=Equal</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.ComputerName,Values=ip-192.0.2.0.us-east-2.compute.internal,Type=Equal</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.InstanceId,Values=i-0a4cd6ceffEXAMPLE,i-1a2b3c4d5e6EXAMPLE,Type=Equal</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.InstanceStatus,Values=Active,Type=Equal</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.IpAddress,Values=198.51.100.0,Type=Equal</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.PlatformName,Values="Amazon Linux",Type=Equal</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.PlatformType,Values=Linux,Type=Equal</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.PlatformVersion,Values=2023,Type=BeginWith</c>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>--filters Key=AWS:InstanceInformation.ResourceType,Values=EC2Instance,Type=Equal</c>
    /// 
    /// </para>
    /// </summary>
    public partial class InventoryFilter
    {
        private string _key;
        private InventoryQueryOperatorType _type;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of filter.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Exists</c> filter must be used with aggregators. For more information, see
        /// <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/inventory-aggregate.html">Aggregating
        /// inventory data</a> in the <i>Amazon Web Services Systems Manager User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        public InventoryQueryOperatorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// Inventory filter values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=40)]
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