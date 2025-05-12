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
    /// Container for the parameters to the RemoveStreamGroupLocations operation.
    /// Removes a set of remote locations from this stream group. Amazon GameLift Streams
    /// works to release allocated compute resources in these location. Thus, stream sessions
    /// can no longer start from these locations by using this stream group. Amazon GameLift
    /// Streams also deletes the content files of all associated applications that were in
    /// Amazon GameLift Streams's internal S3 bucket at this location. 
    /// 
    ///  
    /// <para>
    ///  You cannot remove the region where you initially created this stream group, known
    /// as the primary location. However, you can set the stream capacity to zero. 
    /// </para>
    /// </summary>
    public partial class RemoveStreamGroupLocationsRequest : AmazonGameLiftStreamsRequest
    {
        private string _identifier;
        private List<string> _locations = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        ///  A stream group to remove the specified locations from. 
        /// </para>
        ///  
        /// <para>
        ///  This value is a Amazon Resource Name (ARN) that uniquely identifies the stream group
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
        ///  A set of locations to remove this stream group. 
        /// </para>
        ///  
        /// <para>
        ///  A set of location names. For example, <c>us-east-1</c>. For a complete list of locations
        /// that Amazon GameLift Streams supports, refer to <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/regions-quotas.html">Regions
        /// and quotas</a> in the <i>Amazon GameLift Streams Developer Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<string> Locations
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