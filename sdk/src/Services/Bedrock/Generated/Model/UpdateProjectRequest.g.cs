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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProject operation. Updates one mutable project
    /// field per call: exactly one of <c>name</c> or <c>dataRetention</c> must be set. The
    /// default project and archived projects cannot be updated.
    /// </summary>
    public partial class UpdateProjectRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property DataRetention. 
        /// <para>
        /// The project's new data-retention mode. Must be set on its own.
        /// </para>
        /// </summary>
        public ProjectDataRetention DataRetention { get; set; }

        /// <summary>
        /// Checks to see if the DataRetention property is set.
        /// </summary>
        internal bool IsSetDataRetention() => this.DataRetention != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The project's new display name. Specify this field only when <c>dataRetention</c>
        /// is omitted. Project names do not have to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProjectIdentifier. 
        /// <para>
        /// The id or ARN of the project to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string ProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetProjectIdentifier() => this.ProjectIdentifier != null;
    }
}
