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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// A set of Linux capabilities that are added to a container's default Docker configuration
    /// for a container defined in the <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ContainerGroupDefinition.html">ContainerGroupDefinition</a>.
    /// For more detailed information about these Linux capabilities, see the <a href="https://man7.org/linux/man-pages/man7/capabilities.7.html">capabilities(7)</a>
    /// Linux manual page.
    /// 
    ///  
    /// <para>
    ///  <b>Modifying capabilities on an existing container:</b> To remove a capability, update
    /// the <c>Include</c> list with only the needed capabilities. To revert back to default
    /// capabilities, omit <c>LinuxCapabilities</c> within the ContainerDefinition.
    /// </para>
    ///  
    /// <para>
    ///  <b>Part of: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinition.html">GameServerContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_GameServerContainerDefinitionInput.html">GameServerContainerDefinitionInput</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinition.html">SupportContainerDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_SupportContainerDefinitionInput.html">SupportContainerDefinitionInput</a>
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <b>Returned by: </b> <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateContainerGroupDefinition.html">CreateContainerGroupDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeContainerGroupDefinition.html">DescribeContainerGroupDefinition</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListContainerGroupDefinitions.html">ListContainerGroupDefinitions</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_ListContainerGroupDefinitionVersions.html">ListContainerGroupDefinitionVersions</a>,
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_UpdateContainerGroupDefinition.html">UpdateContainerGroupDefinition</a>
    /// 
    /// </para>
    /// </summary>
    public partial class LinuxCapabilities
    {
        private List<string> _include = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// The list of Linux capabilities to add to the container's default configuration. Specify
        /// each capability as a string from the set of supported capability names (for example,
        /// <c>NET_BIND_SERVICE</c> or <c>SYS_PTRACE</c>).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=37)]
        public List<string> Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null && (this._include.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}