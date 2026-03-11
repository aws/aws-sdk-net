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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the global resiliency configuration for the contact, including traffic
    /// distribution details.
    /// </summary>
    public partial class GlobalResiliencyMetadata
    {
        private string _activeRegion;
        private string _originRegion;
        private string _trafficDistributionGroupId;

        /// <summary>
        /// Gets and sets the property ActiveRegion. 
        /// <para>
        /// The current AWS region in which the contact is active. This indicates where the contact
        /// is being processed in real-time.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ActiveRegion
        {
            get { return this._activeRegion; }
            set { this._activeRegion = value; }
        }

        // Check to see if ActiveRegion property is set
        internal bool IsSetActiveRegion()
        {
            return this._activeRegion != null;
        }

        /// <summary>
        /// Gets and sets the property OriginRegion. 
        /// <para>
        /// The AWS region where the contact was originally created and initiated. This may differ
        /// from the ActiveRegion if the contact has been transferred across regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string OriginRegion
        {
            get { return this._originRegion; }
            set { this._originRegion = value; }
        }

        // Check to see if OriginRegion property is set
        internal bool IsSetOriginRegion()
        {
            return this._originRegion != null;
        }

        /// <summary>
        /// Gets and sets the property TrafficDistributionGroupId. 
        /// <para>
        /// The identifier of the traffic distribution group.
        /// </para>
        /// </summary>
        public string TrafficDistributionGroupId
        {
            get { return this._trafficDistributionGroupId; }
            set { this._trafficDistributionGroupId = value; }
        }

        // Check to see if TrafficDistributionGroupId property is set
        internal bool IsSetTrafficDistributionGroupId()
        {
            return this._trafficDistributionGroupId != null;
        }

    }
}