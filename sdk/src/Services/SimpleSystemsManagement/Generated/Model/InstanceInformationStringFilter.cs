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
    /// The filters to describe or get information about your managed nodes.
    /// </summary>
    public partial class InstanceInformationStringFilter
    {
        private string _key;
        private List<string> _values = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The filter key name to describe your managed nodes.
        /// </para>
        ///  
        /// <para>
        /// Valid filter key values: ActivationIds | AgentVersion | AssociationStatus | IamRole
        /// | InstanceIds | PingStatus | PlatformType | ResourceType | SourceIds | SourceTypes
        /// | "tag-key" | "tag:<c>{keyname}</c> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid values for the <c>AssociationStatus</c> filter key: Success | Pending | Failed
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid values for the <c>PingStatus</c> filter key: Online | ConnectionLost | Inactive
        /// (deprecated)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid values for the <c>PlatformType</c> filter key: Windows | Linux | MacOS
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid values for the <c>ResourceType</c> filter key: EC2Instance | ManagedInstance
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid values for the <c>SourceType</c> filter key: AWS::EC2::Instance | AWS::SSM::ManagedInstance
        /// | AWS::IoT::Thing
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid tag examples: <c>Key=tag-key,Values=Purpose</c> | <c>Key=tag:Purpose,Values=Test</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// The filter values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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