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
    /// Manage how Amazon GameLift Streams streams your applications by using a stream group.
    /// A stream group is a collection of resources that Amazon GameLift Streams uses to stream
    /// your application to end-users. When you create a stream group, you specify an application
    /// to stream by default and the type of hardware to use, such as the graphical processing
    /// unit (GPU). You can also link additional applications, which allows you to stream
    /// those applications using this stream group. Depending on your expected users, you
    /// also scale the number of concurrent streams you want to support at one time, and in
    /// what locations. 
    /// 
    ///  
    /// <para>
    ///  Stream capacity represents the number of concurrent streams that can be active at
    /// a time. You set stream capacity per location, per stream group. There are two types
    /// of capacity: always-on and on-demand: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Always-on</b>: The streaming capacity that is allocated and ready to handle stream
    /// requests without delay. You pay for this capacity whether it's in use or not. Best
    /// for quickest time from streaming request to streaming session. <pre><c> &lt;/p&gt;
    /// &lt;/li&gt; &lt;li&gt; &lt;p&gt; &lt;b&gt;On-demand&lt;/b&gt;: The streaming capacity
    /// that Amazon GameLift Streams can allocate in response to stream requests, and then
    /// de-allocate when the session has terminated. This offers a cost control measure at
    /// the expense of a greater startup time (typically under 5 minutes). &lt;/p&gt; &lt;/li&gt;
    /// &lt;/ul&gt; &lt;p&gt; To adjust the capacity of any &lt;code&gt;ACTIVE&lt;/code&gt;
    /// stream group, call &lt;a href=&quot;https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UpdateStreamGroup.html&quot;&gt;UpdateStreamGroup&lt;/a&gt;.
    /// &lt;/p&gt; &lt;p&gt; If the request is successful, Amazon GameLift Streams begins
    /// creating the stream group. Amazon GameLift Streams assigns a unique ID to the stream
    /// group resource and sets the status to &lt;code&gt;ACTIVATING&lt;/code&gt;. When the
    /// stream group reaches &lt;code&gt;ACTIVE&lt;/code&gt; status, you can start stream
    /// sessions by using &lt;a href=&quot;https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_StartStreamSession.html&quot;&gt;StartStreamSession&lt;/a&gt;.
    /// To check the stream group's status, call &lt;a href=&quot;https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamGroup.html&quot;&gt;GetStreamGroup&lt;/a&gt;.
    /// &lt;/p&gt; </c></pre>
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
        /// associate to a stream group as the default application. The application must be in
        /// <c>READY</c> status. By setting the default application identifier, you will optimize
        /// startup performance of this application in your stream group. Once set, this application
        /// cannot be disassociated from the stream group, unlike applications that are associated
        /// using AssociateApplications. If not set when creating a stream group, you will need
        /// to call AssociateApplications later, before you can start streaming.
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