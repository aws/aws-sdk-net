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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Structure containing details about the detected label, including the name, detected
    /// instances, parent labels, and level of confidence.
    /// 
    ///  
    /// <para>
    ///  
    /// </para>
    /// </summary>
    public partial class Label
    {
        private List<LabelAlias> _aliases = new List<LabelAlias>();
        private List<LabelCategory> _categories = new List<LabelCategory>();
        private float? _confidence;
        private List<Instance> _instances = new List<Instance>();
        private string _name;
        private List<Parent> _parents = new List<Parent>();

        /// <summary>
        /// Gets and sets the property Aliases. 
        /// <para>
        /// A list of potential aliases for a given label.
        /// </para>
        /// </summary>
        public List<LabelAlias> Aliases
        {
            get { return this._aliases; }
            set { this._aliases = value; }
        }

        // Check to see if Aliases property is set
        internal bool IsSetAliases()
        {
            return this._aliases != null && this._aliases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Categories. 
        /// <para>
        /// A list of the categories associated with a given label.
        /// </para>
        /// </summary>
        public List<LabelCategory> Categories
        {
            get { return this._categories; }
            set { this._categories = value; }
        }

        // Check to see if Categories property is set
        internal bool IsSetCategories()
        {
            return this._categories != null && this._categories.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Level of confidence.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Instances. 
        /// <para>
        /// If <code>Label</code> represents an object, <code>Instances</code> contains the bounding
        /// boxes for each instance of the detected object. Bounding boxes are returned for common
        /// object labels such as people, cars, furniture, apparel or pets.
        /// </para>
        /// </summary>
        public List<Instance> Instances
        {
            get { return this._instances; }
            set { this._instances = value; }
        }

        // Check to see if Instances property is set
        internal bool IsSetInstances()
        {
            return this._instances != null && this._instances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name (label) of the object or scene.
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
        /// Gets and sets the property Parents. 
        /// <para>
        /// The parent labels for a label. The response includes all ancestor labels.
        /// </para>
        /// </summary>
        public List<Parent> Parents
        {
            get { return this._parents; }
            set { this._parents = value; }
        }

        // Check to see if Parents property is set
        internal bool IsSetParents()
        {
            return this._parents != null && this._parents.Count > 0; 
        }

    }
}