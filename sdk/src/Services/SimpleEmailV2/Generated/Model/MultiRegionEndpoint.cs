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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains multi-region endpoint (global-endpoint) properties.
    /// </summary>
    public partial class MultiRegionEndpoint
    {
        private DateTime? _createdTimestamp;
        private string _endpointId;
        private string _endpointName;
        private DateTime? _lastUpdatedTimestamp;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private Status _status;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time stamp of when the multi-region endpoint (global-endpoint) was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID of the multi-region endpoint (global-endpoint).
        /// </para>
        /// </summary>
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the multi-region endpoint (global-endpoint).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The time stamp of when the multi-region endpoint (global-endpoint) was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp
        {
            get { return this._lastUpdatedTimestamp; }
            set { this._lastUpdatedTimestamp = value; }
        }

        // Check to see if LastUpdatedTimestamp property is set
        internal bool IsSetLastUpdatedTimestamp()
        {
            return this._lastUpdatedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// Primary and secondary regions between which multi-region endpoint splits sending traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the multi-region endpoint (global-endpoint).
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATING</c> – The resource is being provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> – The resource is ready to use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – The resource failed to be provisioned.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> – The resource is being deleted as requested.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}