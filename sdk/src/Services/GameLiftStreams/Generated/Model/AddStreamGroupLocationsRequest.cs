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
    /// Container for the parameters to the AddStreamGroupLocations operation.
    /// Add locations that can host stream sessions. You configure locations and their corresponding
    /// capacity for each stream group. Creating a stream group in a location that's nearest
    /// to your end users can help minimize latency and improve quality. 
    /// 
    ///  
    /// <para>
    ///  This operation provisions stream capacity at the specified locations. By default,
    /// all locations have 1 or 2 capacity, depending on the stream class option: 2 for 'High'
    /// and 1 for 'Ultra' and 'Win2022'. This operation also copies the content files of all
    /// associated applications to an internal S3 bucket at each location. This allows Amazon
    /// GameLift Streams to host performant stream sessions. 
    /// </para>
    /// </summary>
    public partial class AddStreamGroupLocationsRequest : AmazonGameLiftStreamsRequest
    {
        private string _identifier;
        private List<LocationConfiguration> _locationConfigurations = AWSConfigs.InitializeCollections ? new List<LocationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        ///  A stream group to add the specified locations to. 
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// Example ID: <c>sg-1AB2C3De4</c>. 
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
        /// Gets and sets the property LocationConfigurations. 
        /// <para>
        ///  A set of one or more locations and the streaming capacity for each location. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<LocationConfiguration> LocationConfigurations
        {
            get { return this._locationConfigurations; }
            set { this._locationConfigurations = value; }
        }

        // Check to see if LocationConfigurations property is set
        internal bool IsSetLocationConfigurations()
        {
            return this._locationConfigurations != null && (this._locationConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}