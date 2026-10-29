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

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Artifacts are the files that are worked on by actions in the pipeline. See the action
    /// configuration for each action for details about artifact parameters. For example,
    /// the S3 source action artifact is a file name (or file path), and the files are generally
    /// provided as a ZIP file. Example artifact name: SampleApp_Windows.zip
    /// </summary>
    public partial class Artifact
    {
        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The location of an artifact.
        /// </para>
        /// </summary>
        public ArtifactLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The artifact's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The artifact's revision ID. Depending on the type of object, this could be a commit
        /// ID (GitHub) or a revision ID (Amazon S3).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1500)]
        public string Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision != null;
    }
}
