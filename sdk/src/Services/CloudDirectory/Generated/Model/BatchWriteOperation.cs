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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Represents the output of a <code>BatchWrite</code> operation.
    /// </summary>
    public partial class BatchWriteOperation
    {
        private BatchAddFacetToObject _addFacetToObject;
        private BatchAttachObject _attachObject;
        private BatchCreateObject _createObject;
        private BatchDeleteObject _deleteObject;
        private BatchDetachObject _detachObject;
        private BatchRemoveFacetFromObject _removeFacetFromObject;
        private BatchUpdateObjectAttributes _updateObjectAttributes;

        /// <summary>
        /// Gets and sets the property AddFacetToObject. 
        /// <para>
        /// A batch operation that adds a facet to an object.
        /// </para>
        /// </summary>
        public BatchAddFacetToObject AddFacetToObject
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
        public BatchAttachObject AttachObject
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
        /// Gets and sets the property CreateObject. 
        /// <para>
        /// Creates an object.
        /// </para>
        /// </summary>
        public BatchCreateObject CreateObject
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
        public BatchDeleteObject DeleteObject
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
        /// Gets and sets the property DetachObject. 
        /// <para>
        /// Detaches an object from a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDetachObject DetachObject
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
        /// Gets and sets the property RemoveFacetFromObject. 
        /// <para>
        /// A batch operation that removes a facet from an object.
        /// </para>
        /// </summary>
        public BatchRemoveFacetFromObject RemoveFacetFromObject
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
        /// Gets and sets the property UpdateObjectAttributes. 
        /// <para>
        /// Updates a given object's attributes.
        /// </para>
        /// </summary>
        public BatchUpdateObjectAttributes UpdateObjectAttributes
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