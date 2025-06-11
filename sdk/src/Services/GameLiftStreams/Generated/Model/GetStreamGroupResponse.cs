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
    /// This is the response object from the GetStreamGroup operation.
    /// </summary>
    public partial class GetStreamGroupResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private List<string> _associatedApplications = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdAt;
        private DefaultApplication _defaultApplication;
        private string _description;
        private string _id;
        private DateTime? _lastUpdatedAt;
        private List<LocationState> _locationStates = AWSConfigs.InitializeCollections ? new List<LocationState>() : null;
        private StreamGroupStatus _status;
        private StreamGroupStatusReason _statusReason;
        private StreamClass _streamClass;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that is assigned to the stream group resource and that uniquely
        /// identifies the group across all Amazon Web Services Regions. Format is <c>arn:aws:gameliftstreams:[AWS
        /// Region]:[AWS account]:streamgroup/[resource ID]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property AssociatedApplications. 
        /// <para>
        ///  A set of applications that this stream group is associated to. You can stream any
        /// of these applications by using this stream group. 
        /// </para>
        ///  
        /// <para>
        /// This value is a set of <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Names (ARNs)</a> that uniquely identify application resources. Example ARN:
        /// <c>arn:aws:gameliftstreams:us-west-2:111122223333:application/a-9ZY8X7Wv6</c>. 
        /// </para>
        /// </summary>
        public List<string> AssociatedApplications
        {
            get { return this._associatedApplications; }
            set { this._associatedApplications = value; }
        }

        // Check to see if AssociatedApplications property is set
        internal bool IsSetAssociatedApplications()
        {
            return this._associatedApplications != null && (this._associatedApplications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was created. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultApplication. 
        /// <para>
        /// The default Amazon GameLift Streams application that is associated with this stream
        /// group.
        /// </para>
        /// </summary>
        public DefaultApplication DefaultApplication
        {
            get { return this._defaultApplication; }
            set { this._defaultApplication = value; }
        }

        // Check to see if DefaultApplication property is set
        internal bool IsSetDefaultApplication()
        {
            return this._defaultApplication != null;
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique ID value that is assigned to the resource when it's created. Format example:
        /// <c>sg-1AB2C3De4</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was last updated. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationStates. 
        /// <para>
        /// This value is the set of locations, including their name, current status, and capacities.
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
        public List<LocationState> LocationStates
        {
            get { return this._locationStates; }
            set { this._locationStates = value; }
        }

        // Check to see if LocationStates property is set
        internal bool IsSetLocationStates()
        {
            return this._locationStates != null && (this._locationStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the stream group resource. Possible statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVATING</c>: The stream group is deploying and isn't ready to host streams.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c>: The stream group is ready to host streams. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE_WITH_ERRORS</c>: One or more locations in the stream group are in an error
        /// state. Verify the details of individual locations and remove any locations which are
        /// in error. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: An error occurred when the stream group deployed. See <c>StatusReason</c>
        /// for more information. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Amazon GameLift Streams is in the process of deleting the stream
        /// group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING_LOCATIONS</c>: One or more locations in the stream group are in the process
        /// of updating (either activating or deleting). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  A short description of the reason that the stream group is in <c>ERROR</c> status.
        /// The possible reasons can be one of the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>internalError</c>: The request can't process right now bcause of an issue with
        /// the server. Try again later. Reach out to the Amazon GameLift Streams team for more
        /// help. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>noAvailableInstances</c>: Amazon GameLift Streams does not currently have enough
        /// available On-Demand capacity to fulfill your request. Wait a few minutes and retry
        /// the request as capacity can shift frequently. You can also try to make the request
        /// using a different stream class or in another region. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamGroupStatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property StreamClass. 
        /// <para>
        /// The target stream quality for the stream group.
        /// </para>
        ///  
        /// <para>
        /// A stream class can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <c>gen5n_win2022</c> (NVIDIA, ultra)</b> Supports applications with extremely
        /// high 3D scene complexity. Runs applications on Microsoft Windows Server 2022 Base
        /// and supports DirectX 12. Compatible with Unreal Engine versions up through 5.4, 32
        /// and 64-bit applications, and anti-cheat technology. Uses NVIDIA A10G Tensor GPU.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Reference resolution: 1080p
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Reference frame rate: 60 fps
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Workload specifications: 8 vCPUs, 32 GB RAM, 24 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen5n_high</c> (NVIDIA, high)</b> Supports applications with moderate to high
        /// 3D scene complexity. Uses NVIDIA A10G Tensor GPU.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Reference resolution: 1080p
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Reference frame rate: 60 fps
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Workload specifications: 4 vCPUs, 16 GB RAM, 12 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports up to 2 concurrent stream sessions
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen5n_ultra</c> (NVIDIA, ultra)</b> Supports applications with extremely high
        /// 3D scene complexity. Uses dedicated NVIDIA A10G Tensor GPU.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Reference resolution: 1080p
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Reference frame rate: 60 fps
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Workload specifications: 8 vCPUs, 32 GB RAM, 24 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen4n_win2022</c> (NVIDIA, ultra)</b> Supports applications with extremely
        /// high 3D scene complexity. Runs applications on Microsoft Windows Server 2022 Base
        /// and supports DirectX 12. Compatible with Unreal Engine versions up through 5.4, 32
        /// and 64-bit applications, and anti-cheat technology. Uses NVIDIA T4 Tensor GPU.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Reference resolution: 1080p
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Reference frame rate: 60 fps
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Workload specifications: 8 vCPUs, 32 GB RAM, 16 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen4n_high</c> (NVIDIA, high)</b> Supports applications with moderate to high
        /// 3D scene complexity. Uses NVIDIA T4 Tensor GPU.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Reference resolution: 1080p
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Reference frame rate: 60 fps
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Workload specifications: 4 vCPUs, 16 GB RAM, 8 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports up to 2 concurrent stream sessions
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen4n_ultra</c> (NVIDIA, ultra)</b> Supports applications with high 3D scene
        /// complexity. Uses dedicated NVIDIA T4 Tensor GPU.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Reference resolution: 1080p
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Reference frame rate: 60 fps
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Workload specifications: 8 vCPUs, 32 GB RAM, 16 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public StreamClass StreamClass
        {
            get { return this._streamClass; }
            set { this._streamClass = value; }
        }

        // Check to see if StreamClass property is set
        internal bool IsSetStreamClass()
        {
            return this._streamClass != null;
        }

    }
}