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

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBuild operation. <b>This API works with
    /// the following fleet types:</b> EC2 <para> Updates metadata in a build resource, including
    /// the build name and version. To update the metadata, specify the build ID to update
    /// and provide the new values. If successful, a build object containing the updated metadata
    /// is returned. </para> <para> <b>Learn more</b> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
    /// Upload a Custom Server Build</a> </para> <para> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> </para>
    /// </summary>
    public partial class UpdateBuildRequest : AmazonGameLiftRequest
    {
        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// A unique identifier for the build to update. You can use either the build ID or ARN
        /// value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string BuildId { get; set; }

        /// <summary>
        /// Checks to see if the BuildId property is set.
        /// </summary>
        internal bool IsSetBuildId() => this.BuildId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive label that is associated with a build. Build names do not need to be
        /// unique. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// Version information that is associated with a build or script. Version strings do
        /// not need to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
