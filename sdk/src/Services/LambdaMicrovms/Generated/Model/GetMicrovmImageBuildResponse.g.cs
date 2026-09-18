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

namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// This is the response object from the GetMicrovmImageBuild operation.
    /// </summary>
    public partial class GetMicrovmImageBuildResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The target CPU architecture for the build. Supported value: ARM_64.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Architecture Architecture { get; set; }

        /// <summary>
        /// Checks to see if the Architecture property is set.
        /// </summary>
        internal bool IsSetArchitecture() => this.Architecture != null;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// The build request ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string BuildId { get; set; }

        /// <summary>
        /// Checks to see if the BuildId property is set.
        /// </summary>
        internal bool IsSetBuildId() => this.BuildId != null;

        /// <summary>
        /// Gets and sets the property BuildState. 
        /// <para>
        /// The current state of the build.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BuildState BuildState { get; set; }

        /// <summary>
        /// Checks to see if the BuildState property is set.
        /// </summary>
        internal bool IsSetBuildState() => this.BuildState != null;

        /// <summary>
        /// Gets and sets the property Chipset. 
        /// <para>
        /// The target chipset for the build.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Chipset Chipset { get; set; }

        /// <summary>
        /// Checks to see if the Chipset property is set.
        /// </summary>
        internal bool IsSetChipset() => this.Chipset != null;

        /// <summary>
        /// Gets and sets the property ChipsetGeneration. 
        /// <para>
        /// The target chipset generation for the build.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ChipsetGeneration { get; set; }

        /// <summary>
        /// Checks to see if the ChipsetGeneration property is set.
        /// </summary>
        internal bool IsSetChipsetGeneration() => this.ChipsetGeneration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the build was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ImageArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageArn property is set.
        /// </summary>
        internal bool IsSetImageArn() => this.ImageArn != null;

        /// <summary>
        /// Gets and sets the property ImageVersion. 
        /// <para>
        /// The version of the MicroVM image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ImageVersion { get; set; }

        /// <summary>
        /// Checks to see if the ImageVersion property is set.
        /// </summary>
        internal bool IsSetImageVersion() => this.ImageVersion != null;

        /// <summary>
        /// Gets and sets the property SnapshotBuild. 
        /// <para>
        /// The snapshot build details, including memory and disk snapshot sizes.
        /// </para>
        /// </summary>
        public SnapshotBuild SnapshotBuild { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotBuild property is set.
        /// </summary>
        internal bool IsSetSnapshotBuild() => this.SnapshotBuild != null;

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the build state, if applicable.
        /// </para>
        /// </summary>
        public string StateReason { get; set; }

        /// <summary>
        /// Checks to see if the StateReason property is set.
        /// </summary>
        internal bool IsSetStateReason() => this.StateReason != null;
    }
}
