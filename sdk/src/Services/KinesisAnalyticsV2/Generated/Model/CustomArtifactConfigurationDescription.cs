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
 * Do not modify this file. This file is generated from the kinesisanalyticsv2-2018-05-23.normal.json service model.
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
        private ArtifactType _artifactType;
        private MavenReference _mavenReferenceDescription;
        private S3ContentLocation _s3ContentLocationDescription;

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        ///  <c>UDF</c> stands for user-defined functions. This type of artifact must be in an
        /// S3 bucket. A <c>DEPENDENCY_JAR</c> can be in either Maven or an S3 bucket.
        /// </para>
        /// </summary>
        public ArtifactType ArtifactType
        {
            get { return this._artifactType; }
            set { this._artifactType = value; }
        }

        // Check to see if ArtifactType property is set
        internal bool IsSetArtifactType()
        {
            return this._artifactType != null;
        }

        /// <summary>
        /// Gets and sets the property MavenReferenceDescription. 
        /// <para>
        /// The parameters that are required to specify a Maven dependency.
        /// </para>
        /// </summary>
        public MavenReference MavenReferenceDescription
        {
            get { return this._mavenReferenceDescription; }
            set { this._mavenReferenceDescription = value; }
        }

        // Check to see if MavenReferenceDescription property is set
        internal bool IsSetMavenReferenceDescription()
        {
            return this._mavenReferenceDescription != null;
        }

        /// <summary>
        /// Gets and sets the property S3ContentLocationDescription.
        /// </summary>
        public S3ContentLocation S3ContentLocationDescription
        {
            get { return this._s3ContentLocationDescription; }
            set { this._s3ContentLocationDescription = value; }
        }

        // Check to see if S3ContentLocationDescription property is set
        internal bool IsSetS3ContentLocationDescription()
        {
            return this._s3ContentLocationDescription != null;
        }

    }
}