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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the AttachTypedLink operation.
    /// Attaches a typed link to a specified source and target object. For more information,
    /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
    /// Links</a>.
    /// </summary>
    public partial class AttachTypedLinkRequest : AmazonCloudDirectoryRequest
    {
        private List<AttributeNameAndValue> _attributes = AWSConfigs.InitializeCollections ? new List<AttributeNameAndValue>() : null;
        private string _directoryArn;
        private ObjectReference _sourceObjectReference;
        private ObjectReference _targetObjectReference;
        private TypedLinkSchemaAndFacetName _typedLinkFacet;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// A set of attributes that are associated with the typed link.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AttributeNameAndValue> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the directory where you want to attach the typed
        /// link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceObjectReference. 
        /// <para>
        /// Identifies the source object that the typed link will attach to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference SourceObjectReference
        {
            get { return this._sourceObjectReference; }
            set { this._sourceObjectReference = value; }
        }

        // Check to see if SourceObjectReference property is set
        internal bool IsSetSourceObjectReference()
        {
            return this._sourceObjectReference != null;
        }

        /// <summary>
        /// Gets and sets the property TargetObjectReference. 
        /// <para>
        /// Identifies the target object that the typed link will attach to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ObjectReference TargetObjectReference
        {
            get { return this._targetObjectReference; }
            set { this._targetObjectReference = value; }
        }

        // Check to see if TargetObjectReference property is set
        internal bool IsSetTargetObjectReference()
        {
            return this._targetObjectReference != null;
        }

        /// <summary>
        /// Gets and sets the property TypedLinkFacet. 
        /// <para>
        /// Identifies the typed link facet that is associated with the typed link.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TypedLinkSchemaAndFacetName TypedLinkFacet
        {
            get { return this._typedLinkFacet; }
            set { this._typedLinkFacet = value; }
        }

        // Check to see if TypedLinkFacet property is set
        internal bool IsSetTypedLinkFacet()
        {
            return this._typedLinkFacet != null;
        }

    }
}