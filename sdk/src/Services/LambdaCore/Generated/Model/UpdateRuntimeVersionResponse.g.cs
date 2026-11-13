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

namespace Amazon.LambdaCore.Model
{
    /// <summary>
    /// This is the response object from the UpdateRuntimeVersion operation.
    /// </summary>
    public partial class UpdateRuntimeVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. The Amazon Resource Name (ARN) of the runtime version.
        /// </summary>
        [AWSProperty(Required = true, Min = 48, Max = 2048)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Compatibility. The compatibility matrix of the runtime
        /// version.
        /// </summary>
        public Compatibility Compatibility { get; set; }

        /// <summary>
        /// Checks to see if the Compatibility property is set.
        /// </summary>
        internal bool IsSetCompatibility() => this.Compatibility != null;

        /// <summary>
        /// Gets and sets the property Created. The date and time when the runtime version was
        /// created.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created != null;

        /// <summary>
        /// Gets and sets the property LastModified. The date and time when the runtime version
        /// was last modified.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string LastModified { get; set; }

        /// <summary>
        /// Checks to see if the LastModified property is set.
        /// </summary>
        internal bool IsSetLastModified() => this.LastModified != null;

        /// <summary>
        /// Gets and sets the property Name. The name of the runtime version.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Platforms. The platforms (architecture and OS combinations)
        /// available for the runtime version.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Platform> Platforms { get; set; } = AWSConfigs.InitializeCollections ? new List<Platform>() : null;

        /// <summary>
        /// Checks to see if the Platforms property is set.
        /// </summary>
        internal bool IsSetPlatforms() => this.Platforms != null && (this.Platforms.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ReleaseNotes. The release notes associated with the runtime
        /// version.
        /// </summary>
        public string ReleaseNotes { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseNotes property is set.
        /// </summary>
        internal bool IsSetReleaseNotes() => this.ReleaseNotes != null;

        /// <summary>
        /// Gets and sets the property ResolvedUri. The resolved image URI of the runtime version.
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResolvedUri { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedUri property is set.
        /// </summary>
        internal bool IsSetResolvedUri() => this.ResolvedUri != null;

        /// <summary>
        /// Gets and sets the property State. The current state of the runtime version.
        /// </summary>
        [AWSProperty(Required = true)]
        public RuntimeVersionState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
