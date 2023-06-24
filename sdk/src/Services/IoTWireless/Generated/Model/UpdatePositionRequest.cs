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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePosition operation.
    /// Update the position information of a resource.
    /// 
    ///  <important> 
    /// <para>
    /// This action is no longer supported. Calls to update the position information should
    /// use the <a href="https://docs.aws.amazon.com/iot-wireless/2020-11-22/apireference/API_UpdateResourcePosition.html">UpdateResourcePosition</a>
    /// API operation instead.
    /// </para>
    ///  </important>
    /// </summary>
    [Obsolete("This operation is no longer supported.")]
    public partial class UpdatePositionRequest : AmazonIoTWirelessRequest
    {
        private List<float> _position = new List<float>();
        private string _resourceIdentifier;
        private PositionResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// The position information of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<float> Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null && this._position.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifier. 
        /// <para>
        /// Resource identifier of the resource for which position is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceIdentifier
        {
            get { return this._resourceIdentifier; }
            set { this._resourceIdentifier = value; }
        }

        // Check to see if ResourceIdentifier property is set
        internal bool IsSetResourceIdentifier()
        {
            return this._resourceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// Resource type of the resource for which position is updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PositionResourceType ResourceType
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