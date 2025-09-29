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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// A summary of a container recipe
    /// </summary>
    public partial class ContainerRecipeSummary
    {
        private string _arn;
        private ContainerType _containerType;
        private string _dateCreated;
        private string _instanceImage;
        private string _name;
        private string _owner;
        private string _parentImage;
        private Platform _platform;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the container recipe.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerType. 
        /// <para>
        /// Specifies the type of container, such as "Docker".
        /// </para>
        /// </summary>
        public ContainerType ContainerType
        {
            get { return this._containerType; }
            set { this._containerType = value; }
        }

        // Check to see if ContainerType property is set
        internal bool IsSetContainerType()
        {
            return this._containerType != null;
        }

        /// <summary>
        /// Gets and sets the property DateCreated. 
        /// <para>
        /// The date when this container recipe was created.
        /// </para>
        /// </summary>
        public string DateCreated
        {
            get { return this._dateCreated; }
            set { this._dateCreated = value; }
        }

        // Check to see if DateCreated property is set
        internal bool IsSetDateCreated()
        {
            return this._dateCreated != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceImage. 
        /// <para>
        /// The base image for a container build and test instance. This can contain an AMI ID
        /// or it can specify an Amazon Web Services Systems Manager (SSM) Parameter Store Parameter,
        /// prefixed by <c>ssm:</c>, followed by the parameter name or ARN.
        /// </para>
        ///  
        /// <para>
        /// If not specified, Image Builder uses the appropriate ECS-optimized AMI as a base image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string InstanceImage
        {
            get { return this._instanceImage; }
            set { this._instanceImage = value; }
        }

        // Check to see if InstanceImage property is set
        internal bool IsSetInstanceImage()
        {
            return this._instanceImage != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the container recipe.
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
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property ParentImage. 
        /// <para>
        /// The base image for the container recipe.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The system platform for the container, such as Windows or Linux.
        /// </para>
        /// </summary>
        public Platform Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags that are attached to the container recipe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}