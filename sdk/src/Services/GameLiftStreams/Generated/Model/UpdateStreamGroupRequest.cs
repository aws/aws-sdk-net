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
    /// Container for the parameters to the UpdateStreamGroup operation.
    /// Updates the configuration settings for an Amazon GameLift Streams stream group resource.
    /// To update a stream group, it must be in <c>ACTIVE</c> status. You can change the description,
    /// the set of locations, and the requested capacity of a stream group per location. If
    /// you want to change the stream class, create a new stream group. 
    /// 
    ///  
    /// <para>
    ///  Stream capacity represents the number of concurrent streams that can be active at
    /// a time. You set stream capacity per location, per stream group. The following capacity
    /// settings are available: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Always-on capacity</b>: This setting, if non-zero, indicates minimum streaming
    /// capacity which is allocated to you and is never released back to the service. You
    /// pay for this base level of capacity at all times, whether used or idle. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Maximum capacity</b>: This indicates the maximum capacity that the service can
    /// allocate for you. Newly created streams may take a few minutes to start. Capacity
    /// is released back to the service when idle. You pay for capacity that is allocated
    /// to you until it is released. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Target-idle capacity</b>: This indicates idle capacity which the service pre-allocates
    /// and holds for you in anticipation of future activity. This helps to insulate your
    /// users from capacity-allocation delays. You pay for capacity which is held in this
    /// intentional idle state. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Values for capacity must be whole number multiples of the tenancy value of the stream
    /// group's stream class.
    /// </para>
    ///  
    /// <para>
    /// To update a stream group, specify the stream group's Amazon Resource Name (ARN) and
    /// provide the new values. If the request is successful, Amazon GameLift Streams returns
    /// the complete updated metadata for the stream group. Expired stream groups cannot be
    /// updated.
    /// </para>
    /// </summary>
    public partial class UpdateStreamGroupRequest : AmazonGameLiftStreamsRequest
    {
        private string _defaultApplicationIdentifier;
        private string _description;
        private string _identifier;
        private List<LocationConfiguration> _locationConfigurations = AWSConfigs.InitializeCollections ? new List<LocationConfiguration>() : null;

        /// <summary>
        /// Gets and sets the property DefaultApplicationIdentifier. 
        /// <para>
        /// The unique identifier of the Amazon GameLift Streams application that you want to
        /// set as the default application in a stream group. The application that you specify
        /// must be in <c>READY</c> status. The default application is pre-cached on always-on
        /// compute resources, reducing stream startup times. Other applications are automatically
        /// cached as needed.
        /// </para>
        ///  
        /// <para>
        /// Note that this parameter only sets the default application in a stream group. To associate
        /// a new application to an existing stream group, you must use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_AssociateApplications.html">AssociateApplications</a>.
        /// </para>
        ///  
        /// <para>
        /// When you switch default applications in a stream group, it can take up to a few hours
        /// for the new default application to be pre-cached.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the application resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:application/a-9ZY8X7Wv6</c>.
        /// Example ID: <c>a-9ZY8X7Wv6</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DefaultApplicationIdentifier
        {
            get { return this._defaultApplicationIdentifier; }
            set { this._defaultApplicationIdentifier = value; }
        }

        // Check to see if DefaultApplicationIdentifier property is set
        internal bool IsSetDefaultApplicationIdentifier()
        {
            return this._defaultApplicationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A descriptive label for the stream group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
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
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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