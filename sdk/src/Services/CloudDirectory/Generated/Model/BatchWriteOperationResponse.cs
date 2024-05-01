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
    /// Represents the output of a <c>BatchWrite</c> response operation.
    /// </summary>
    public partial class BatchWriteOperationResponse
    {
        private BatchAddFacetToObjectResponse _addFacetToObject;
        private BatchAttachObjectResponse _attachObject;
        private BatchAttachPolicyResponse _attachPolicy;
        private BatchAttachToIndexResponse _attachToIndex;
        private BatchAttachTypedLinkResponse _attachTypedLink;
        private BatchCreateIndexResponse _createIndex;
        private BatchCreateObjectResponse _createObject;
        private BatchDeleteObjectResponse _deleteObject;
        private BatchDetachFromIndexResponse _detachFromIndex;
        private BatchDetachObjectResponse _detachObject;
        private BatchDetachPolicyResponse _detachPolicy;
        private BatchDetachTypedLinkResponse _detachTypedLink;
        private BatchRemoveFacetFromObjectResponse _removeFacetFromObject;
        private BatchUpdateLinkAttributesResponse _updateLinkAttributes;
        private BatchUpdateObjectAttributesResponse _updateObjectAttributes;

        /// <summary>
        /// Gets and sets the property AddFacetToObject. 
        /// <para>
        /// The result of an add facet to object batch operation.
        /// </para>
        /// </summary>
        public BatchAddFacetToObjectResponse AddFacetToObject
        {
            get { return this._addFacetToObject; }
            set { this._addFacetToObject = value; }
        }

        // Check to see if AddFacetToObject property is set
        internal bool IsSetAddFacetToObject()
        {
            return this._addFacetToObject != null;
        }

        /// <summary>
        /// Gets and sets the property AttachObject. 
        /// <para>
        /// Attaches an object to a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchAttachObjectResponse AttachObject
        {
            get { return this._attachObject; }
            set { this._attachObject = value; }
        }

        // Check to see if AttachObject property is set
        internal bool IsSetAttachObject()
        {
            return this._attachObject != null;
        }

        /// <summary>
        /// Gets and sets the property AttachPolicy. 
        /// <para>
        /// Attaches a policy object to a regular object. An object can have a limited number
        /// of attached policies.
        /// </para>
        /// </summary>
        public BatchAttachPolicyResponse AttachPolicy
        {
            get { return this._attachPolicy; }
            set { this._attachPolicy = value; }
        }

        // Check to see if AttachPolicy property is set
        internal bool IsSetAttachPolicy()
        {
            return this._attachPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property AttachToIndex. 
        /// <para>
        /// Attaches the specified object to the specified index.
        /// </para>
        /// </summary>
        public BatchAttachToIndexResponse AttachToIndex
        {
            get { return this._attachToIndex; }
            set { this._attachToIndex = value; }
        }

        // Check to see if AttachToIndex property is set
        internal bool IsSetAttachToIndex()
        {
            return this._attachToIndex != null;
        }

        /// <summary>
        /// Gets and sets the property AttachTypedLink. 
        /// <para>
        /// Attaches a typed link to a specified source and target object. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public BatchAttachTypedLinkResponse AttachTypedLink
        {
            get { return this._attachTypedLink; }
            set { this._attachTypedLink = value; }
        }

        // Check to see if AttachTypedLink property is set
        internal bool IsSetAttachTypedLink()
        {
            return this._attachTypedLink != null;
        }

        /// <summary>
        /// Gets and sets the property CreateIndex. 
        /// <para>
        /// Creates an index object. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/indexing_search.htm">Indexing
        /// and search</a> for more information.
        /// </para>
        /// </summary>
        public BatchCreateIndexResponse CreateIndex
        {
            get { return this._createIndex; }
            set { this._createIndex = value; }
        }

        // Check to see if CreateIndex property is set
        internal bool IsSetCreateIndex()
        {
            return this._createIndex != null;
        }

        /// <summary>
        /// Gets and sets the property CreateObject. 
        /// <para>
        /// Creates an object in a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchCreateObjectResponse CreateObject
        {
            get { return this._createObject; }
            set { this._createObject = value; }
        }

        // Check to see if CreateObject property is set
        internal bool IsSetCreateObject()
        {
            return this._createObject != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteObject. 
        /// <para>
        /// Deletes an object in a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDeleteObjectResponse DeleteObject
        {
            get { return this._deleteObject; }
            set { this._deleteObject = value; }
        }

        // Check to see if DeleteObject property is set
        internal bool IsSetDeleteObject()
        {
            return this._deleteObject != null;
        }

        /// <summary>
        /// Gets and sets the property DetachFromIndex. 
        /// <para>
        /// Detaches the specified object from the specified index.
        /// </para>
        /// </summary>
        public BatchDetachFromIndexResponse DetachFromIndex
        {
            get { return this._detachFromIndex; }
            set { this._detachFromIndex = value; }
        }

        // Check to see if DetachFromIndex property is set
        internal bool IsSetDetachFromIndex()
        {
            return this._detachFromIndex != null;
        }

        /// <summary>
        /// Gets and sets the property DetachObject. 
        /// <para>
        /// Detaches an object from a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDetachObjectResponse DetachObject
        {
            get { return this._detachObject; }
            set { this._detachObject = value; }
        }

        // Check to see if DetachObject property is set
        internal bool IsSetDetachObject()
        {
            return this._detachObject != null;
        }

        /// <summary>
        /// Gets and sets the property DetachPolicy. 
        /// <para>
        /// Detaches a policy from a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDetachPolicyResponse DetachPolicy
        {
            get { return this._detachPolicy; }
            set { this._detachPolicy = value; }
        }

        // Check to see if DetachPolicy property is set
        internal bool IsSetDetachPolicy()
        {
            return this._detachPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property DetachTypedLink. 
        /// <para>
        /// Detaches a typed link from a specified source and target object. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public BatchDetachTypedLinkResponse DetachTypedLink
        {
            get { return this._detachTypedLink; }
            set { this._detachTypedLink = value; }
        }

        // Check to see if DetachTypedLink property is set
        internal bool IsSetDetachTypedLink()
        {
            return this._detachTypedLink != null;
        }

        /// <summary>
        /// Gets and sets the property RemoveFacetFromObject. 
        /// <para>
        /// The result of a batch remove facet from object operation.
        /// </para>
        /// </summary>
        public BatchRemoveFacetFromObjectResponse RemoveFacetFromObject
        {
            get { return this._removeFacetFromObject; }
            set { this._removeFacetFromObject = value; }
        }

        // Check to see if RemoveFacetFromObject property is set
        internal bool IsSetRemoveFacetFromObject()
        {
            return this._removeFacetFromObject != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateLinkAttributes. 
        /// <para>
        /// Represents the output of a <c>BatchWrite</c> response operation.
        /// </para>
        /// </summary>
        public BatchUpdateLinkAttributesResponse UpdateLinkAttributes
        {
            get { return this._updateLinkAttributes; }
            set { this._updateLinkAttributes = value; }
        }

        // Check to see if UpdateLinkAttributes property is set
        internal bool IsSetUpdateLinkAttributes()
        {
            return this._updateLinkAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateObjectAttributes. 
        /// <para>
        /// Updates a given object’s attributes.
        /// </para>
        /// </summary>
        public BatchUpdateObjectAttributesResponse UpdateObjectAttributes
        {
            get { return this._updateObjectAttributes; }
            set { this._updateObjectAttributes = value; }
        }

        // Check to see if UpdateObjectAttributes property is set
        internal bool IsSetUpdateObjectAttributes()
        {
            return this._updateObjectAttributes != null;
        }

    }
}