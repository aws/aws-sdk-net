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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Describes a Amazon GameLift Streams stream group resource for hosting content streams.
    /// To retrieve additional stream group details, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamGroup.html">GetStreamGroup</a>.
    /// </summary>
    public partial class StreamGroupSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that uniquely identifies the stream group resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was created. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultApplication. 
        /// <para>
        /// Object that identifies the Amazon GameLift Streams application to stream with this
        /// stream group.
        /// </para>
        /// </summary>
        public DefaultApplication DefaultApplication { get; set; }

        /// <summary>
        /// Checks to see if the DefaultApplication property is set.
        /// </summary>
        internal bool IsSetDefaultApplication() => this.DefaultApplication != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A descriptive label for the stream group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 80)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. 
        /// <para>
        /// The time at which this stream group expires. Timestamps are expressed using in ISO8601
        /// format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC). After this time, you will
        /// no longer be able to update this stream group or use it to start stream sessions.
        /// Only Get and Delete operations will work on an expired stream group.
        /// </para>
        /// </summary>
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// An ID that uniquely identifies the stream group resource. Example ID: <c>sg-1AB2C3De4</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// A timestamp that indicates when this resource was last updated. Timestamps are expressed
        /// using in ISO8601 format, such as: <c>2022-12-27T22:29:40+00:00</c> (UTC).
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

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
        ///  <c>DELETING</c>: Amazon GameLift Streams is in the process of deleting the stream
        /// group. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: An error occurred when the stream group deployed. See <c>StatusReason</c>
        /// (returned by <c>CreateStreamGroup</c>, <c>GetStreamGroup</c>, and <c>UpdateStreamGroup</c>)
        /// for more information. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c>: The stream group is expired and can no longer host streams. This
        /// typically occurs when a stream group is 365 days old, as indicated by the value of
        /// <c>ExpiresAt</c>. Create a new stream group to resume streaming capabilities. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING_LOCATIONS</c>: One or more locations in the stream group are in the process
        /// of updating (either activating or deleting). 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamGroupStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        ///  <b> <c>gen6n_pro_win2022</c> (NVIDIA, pro)</b> Supports applications with extremely
        /// high 3D scene complexity which require maximum resources. Runs applications on Microsoft
        /// Windows Server 2022 Base and supports DirectX 12. Compatible with Unreal Engine versions
        /// up through 5.6, 32 and 64-bit applications, and anti-cheat technology. Powered by
        /// NVIDIA L4 Tensor Core GPUs.
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
        /// Workload specifications: 16 vCPUs, 64 GB RAM, 24 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen6n_pro</c> (NVIDIA, pro)</b> Supports applications with extremely high
        /// 3D scene complexity which require maximum resources. Powered by NVIDIA L4 Tensor Core
        /// GPUs.
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
        /// Workload specifications: 16 vCPUs, 64 GB RAM, 24 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen6n_ultra_win2022</c> (NVIDIA, ultra)</b> Supports applications with high
        /// 3D scene complexity. Runs applications on Microsoft Windows Server 2022 Base and supports
        /// DirectX 12. Compatible with Unreal Engine versions up through 5.6, 32 and 64-bit applications,
        /// and anti-cheat technology. Powered by NVIDIA L4 Tensor Core GPUs.
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
        ///  <b> <c>gen6n_ultra</c> (NVIDIA, ultra)</b> Supports applications with high 3D scene
        /// complexity. Powered by NVIDIA L4 Tensor Core GPUs.
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
        ///  <b> <c>gen6n_high</c> (NVIDIA, high)</b> Supports applications with moderate to high
        /// 3D scene complexity. Powered by NVIDIA L4 Tensor Core GPUs.
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
        ///  <b> <c>gen6n_medium</c> (NVIDIA, medium)</b> Supports applications with moderate
        /// 3D scene complexity. Powered by NVIDIA L4 Tensor Core GPUs.
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
        /// Workload specifications: 2 vCPUs, 8 GB RAM, 6 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports up to 4 concurrent stream sessions
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen6n_small</c> (NVIDIA, small)</b> Supports applications with lightweight
        /// 3D scene complexity and low CPU usage. Powered by NVIDIA L4 Tensor Core GPUs.
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
        /// Workload specifications: 1 vCPUs, 4 GB RAM, 2 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports up to 12 concurrent stream sessions
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen6n_medium_win2022</c> (NVIDIA, medium)</b> Supports applications with low
        /// 3D scene complexity. Powered by NVIDIA L4 Tensor Core GPUs.
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
        /// Workload specifications: 8 vCPUs, 32 GB RAM, 6 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen6n_small_win2022</c> (NVIDIA, small)</b> Supports applications with low
        /// 3D scene complexity. Powered by NVIDIA L4 Tensor Core GPUs.
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
        /// Workload specifications: 2 vCPUs, 8 GB RAM, 3 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen6e_pro_win2022</c> (NVIDIA, pro)</b> Supports applications with extremely
        /// high 3D scene complexity which require maximum resources. Runs applications on Microsoft
        /// Windows Server 2022 Base and supports DirectX 12. Compatible with Unreal Engine versions
        /// up through 5.6, 32 and 64-bit applications, and anti-cheat technology. Powered by
        /// NVIDIA L40S Tensor Core GPUs.
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
        /// Workload specifications: 16 vCPUs, 128 GB RAM, 48 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen6e_pro</c> (NVIDIA, pro)</b> Supports applications with extremely high
        /// 3D scene complexity which require maximum resources. Powered by NVIDIA L40S Tensor
        /// Core GPUs.
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
        /// Workload specifications: 16 vCPUs, 128 GB RAM, 48 GB VRAM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tenancy: Supports 1 concurrent stream session
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <b> <c>gen5n_win2022</c> (NVIDIA, ultra)</b> Supports applications with extremely
        /// high 3D scene complexity. Runs applications on Microsoft Windows Server 2022 Base
        /// and supports DirectX 12. Compatible with Unreal Engine versions up through 5.6, 32
        /// and 64-bit applications, and anti-cheat technology. Powered by NVIDIA A10G Tensor
        /// Core GPUs.
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
        /// 3D scene complexity. Powered by NVIDIA A10G Tensor Core GPUs.
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
        /// 3D scene complexity. Powered by NVIDIA A10G Tensor Core GPUs.
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
        /// and supports DirectX 12. Compatible with Unreal Engine versions up through 5.6, 32
        /// and 64-bit applications, and anti-cheat technology. Powered by NVIDIA T4 Tensor Core
        /// GPUs.
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
        /// 3D scene complexity. Powered by NVIDIA T4 Tensor Core GPUs.
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
        /// complexity. Powered by NVIDIA T4 Tensor Core GPUs.
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
        public StreamClass StreamClass { get; set; }

        /// <summary>
        /// Checks to see if the StreamClass property is set.
        /// </summary>
        internal bool IsSetStreamClass() => this.StreamClass != null;
    }
}
