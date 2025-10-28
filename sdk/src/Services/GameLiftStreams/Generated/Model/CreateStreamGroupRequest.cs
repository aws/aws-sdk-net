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
    /// Container for the parameters to the CreateStreamGroup operation.
    /// Stream groups manage how Amazon GameLift Streams allocates resources and handles
    /// concurrent streams, allowing you to effectively manage capacity and costs. Within
    /// a stream group, you specify an application to stream, streaming locations and their
    /// capacity, and the stream class you want to use when streaming applications to your
    /// end-users. A stream class defines the hardware configuration of the compute resources
    /// that Amazon GameLift Streams will use when streaming, such as the CPU, GPU, and memory.
    /// 
    /// 
    ///  
    /// <para>
    ///  Stream capacity represents the number of concurrent streams that can be active at
    /// a time. You set stream capacity per location, per stream group. There are two types
    /// of capacity, always-on and on-demand: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Always-on</b>: The streaming capacity that is allocated and ready to handle stream
    /// requests without delay. You pay for this capacity whether it's in use or not. Best
    /// for quickest time from streaming request to streaming session. Default is 1 (2 for
    /// high stream classes) when creating a stream group or adding a location. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>On-demand</b>: The streaming capacity that Amazon GameLift Streams can allocate
    /// in response to stream requests, and then de-allocate when the session has terminated.
    /// This offers a cost control measure at the expense of a greater startup time (typically
    /// under 5 minutes). Default is 0 when creating a stream group or adding a location.
    /// 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Values for capacity must be whole number multiples of the tenancy value of the stream
    /// group's stream class.
    /// </para>
    ///  
    /// <para>
    ///  To adjust the capacity of any <c>ACTIVE</c> stream group, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UpdateStreamGroup.html">UpdateStreamGroup</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  If the <c>CreateStreamGroup</c> request is successful, Amazon GameLift Streams assigns
    /// a unique ID to the stream group resource and sets the status to <c>ACTIVATING</c>.
    /// It can take a few minutes for Amazon GameLift Streams to finish creating the stream
    /// group while it searches for unallocated compute resources and provisions them. When
    /// complete, the stream group status will be <c>ACTIVE</c> and you can start stream sessions
    /// by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_StartStreamSession.html">StartStreamSession</a>.
    /// To check the stream group's status, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamGroup.html">GetStreamGroup</a>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Stream groups should be recreated every 3-4 weeks to pick up important service updates
    /// and fixes. Stream groups that are older than 180 days can no longer be updated with
    /// new application associations. Stream groups expire when they are 365 days old, at
    /// which point they can no longer stream sessions. The exact expiration date is indicated
    /// by the date value in the <c>ExpiresAt</c> field.
    /// </para>
    /// </summary>
    public partial class CreateStreamGroupRequest : AmazonGameLiftStreamsRequest
    {
        private string _clientToken;
        private string _defaultApplicationIdentifier;
        private string _description;
        private List<LocationConfiguration> _locationConfigurations = AWSConfigs.InitializeCollections ? new List<LocationConfiguration>() : null;
        private StreamClass _streamClass;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier that represents a client request. The request is idempotent,
        /// which ensures that an API request completes only once. When users send a request,
        /// Amazon GameLift Streams automatically populates this field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        /// If you do not link an application when you create a stream group, you will need to
        /// link one later, before you can start streaming, using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_AssociateApplications.html">AssociateApplications</a>.
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
        [AWSProperty(Required=true, Min=1, Max=80)]
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

        /// <summary>
        /// Gets and sets the property StreamClass. 
        /// <para>
        /// The target stream quality for sessions that are hosted in this stream group. Set a
        /// stream class that is appropriate to the type of content that you're streaming. Stream
        /// class determines the type of computing resources Amazon GameLift Streams uses and
        /// impacts the cost of streaming. The following options are available: 
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
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new stream group resource. Tags are developer-defined
        /// key-value pairs. Tagging Amazon Web Services resources is useful for resource management,
        /// access management and cost allocation. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// You can use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_TagResource.html">TagResource</a>
        /// to add tags, <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UntagResource.html">UntagResource</a>
        /// to remove tags, and <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_ListTagsForResource.html">ListTagsForResource</a>
        /// to view tags on existing resources.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}