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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
    /// Artifact details for the action execution, such as the artifact location.
    /// </summary>
    public partial class ArtifactDetail
    {
        private string _name;
        private S3Location _s3location;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The artifact object name for the action execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property S3location. 
        /// <para>
        /// The Amazon S3 artifact location for the action execution.
        /// </para>
        /// </summary>
        public S3Location S3location
        {
            get { return this._s3location; }
            set { this._s3location = value; }
        }

        // Check to see if S3location property is set
        internal bool IsSetS3location()
        {
            return this._s3location != null;
        }

    }
}