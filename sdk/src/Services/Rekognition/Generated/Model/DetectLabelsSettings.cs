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
    /// Settings for the DetectLabels request. Settings can include filters for both GENERAL_LABELS
    /// and IMAGE_PROPERTIES. GENERAL_LABELS filters can be inclusive or exclusive and applied
    /// to individual labels or label categories. IMAGE_PROPERTIES filters allow specification
    /// of a maximum number of dominant colors.
    /// </summary>
    public partial class DetectLabelsSettings
    {
        private GeneralLabelsSettings _generalLabels;
        private DetectLabelsImagePropertiesSettings _imageProperties;

        /// <summary>
        /// Gets and sets the property GeneralLabels. 
        /// <para>
        /// Contains the specified filters for GENERAL_LABELS.
        /// </para>
        /// </summary>
        public GeneralLabelsSettings GeneralLabels
        {
            get { return this._generalLabels; }
            set { this._generalLabels = value; }
        }

        // Check to see if GeneralLabels property is set
        internal bool IsSetGeneralLabels()
        {
            return this._generalLabels != null;
        }

        /// <summary>
        /// Gets and sets the property ImageProperties. 
        /// <para>
        /// Contains the chosen number of maximum dominant colors in an image.
        /// </para>
        /// </summary>
        public DetectLabelsImagePropertiesSettings ImageProperties
        {
            get { return this._imageProperties; }
            set { this._imageProperties = value; }
        }

        // Check to see if ImageProperties property is set
        internal bool IsSetImageProperties()
        {
            return this._imageProperties != null;
        }

    }
}