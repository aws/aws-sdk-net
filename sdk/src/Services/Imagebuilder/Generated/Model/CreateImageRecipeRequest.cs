/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the CreateImageRecipe operation.
    /// Creates a new image recipe. Image Recipes defines how images are configured, tested
    /// and assessed.
    /// </summary>
    public partial class CreateImageRecipeRequest : AmazonImagebuilderRequest
    {
        private List<InstanceBlockDeviceMapping> _blockDeviceMappings = new List<InstanceBlockDeviceMapping>();
        private string _clientToken;
        private List<ComponentConfiguration> _components = new List<ComponentConfiguration>();
        private string _description;
        private string _name;
        private string _parentImage;
        private string _semanticVersion;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        ///  The block device mappings of the image recipe. 
        /// </para>
        /// </summary>
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && this._blockDeviceMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  The idempotency token used to make this request idempotent. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Components. 
        /// <para>
        ///  The components of the image recipe. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<ComponentConfiguration> Components
        {
            get { return this._components; }
            set { this._components = value; }
        }

        // Check to see if Components property is set
        internal bool IsSetComponents()
        {
            return this._components != null && this._components.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the image recipe. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the image recipe. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ParentImage. 
        /// <para>
        ///  The parent image of the image recipe. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ParentImage
        {
            get { return this._parentImage; }
            set { this._parentImage = value; }
        }

        // Check to see if ParentImage property is set
        internal bool IsSetParentImage()
        {
            return this._parentImage != null;
        }

        /// <summary>
        /// Gets and sets the property SemanticVersion. 
        /// <para>
        ///  The semantic version of the image recipe. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SemanticVersion
        {
            get { return this._semanticVersion; }
            set { this._semanticVersion = value; }
        }

        // Check to see if SemanticVersion property is set
        internal bool IsSetSemanticVersion()
        {
            return this._semanticVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  The tags of the image recipe. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}