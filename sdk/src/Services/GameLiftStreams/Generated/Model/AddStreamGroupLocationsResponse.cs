<<<<<<< HEAD
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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// This is the response object from the AddStreamGroupLocations operation.
    /// </summary>
    public partial class AddStreamGroupLocationsResponse : AmazonWebServiceResponse
    {
        private string _identifier;
        private List<LocationState> _locations = AWSConfigs.InitializeCollections ? new List<LocationState>() : null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// This value is the Amazon Resource Name (ARN) that uniquely identifies the stream group
        /// resource. Format example: <c>1AB2C3De4</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// This value is set of locations, including their name, current status, and capacities.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  A location can be in one of the following states: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVATING</b>: Amazon GameLift Streams is preparing the location. You cannot
        /// stream from, scale the capacity of, or remove this location yet. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b>: The location is provisioned with initial capacity. You can now stream
        /// from, scale the capacity of, or remove this location. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ERROR</b>: Amazon GameLift Streams failed to set up this location. The StatusReason
        /// field describes the error. You can remove this location and try to add it again. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REMOVING</b>: Amazon GameLift Streams is working to remove this location. It releases
        /// all provisioned capacity for this location in this stream group. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LocationState> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
|||||||
=======
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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// This is the response object from the AddStreamGroupLocations operation.
    /// </summary>
    public partial class AddStreamGroupLocationsResponse : AmazonWebServiceResponse
    {
        private string _identifier;
        private List<LocationState> _locations = AWSConfigs.InitializeCollections ? new List<LocationState>() : null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// This value is the Amazon Resource Name (ARN) that uniquely identifies the stream group
        /// resource. Format example: <c>sg-1AB2C3De4</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property Locations. 
        /// <para>
        /// This value is set of locations, including their name, current status, and capacities.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  A location can be in one of the following states: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ACTIVATING</b>: Amazon GameLift Streams is preparing the location. You cannot
        /// stream from, scale the capacity of, or remove this location yet. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ACTIVE</b>: The location is provisioned with initial capacity. You can now stream
        /// from, scale the capacity of, or remove this location. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ERROR</b>: Amazon GameLift Streams failed to set up this location. The StatusReason
        /// field describes the error. You can remove this location and try to add it again. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>REMOVING</b>: Amazon GameLift Streams is working to remove this location. It releases
        /// all provisioned capacity for this location in this stream group. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<LocationState> Locations
        {
            get { return this._locations; }
            set { this._locations = value; }
        }

        // Check to see if Locations property is set
        internal bool IsSetLocations()
        {
            return this._locations != null && (this._locations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}
>>>>>>> b6da6ace600c307cc9bd6dbf99b06a9d2b81da7e
