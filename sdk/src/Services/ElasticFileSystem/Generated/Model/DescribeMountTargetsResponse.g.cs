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

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// This is the response object from the DescribeMountTargets operation.
    /// </summary>
    public partial class DescribeMountTargetsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// If the request included the <c>Marker</c>, the response returns that value in this
        /// field.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property MountTargets. 
        /// <para>
        /// Returns the file system's mount targets as an array of <c>MountTargetDescription</c>
        /// objects.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MountTargetDescription> MountTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<MountTargetDescription>() : null;

        /// <summary>
        /// Checks to see if the MountTargets property is set.
        /// </summary>
        internal bool IsSetMountTargets() => this.MountTargets != null && (this.MountTargets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// If a value is present, there are more mount targets to return. In a subsequent request,
        /// you can provide <c>Marker</c> in your request with this value to retrieve the next
        /// set of mount targets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string NextMarker { get; set; }

        /// <summary>
        /// Checks to see if the NextMarker property is set.
        /// </summary>
        internal bool IsSetNextMarker() => this.NextMarker != null;
    }
}
