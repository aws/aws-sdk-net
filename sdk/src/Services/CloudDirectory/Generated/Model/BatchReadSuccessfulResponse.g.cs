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
    /// Represents the output of a <c>BatchRead</c> success response operation.
    /// </summary>
    public partial class BatchReadSuccessfulResponse
    {
        /// <summary>
        /// Gets and sets the property GetLinkAttributes. 
        /// <para>
        /// The list of attributes to retrieve from the typed link.
        /// </para>
        /// </summary>
        public BatchGetLinkAttributesResponse GetLinkAttributes { get; set; }

        /// <summary>
        /// Checks to see if the GetLinkAttributes property is set.
        /// </summary>
        internal bool IsSetGetLinkAttributes() => this.GetLinkAttributes != null;

        /// <summary>
        /// Gets and sets the property GetObjectAttributes. 
        /// <para>
        /// Retrieves attributes within a facet that are associated with an object.
        /// </para>
        /// </summary>
        public BatchGetObjectAttributesResponse GetObjectAttributes { get; set; }

        /// <summary>
        /// Checks to see if the GetObjectAttributes property is set.
        /// </summary>
        internal bool IsSetGetObjectAttributes() => this.GetObjectAttributes != null;

        /// <summary>
        /// Gets and sets the property GetObjectInformation. 
        /// <para>
        /// Retrieves metadata about an object.
        /// </para>
        /// </summary>
        public BatchGetObjectInformationResponse GetObjectInformation { get; set; }

        /// <summary>
        /// Checks to see if the GetObjectInformation property is set.
        /// </summary>
        internal bool IsSetGetObjectInformation() => this.GetObjectInformation != null;

        /// <summary>
        /// Gets and sets the property ListAttachedIndices. 
        /// <para>
        /// Lists indices attached to an object.
        /// </para>
        /// </summary>
        public BatchListAttachedIndicesResponse ListAttachedIndices { get; set; }

        /// <summary>
        /// Checks to see if the ListAttachedIndices property is set.
        /// </summary>
        internal bool IsSetListAttachedIndices() => this.ListAttachedIndices != null;

        /// <summary>
        /// Gets and sets the property ListIncomingTypedLinks. 
        /// <para>
        /// Returns a paginated list of all the incoming <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public BatchListIncomingTypedLinksResponse ListIncomingTypedLinks { get; set; }

        /// <summary>
        /// Checks to see if the ListIncomingTypedLinks property is set.
        /// </summary>
        internal bool IsSetListIncomingTypedLinks() => this.ListIncomingTypedLinks != null;

        /// <summary>
        /// Gets and sets the property ListIndex. 
        /// <para>
        /// Lists objects attached to the specified index.
        /// </para>
        /// </summary>
        public BatchListIndexResponse ListIndex { get; set; }

        /// <summary>
        /// Checks to see if the ListIndex property is set.
        /// </summary>
        internal bool IsSetListIndex() => this.ListIndex != null;

        /// <summary>
        /// Gets and sets the property ListObjectAttributes. 
        /// <para>
        /// Lists all attributes that are associated with an object.
        /// </para>
        /// </summary>
        public BatchListObjectAttributesResponse ListObjectAttributes { get; set; }

        /// <summary>
        /// Checks to see if the ListObjectAttributes property is set.
        /// </summary>
        internal bool IsSetListObjectAttributes() => this.ListObjectAttributes != null;

        /// <summary>
        /// Gets and sets the property ListObjectChildren. 
        /// <para>
        /// Returns a paginated list of child objects that are associated with a given object.
        /// </para>
        /// </summary>
        public BatchListObjectChildrenResponse ListObjectChildren { get; set; }

        /// <summary>
        /// Checks to see if the ListObjectChildren property is set.
        /// </summary>
        internal bool IsSetListObjectChildren() => this.ListObjectChildren != null;

        /// <summary>
        /// Gets and sets the property ListObjectParentPaths. 
        /// <para>
        /// Retrieves all available parent paths for any object type such as node, leaf node,
        /// policy node, and index node objects. For more information about objects, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directorystructure.html">Directory
        /// Structure</a>.
        /// </para>
        /// </summary>
        public BatchListObjectParentPathsResponse ListObjectParentPaths { get; set; }

        /// <summary>
        /// Checks to see if the ListObjectParentPaths property is set.
        /// </summary>
        internal bool IsSetListObjectParentPaths() => this.ListObjectParentPaths != null;

        /// <summary>
        /// Gets and sets the property ListObjectParents. 
        /// <para>
        /// The list of parent objects to retrieve.
        /// </para>
        /// </summary>
        public BatchListObjectParentsResponse ListObjectParents { get; set; }

        /// <summary>
        /// Checks to see if the ListObjectParents property is set.
        /// </summary>
        internal bool IsSetListObjectParents() => this.ListObjectParents != null;

        /// <summary>
        /// Gets and sets the property ListObjectPolicies. 
        /// <para>
        /// Returns policies attached to an object in pagination fashion.
        /// </para>
        /// </summary>
        public BatchListObjectPoliciesResponse ListObjectPolicies { get; set; }

        /// <summary>
        /// Checks to see if the ListObjectPolicies property is set.
        /// </summary>
        internal bool IsSetListObjectPolicies() => this.ListObjectPolicies != null;

        /// <summary>
        /// Gets and sets the property ListOutgoingTypedLinks. 
        /// <para>
        /// Returns a paginated list of all the outgoing <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public BatchListOutgoingTypedLinksResponse ListOutgoingTypedLinks { get; set; }

        /// <summary>
        /// Checks to see if the ListOutgoingTypedLinks property is set.
        /// </summary>
        internal bool IsSetListOutgoingTypedLinks() => this.ListOutgoingTypedLinks != null;

        /// <summary>
        /// Gets and sets the property ListPolicyAttachments. 
        /// <para>
        /// Returns all of the <c>ObjectIdentifiers</c> to which a given policy is attached.
        /// </para>
        /// </summary>
        public BatchListPolicyAttachmentsResponse ListPolicyAttachments { get; set; }

        /// <summary>
        /// Checks to see if the ListPolicyAttachments property is set.
        /// </summary>
        internal bool IsSetListPolicyAttachments() => this.ListPolicyAttachments != null;

        /// <summary>
        /// Gets and sets the property LookupPolicy. 
        /// <para>
        /// Lists all policies from the root of the <a>Directory</a> to the object specified.
        /// If there are no policies present, an empty list is returned. If policies are present,
        /// and if some objects don't have the policies attached, it returns the <c>ObjectIdentifier</c>
        /// for such objects. If policies are present, it returns <c>ObjectIdentifier</c>, <c>policyId</c>,
        /// and <c>policyType</c>. Paths that don't lead to the root from the target object are
        /// ignored. For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directory.html#key_concepts_policies">Policies</a>.
        /// </para>
        /// </summary>
        public BatchLookupPolicyResponse LookupPolicy { get; set; }

        /// <summary>
        /// Checks to see if the LookupPolicy property is set.
        /// </summary>
        internal bool IsSetLookupPolicy() => this.LookupPolicy != null;
    }
}
