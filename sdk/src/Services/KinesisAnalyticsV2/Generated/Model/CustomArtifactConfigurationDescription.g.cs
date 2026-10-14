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

namespace Amazon.KinesisAnalyticsV2.Model
{
    /// <summary>
    /// Specifies a dependency JAR or a JAR of user-defined functions.
    /// </summary>
    public partial class CustomArtifactConfigurationDescription
    {
        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        ///  <c>UDF</c> stands for user-defined functions. This type of artifact must be in an
        /// S3 bucket. A <c>DEPENDENCY_JAR</c> can be in either Maven or an S3 bucket.
        /// </para>
        /// </summary>
        public ArtifactType ArtifactType { get; set; }

        /// <summary>
        /// Checks to see if the ArtifactType property is set.
        /// </summary>
        internal bool IsSetArtifactType() => this.ArtifactType != null;

        /// <summary>
        /// Gets and sets the property MavenReferenceDescription. 
        /// <para>
        /// The parameters that are required to specify a Maven dependency.
        /// </para>
        /// </summary>
        public MavenReference MavenReferenceDescription { get; set; }

        /// <summary>
        /// Checks to see if the MavenReferenceDescription property is set.
        /// </summary>
        internal bool IsSetMavenReferenceDescription() => this.MavenReferenceDescription != null;

        /// <summary>
        /// Gets and sets the property S3ContentLocationDescription.
        /// </summary>
        public S3ContentLocation S3ContentLocationDescription { get; set; }

        /// <summary>
        /// Checks to see if the S3ContentLocationDescription property is set.
        /// </summary>
        internal bool IsSetS3ContentLocationDescription() => this.S3ContentLocationDescription != null;
    }
}
