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
    /// Provides information about a single type of inappropriate, unwanted, or offensive
    /// content found in an image or video. Each type of moderated content has a label within
    /// a hierarchical taxonomy. For more information, see Content moderation in the Amazon
    /// Rekognition Developer Guide.
    /// </summary>
    public partial class ModerationLabel
    {
        private float? _confidence;
        private string _name;
        private string _parentName;
        private int? _taxonomyLevel;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Specifies the confidence that Amazon Rekognition has that the label has been correctly
        /// identified.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify the <c>MinConfidence</c> parameter in the call to <c>DetectModerationLabels</c>,
        /// the operation returns labels with a confidence value greater than or equal to 50 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? Confidence
        {
            get { return this._confidence; }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The label name for the type of unsafe content detected in the image.
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
        /// Gets and sets the property ParentName. 
        /// <para>
        /// The name for the parent label. Labels at the top level of the hierarchy have the parent
        /// label <c>""</c>.
        /// </para>
        /// </summary>
        public string ParentName
        {
            get { return this._parentName; }
            set { this._parentName = value; }
        }

        // Check to see if ParentName property is set
        internal bool IsSetParentName()
        {
            return this._parentName != null;
        }

        /// <summary>
        /// Gets and sets the property TaxonomyLevel. 
        /// <para>
        /// The level of the moderation label with regard to its taxonomy, from 1 to 3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? TaxonomyLevel
        {
            get { return this._taxonomyLevel; }
            set { this._taxonomyLevel = value; }
        }

        // Check to see if TaxonomyLevel property is set
        internal bool IsSetTaxonomyLevel()
        {
            return this._taxonomyLevel.HasValue; 
        }

    }
}