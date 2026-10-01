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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Represents the output of a <c>BatchWrite</c> operation.
    /// </summary>
    public partial class BatchWriteOperation
    {
        /// <summary>
        /// Gets and sets the property AddFacetToObject. 
        /// <para>
        /// A batch operation that adds a facet to an object.
        /// </para>
        /// </summary>
        public BatchAddFacetToObject AddFacetToObject { get; set; }

        /// <summary>
        /// Checks to see if the AddFacetToObject property is set.
        /// </summary>
        internal bool IsSetAddFacetToObject() => this.AddFacetToObject != null;

        /// <summary>
        /// Gets and sets the property AttachObject. 
        /// <para>
        /// Attaches an object to a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchAttachObject AttachObject { get; set; }

        /// <summary>
        /// Checks to see if the AttachObject property is set.
        /// </summary>
        internal bool IsSetAttachObject() => this.AttachObject != null;

        /// <summary>
        /// Gets and sets the property AttachPolicy. 
        /// <para>
        /// Attaches a policy object to a regular object. An object can have a limited number
        /// of attached policies.
        /// </para>
        /// </summary>
        public BatchAttachPolicy AttachPolicy { get; set; }

        /// <summary>
        /// Checks to see if the AttachPolicy property is set.
        /// </summary>
        internal bool IsSetAttachPolicy() => this.AttachPolicy != null;

        /// <summary>
        /// Gets and sets the property AttachToIndex. 
        /// <para>
        /// Attaches the specified object to the specified index.
        /// </para>
        /// </summary>
        public BatchAttachToIndex AttachToIndex { get; set; }

        /// <summary>
        /// Checks to see if the AttachToIndex property is set.
        /// </summary>
        internal bool IsSetAttachToIndex() => this.AttachToIndex != null;

        /// <summary>
        /// Gets and sets the property AttachTypedLink. 
        /// <para>
        /// Attaches a typed link to a specified source and target object. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public BatchAttachTypedLink AttachTypedLink { get; set; }

        /// <summary>
        /// Checks to see if the AttachTypedLink property is set.
        /// </summary>
        internal bool IsSetAttachTypedLink() => this.AttachTypedLink != null;

        /// <summary>
        /// Gets and sets the property CreateIndex. 
        /// <para>
        /// Creates an index object. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/indexing_search.htm">Indexing
        /// and search</a> for more information.
        /// </para>
        /// </summary>
        public BatchCreateIndex CreateIndex { get; set; }

        /// <summary>
        /// Checks to see if the CreateIndex property is set.
        /// </summary>
        internal bool IsSetCreateIndex() => this.CreateIndex != null;

        /// <summary>
        /// Gets and sets the property CreateObject. 
        /// <para>
        /// Creates an object.
        /// </para>
        /// </summary>
        public BatchCreateObject CreateObject { get; set; }

        /// <summary>
        /// Checks to see if the CreateObject property is set.
        /// </summary>
        internal bool IsSetCreateObject() => this.CreateObject != null;

        /// <summary>
        /// Gets and sets the property DeleteObject. 
        /// <para>
        /// Deletes an object in a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDeleteObject DeleteObject { get; set; }

        /// <summary>
        /// Checks to see if the DeleteObject property is set.
        /// </summary>
        internal bool IsSetDeleteObject() => this.DeleteObject != null;

        /// <summary>
        /// Gets and sets the property DetachFromIndex. 
        /// <para>
        /// Detaches the specified object from the specified index.
        /// </para>
        /// </summary>
        public BatchDetachFromIndex DetachFromIndex { get; set; }

        /// <summary>
        /// Checks to see if the DetachFromIndex property is set.
        /// </summary>
        internal bool IsSetDetachFromIndex() => this.DetachFromIndex != null;

        /// <summary>
        /// Gets and sets the property DetachObject. 
        /// <para>
        /// Detaches an object from a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDetachObject DetachObject { get; set; }

        /// <summary>
        /// Checks to see if the DetachObject property is set.
        /// </summary>
        internal bool IsSetDetachObject() => this.DetachObject != null;

        /// <summary>
        /// Gets and sets the property DetachPolicy. 
        /// <para>
        /// Detaches a policy from a <a>Directory</a>.
        /// </para>
        /// </summary>
        public BatchDetachPolicy DetachPolicy { get; set; }

        /// <summary>
        /// Checks to see if the DetachPolicy property is set.
        /// </summary>
        internal bool IsSetDetachPolicy() => this.DetachPolicy != null;

        /// <summary>
        /// Gets and sets the property DetachTypedLink. 
        /// <para>
        /// Detaches a typed link from a specified source and target object. For more information,
        /// see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public BatchDetachTypedLink DetachTypedLink { get; set; }

        /// <summary>
        /// Checks to see if the DetachTypedLink property is set.
        /// </summary>
        internal bool IsSetDetachTypedLink() => this.DetachTypedLink != null;

        /// <summary>
        /// Gets and sets the property RemoveFacetFromObject. 
        /// <para>
        /// A batch operation that removes a facet from an object.
        /// </para>
        /// </summary>
        public BatchRemoveFacetFromObject RemoveFacetFromObject { get; set; }

        /// <summary>
        /// Checks to see if the RemoveFacetFromObject property is set.
        /// </summary>
        internal bool IsSetRemoveFacetFromObject() => this.RemoveFacetFromObject != null;

        /// <summary>
        /// Gets and sets the property UpdateLinkAttributes. 
        /// <para>
        /// Updates a given object's attributes.
        /// </para>
        /// </summary>
        public BatchUpdateLinkAttributes UpdateLinkAttributes { get; set; }

        /// <summary>
        /// Checks to see if the UpdateLinkAttributes property is set.
        /// </summary>
        internal bool IsSetUpdateLinkAttributes() => this.UpdateLinkAttributes != null;

        /// <summary>
        /// Gets and sets the property UpdateObjectAttributes. 
        /// <para>
        /// Updates a given object's attributes.
        /// </para>
        /// </summary>
        public BatchUpdateObjectAttributes UpdateObjectAttributes { get; set; }

        /// <summary>
        /// Checks to see if the UpdateObjectAttributes property is set.
        /// </summary>
        internal bool IsSetUpdateObjectAttributes() => this.UpdateObjectAttributes != null;
    }
}
