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
    /// Provides information about a celebrity recognized by the <a>RecognizeCelebrities</a>
    /// operation.
    /// </summary>
    public partial class Celebrity
    {
        private ComparedFace _face;
        private string _id;
        private KnownGender _knownGender;
        private float? _matchConfidence;
        private string _name;
        private List<string> _urls = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Face. 
        /// <para>
        /// Provides information about the celebrity's face, such as its location on the image.
        /// </para>
        /// </summary>
        public ComparedFace Face
        {
            get { return this._face; }
            set { this._face = value; }
        }

        // Check to see if Face property is set
        internal bool IsSetFace()
        {
            return this._face != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the celebrity. 
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property KnownGender.
        /// </summary>
        public KnownGender KnownGender
        {
            get { return this._knownGender; }
            set { this._knownGender = value; }
        }

        // Check to see if KnownGender property is set
        internal bool IsSetKnownGender()
        {
            return this._knownGender != null;
        }

        /// <summary>
        /// Gets and sets the property MatchConfidence. 
        /// <para>
        /// The confidence, in percentage, that Amazon Rekognition has that the recognized face
        /// is the celebrity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? MatchConfidence
        {
            get { return this._matchConfidence; }
            set { this._matchConfidence = value; }
        }

        // Check to see if MatchConfidence property is set
        internal bool IsSetMatchConfidence()
        {
            return this._matchConfidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the celebrity.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Urls. 
        /// <para>
        /// An array of URLs pointing to additional information about the celebrity. If there
        /// is no additional information about the celebrity, this list is empty.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public List<string> Urls
        {
            get { return this._urls; }
            set { this._urls = value; }
        }

        // Check to see if Urls property is set
        internal bool IsSetUrls()
        {
            return this._urls != null && (this._urls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}