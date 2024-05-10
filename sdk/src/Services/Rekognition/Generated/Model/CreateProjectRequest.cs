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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates a new Amazon Rekognition project. A project is a group of resources (datasets,
    /// model versions) that you use to create and manage a Amazon Rekognition Custom Labels
    /// Model or custom adapter. You can specify a feature to create the project with, if
    /// no feature is specified then Custom Labels is used by default. For adapters, you can
    /// also choose whether or not to have the project auto update by using the AutoUpdate
    /// argument. This operation requires permissions to perform the <c>rekognition:CreateProject</c>
    /// action.
    /// </summary>
    public partial class CreateProjectRequest : AmazonRekognitionRequest
    {
        private ProjectAutoUpdate _autoUpdate;
        private CustomizationFeature _feature;
        private string _projectName;

        /// <summary>
        /// Gets and sets the property AutoUpdate. 
        /// <para>
        /// Specifies whether automatic retraining should be attempted for the versions of the
        /// project. Automatic retraining is done as a best effort. Required argument for Content
        /// Moderation. Applicable only to adapters.
        /// </para>
        /// </summary>
        public ProjectAutoUpdate AutoUpdate
        {
            get { return this._autoUpdate; }
            set { this._autoUpdate = value; }
        }

        // Check to see if AutoUpdate property is set
        internal bool IsSetAutoUpdate()
        {
            return this._autoUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// Specifies feature that is being customized. If no value is provided CUSTOM_LABELS
        /// is used as a default.
        /// </para>
        /// </summary>
        public CustomizationFeature Feature
        {
            get { return this._feature; }
            set { this._feature = value; }
        }

        // Check to see if Feature property is set
        internal bool IsSetFeature()
        {
            return this._feature != null;
        }

        /// <summary>
        /// Gets and sets the property ProjectName. 
        /// <para>
        /// The name of the project to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProjectName
        {
            get { return this._projectName; }
            set { this._projectName = value; }
        }

        // Check to see if ProjectName property is set
        internal bool IsSetProjectName()
        {
            return this._projectName != null;
        }

    }
}