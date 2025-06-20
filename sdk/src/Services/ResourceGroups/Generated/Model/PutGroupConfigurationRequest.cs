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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
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
namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the PutGroupConfiguration operation.
    /// Attaches a service configuration to the specified group. This occurs asynchronously,
    /// and can take time to complete. You can use <a>GetGroupConfiguration</a> to check the
    /// status of the update.
    /// 
    ///  
    /// <para>
    ///  <b>Minimum permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To run this command, you must have the following permissions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>resource-groups:PutGroupConfiguration</c> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutGroupConfigurationRequest : AmazonResourceGroupsRequest
    {
        private List<GroupConfigurationItem> _configuration = AWSConfigs.InitializeCollections ? new List<GroupConfigurationItem>() : null;
        private string _group;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The new configuration to associate with the specified group. A configuration associates
        /// the resource group with an Amazon Web Services service and specifies how the service
        /// can interact with the resources in the group. A configuration is an array of <a>GroupConfigurationItem</a>
        /// elements.
        /// </para>
        ///  
        /// <para>
        /// For information about the syntax of a service configuration, see <a href="https://docs.aws.amazon.com/ARG/latest/APIReference/about-slg.html">Service
        /// configurations for Resource Groups</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// A resource group can contain either a <c>Configuration</c> or a <c>ResourceQuery</c>,
        /// but not both.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<GroupConfigurationItem> Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null && (this._configuration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name or Amazon resource name (ARN) of the resource group with the configuration
        /// that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

    }
}