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
    /// Describes a shader cache associated with an Amazon GameLift Streams application.
    /// </summary>
    public partial class ShaderCacheSummary
    {
        /// <summary>
        /// Gets and sets the property ApplicationArn. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> that uniquely identifies the application resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:application/a-9ZY8X7Wv6</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string ApplicationArn { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationArn property is set.
        /// </summary>
        internal bool IsSetApplicationArn() => this.ApplicationArn != null;

        /// <summary>
        /// Gets and sets the property AssociatedStreamGroups. 
        /// <para>
        /// The stream groups compatible with this shader cache. Compatibility is based on GPU
        /// type and GPU driver version. For more information on shader cache compatibility, see
        /// <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/shader-caches.html">Shader
        /// caches</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This value is a set of <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Names (ARNs)</a> that uniquely identify stream group resources. Example ARN:
        /// <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AssociatedStreamGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AssociatedStreamGroups property is set.
        /// </summary>
        internal bool IsSetAssociatedStreamGroups() => this.AssociatedStreamGroups != null && (this.AssociatedStreamGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// A unique identifier for the shader cache, formatted as a 32-character hexadecimal
        /// string. Format is <c>1271e693c50b940e228582f1ccdd4e27</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

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
        /// The current status of the shader cache. Possible statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>INITIALIZED</c>: Amazon GameLift Streams received the request and is preparing
        /// the shader cache.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROCESSING</c>: Amazon GameLift Streams is replicating the shader cache to the
        /// streaming locations in the associated stream groups.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c>: The shader cache is replicated and available for use in stream sessions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c>: Amazon GameLift Streams is deleting the shader cache.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR</c>: An error occurred during shader cache processing. Create a new shader
        /// cache to try again.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ShaderCacheStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageBytes. 
        /// <para>
        /// The total storage used by all compiled shader files in this shader cache, in bytes.
        /// </para>
        /// </summary>
        public long? StorageBytes { get; set; }

        /// <summary>
        /// Checks to see if the StorageBytes property is set.
        /// </summary>
        internal bool IsSetStorageBytes() => this.StorageBytes.HasValue;
    }
}
