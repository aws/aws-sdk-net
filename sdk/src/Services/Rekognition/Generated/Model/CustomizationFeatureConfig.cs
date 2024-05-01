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
    /// Feature specific configuration for the training job. Configuration provided for the
    /// job must match the feature type parameter associated with project. If configuration
    /// and feature type do not match an InvalidParameterException is returned.
    /// </summary>
    public partial class CustomizationFeatureConfig
    {
        private CustomizationFeatureContentModerationConfig _contentModeration;

        /// <summary>
        /// Gets and sets the property ContentModeration. 
        /// <para>
        /// Configuration options for Custom Moderation training.
        /// </para>
        /// </summary>
        public CustomizationFeatureContentModerationConfig ContentModeration
        {
            get { return this._contentModeration; }
            set { this._contentModeration = value; }
        }

        // Check to see if ContentModeration property is set
        internal bool IsSetContentModeration()
        {
            return this._contentModeration != null;
        }

    }
}