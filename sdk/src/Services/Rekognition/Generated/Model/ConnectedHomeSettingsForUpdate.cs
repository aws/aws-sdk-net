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
    /// The label detection settings you want to use in your stream processor. This includes
    /// the labels you want the stream processor to detect and the minimum confidence level
    /// allowed to label objects.
    /// </summary>
    public partial class ConnectedHomeSettingsForUpdate
    {
        private List<string> _labels = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private float? _minConfidence;

        /// <summary>
        /// Gets and sets the property Labels. 
        /// <para>
        ///  Specifies what you want to detect in the video, such as people, packages, or pets.
        /// The current valid labels you can include in this list are: "PERSON", "PET", "PACKAGE",
        /// and "ALL". 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public List<string> Labels
        {
            get { return this._labels; }
            set { this._labels = value; }
        }

        // Check to see if Labels property is set
        internal bool IsSetLabels()
        {
            return this._labels != null && (this._labels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MinConfidence. 
        /// <para>
        ///  The minimum confidence required to label an object in the video. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? MinConfidence
        {
            get { return this._minConfidence; }
            set { this._minConfidence = value; }
        }

        // Check to see if MinConfidence property is set
        internal bool IsSetMinConfidence()
        {
            return this._minConfidence.HasValue; 
        }

    }
}