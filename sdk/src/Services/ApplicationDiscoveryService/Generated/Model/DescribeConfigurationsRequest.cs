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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
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
namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurations operation.
    /// Retrieves attributes for a list of configuration item IDs.
    /// 
    ///  <note> 
    /// <para>
    /// All of the supplied IDs must be for the same asset type from one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// server
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// application
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// process
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// connection
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Output fields are specific to the asset type specified. For example, the output for
    /// a <i>server</i> configuration item includes a list of attributes about the server,
    /// such as host name, operating system, number of network cards, etc.
    /// </para>
    ///  
    /// <para>
    /// For a complete list of outputs for each asset type, see <a href="https://docs.aws.amazon.com/application-discovery/latest/userguide/discovery-api-queries.html#DescribeConfigurations">Using
    /// the DescribeConfigurations Action</a> in the <i>Amazon Web Services Application Discovery
    /// Service User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeConfigurationsRequest : AmazonApplicationDiscoveryServiceRequest
    {
        private List<string> _configurationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationIds. 
        /// <para>
        /// One or more configuration IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ConfigurationIds
        {
            get { return this._configurationIds; }
            set { this._configurationIds = value; }
        }

        // Check to see if ConfigurationIds property is set
        internal bool IsSetConfigurationIds()
        {
            return this._configurationIds != null && (this._configurationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}