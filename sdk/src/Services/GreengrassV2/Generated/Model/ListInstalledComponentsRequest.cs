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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
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
namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListInstalledComponents operation.
    /// Retrieves a paginated list of the components that a Greengrass core device runs. By
    /// default, this list doesn't include components that are deployed as dependencies of
    /// other components. To include dependencies in the response, set the <c>topologyFilter</c>
    /// parameter to <c>ALL</c>.
    /// 
    ///  <note> 
    /// <para>
    /// IoT Greengrass relies on individual devices to send status updates to the Amazon Web
    /// Services Cloud. If the IoT Greengrass Core software isn't running on the device, or
    /// if device isn't connected to the Amazon Web Services Cloud, then the reported status
    /// of that device might not reflect its current status. The status timestamp indicates
    /// when the device status was last updated.
    /// </para>
    ///  
    /// <para>
    /// Core devices send status updates at the following times:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// When the IoT Greengrass Core software starts
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the core device receives a deployment from the Amazon Web Services Cloud
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When the status of any component on the core device becomes <c>BROKEN</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// At a <a href="https://docs.aws.amazon.com/greengrass/v2/developerguide/greengrass-nucleus-component.html#greengrass-nucleus-component-configuration-fss">regular
    /// interval that you can configure</a>, which defaults to 24 hours
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For IoT Greengrass Core v2.7.0, the core device sends status updates upon local deployment
    /// and cloud deployment
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ListInstalledComponentsRequest : AmazonGreengrassV2Request
    {
        private string _coreDeviceThingName;
        private int? _maxResults;
        private string _nextToken;
        private InstalledComponentTopologyFilter _topologyFilter;

        /// <summary>
        /// Gets and sets the property CoreDeviceThingName. 
        /// <para>
        /// The name of the core device. This is also the name of the IoT thing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CoreDeviceThingName
        {
            get { return this._coreDeviceThingName; }
            set { this._coreDeviceThingName = value; }
        }

        // Check to see if CoreDeviceThingName property is set
        internal bool IsSetCoreDeviceThingName()
        {
            return this._coreDeviceThingName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned per paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token to be used for the next set of paginated results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TopologyFilter. 
        /// <para>
        /// The filter for the list of components. Choose from the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c> – The list includes all components installed on the core device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ROOT</c> – The list includes only <i>root</i> components, which are components
        /// that you specify in a deployment. When you choose this option, the list doesn't include
        /// components that the core device installs as dependencies of other components.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default: <c>ROOT</c> 
        /// </para>
        /// </summary>
        public InstalledComponentTopologyFilter TopologyFilter
        {
            get { return this._topologyFilter; }
            set { this._topologyFilter = value; }
        }

        // Check to see if TopologyFilter property is set
        internal bool IsSetTopologyFilter()
        {
            return this._topologyFilter != null;
        }

    }
}