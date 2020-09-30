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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// A definition of what is being billed for, including the type and amount.
    /// </summary>
    public partial class ResourceSpecification
    {
        private int? _reservedBitrate;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property ReservedBitrate. The amount of outbound bandwidth that
        /// is discounted in the offering.
        /// </summary>
        public int ReservedBitrate
        {
            get { return this._reservedBitrate.GetValueOrDefault(); }
            set { this._reservedBitrate = value; }
        }

        // Check to see if ReservedBitrate property is set
        internal bool IsSetReservedBitrate()
        {
            return this._reservedBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceType. The type of resource and the unit that is
        /// being billed for.
        /// </summary>
        [AWSProperty(Required=true)]
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}