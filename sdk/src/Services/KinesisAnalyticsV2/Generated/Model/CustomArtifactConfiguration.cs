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
    /// Specifies dependency JARs, as well as JAR files that contain user-defined functions
    /// (UDF).
    /// </summary>
    public partial class CustomArtifactConfiguration
    {
        private ArtifactType _artifactType;
        private MavenReference _mavenReference;
        private S3ContentLocation _s3ContentLocation;

        /// <summary>
        /// Gets and sets the property ArtifactType. 
        /// <para>
        ///  <c>UDF</c> stands for user-defined functions. This type of artifact must be in an
        /// S3 bucket. A <c>DEPENDENCY_JAR</c> can be in either Maven or an S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MavenReference. 
        /// <para>
        /// The parameters required to fully specify a Maven reference.
        /// </para>
        /// </summary>
        public MavenReference MavenReference
        {
            get { return this._mavenReference; }
            set { this._mavenReference = value; }
        }

        // Check to see if MavenReference property is set
        internal bool IsSetMavenReference()
        {
            return this._mavenReference != null;
        }

        /// <summary>
        /// Gets and sets the property S3ContentLocation.
        /// </summary>
        public S3ContentLocation S3ContentLocation
        {
            get { return this._s3ContentLocation; }
            set { this._s3ContentLocation = value; }
        }

        // Check to see if S3ContentLocation property is set
        internal bool IsSetS3ContentLocation()
        {
            return this._s3ContentLocation != null;
        }

    }
}