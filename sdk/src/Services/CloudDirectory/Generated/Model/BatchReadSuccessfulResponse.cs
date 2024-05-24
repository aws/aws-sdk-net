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
    /// Represents the output of a <c>BatchRead</c> success response operation.
    /// </summary>
    public partial class BatchReadSuccessfulResponse
    {
        private BatchGetLinkAttributesResponse _getLinkAttributes;
        private BatchGetObjectAttributesResponse _getObjectAttributes;
        private BatchGetObjectInformationResponse _getObjectInformation;
        private BatchListAttachedIndicesResponse _listAttachedIndices;
        private BatchListIncomingTypedLinksResponse _listIncomingTypedLinks;
        private BatchListIndexResponse _listIndex;
        private BatchListObjectAttributesResponse _listObjectAttributes;
        private BatchListObjectChildrenResponse _listObjectChildren;
        private BatchListObjectParentPathsResponse _listObjectParentPaths;
        private BatchListObjectParentsResponse _listObjectParents;
        private BatchListObjectPoliciesResponse _listObjectPolicies;
        private BatchListOutgoingTypedLinksResponse _listOutgoingTypedLinks;
        private BatchListPolicyAttachmentsResponse _listPolicyAttachments;
        private BatchLookupPolicyResponse _lookupPolicy;

        /// <summary>
        /// Gets and sets the property GetLinkAttributes. 
        /// <para>
        /// The list of attributes to retrieve from the typed link.
        /// </para>
        /// </summary>
        public BatchGetLinkAttributesResponse GetLinkAttributes
        {
            get { return this._getLinkAttributes; }
            set { this._getLinkAttributes = value; }
        }

        // Check to see if GetLinkAttributes property is set
        internal bool IsSetGetLinkAttributes()
        {
            return this._getLinkAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property GetObjectAttributes. 
        /// <para>
        /// Retrieves attributes within a facet that are associated with an object.
        /// </para>
        /// </summary>
        public BatchGetObjectAttributesResponse GetObjectAttributes
        {
            get { return this._getObjectAttributes; }
            set { this._getObjectAttributes = value; }
        }

        // Check to see if GetObjectAttributes property is set
        internal bool IsSetGetObjectAttributes()
        {
            return this._getObjectAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property GetObjectInformation. 
        /// <para>
        /// Retrieves metadata about an object.
        /// </para>
        /// </summary>
        public BatchGetObjectInformationResponse GetObjectInformation
        {
            get { return this._getObjectInformation; }
            set { this._getObjectInformation = value; }
        }

        // Check to see if GetObjectInformation property is set
        internal bool IsSetGetObjectInformation()
        {
            return this._getObjectInformation != null;
        }

        /// <summary>
        /// Gets and sets the property ListAttachedIndices. 
        /// <para>
        /// Lists indices attached to an object.
        /// </para>
        /// </summary>
        public BatchListAttachedIndicesResponse ListAttachedIndices
        {
            get { return this._listAttachedIndices; }
            set { this._listAttachedIndices = value; }
        }

        // Check to see if ListAttachedIndices property is set
        internal bool IsSetListAttachedIndices()
        {
            return this._listAttachedIndices != null;
        }

        /// <summary>
        /// Gets and sets the property ListIncomingTypedLinks. 
        /// <para>
        /// Returns a paginated list of all the incoming <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public BatchListIncomingTypedLinksResponse ListIncomingTypedLinks
        {
            get { return this._listIncomingTypedLinks; }
            set { this._listIncomingTypedLinks = value; }
        }

        // Check to see if ListIncomingTypedLinks property is set
        internal bool IsSetListIncomingTypedLinks()
        {
            return this._listIncomingTypedLinks != null;
        }

        /// <summary>
        /// Gets and sets the property ListIndex. 
        /// <para>
        /// Lists objects attached to the specified index.
        /// </para>
        /// </summary>
        public BatchListIndexResponse ListIndex
        {
            get { return this._listIndex; }
            set { this._listIndex = value; }
        }

        // Check to see if ListIndex property is set
        internal bool IsSetListIndex()
        {
            return this._listIndex != null;
        }

        /// <summary>
        /// Gets and sets the property ListObjectAttributes. 
        /// <para>
        /// Lists all attributes that are associated with an object.
        /// </para>
        /// </summary>
        public BatchListObjectAttributesResponse ListObjectAttributes
        {
            get { return this._listObjectAttributes; }
            set { this._listObjectAttributes = value; }
        }

        // Check to see if ListObjectAttributes property is set
        internal bool IsSetListObjectAttributes()
        {
            return this._listObjectAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property ListObjectChildren. 
        /// <para>
        /// Returns a paginated list of child objects that are associated with a given object.
        /// </para>
        /// </summary>
        public BatchListObjectChildrenResponse ListObjectChildren
        {
            get { return this._listObjectChildren; }
            set { this._listObjectChildren = value; }
        }

        // Check to see if ListObjectChildren property is set
        internal bool IsSetListObjectChildren()
        {
            return this._listObjectChildren != null;
        }

        /// <summary>
        /// Gets and sets the property ListObjectParentPaths. 
        /// <para>
        /// Retrieves all available parent paths for any object type such as node, leaf node,
        /// policy node, and index node objects. For more information about objects, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/key_concepts_directorystructure.html">Directory
        /// Structure</a>.
        /// </para>
        /// </summary>
        public BatchListObjectParentPathsResponse ListObjectParentPaths
        {
            get { return this._listObjectParentPaths; }
            set { this._listObjectParentPaths = value; }
        }

        // Check to see if ListObjectParentPaths property is set
        internal bool IsSetListObjectParentPaths()
        {
            return this._listObjectParentPaths != null;
        }

        /// <summary>
        /// Gets and sets the property ListObjectParents. 
        /// <para>
        /// The list of parent objects to retrieve.
        /// </para>
        /// </summary>
        public BatchListObjectParentsResponse ListObjectParents
        {
            get { return this._listObjectParents; }
            set { this._listObjectParents = value; }
        }

        // Check to see if ListObjectParents property is set
        internal bool IsSetListObjectParents()
        {
            return this._listObjectParents != null;
        }

        /// <summary>
        /// Gets and sets the property ListObjectPolicies. 
        /// <para>
        /// Returns policies attached to an object in pagination fashion.
        /// </para>
        /// </summary>
        public BatchListObjectPoliciesResponse ListObjectPolicies
        {
            get { return this._listObjectPolicies; }
            set { this._listObjectPolicies = value; }
        }

        // Check to see if ListObjectPolicies property is set
        internal bool IsSetListObjectPolicies()
        {
            return this._listObjectPolicies != null;
        }

        /// <summary>
        /// Gets and sets the property ListOutgoingTypedLinks. 
        /// <para>
        /// Returns a paginated list of all the outgoing <a>TypedLinkSpecifier</a> information
        /// for an object. It also supports filtering by typed link facet and identity attributes.
        /// For more information, see <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/directory_objects_links.html#directory_objects_links_typedlink">Typed
        /// Links</a>.
        /// </para>
        /// </summary>
        public BatchListOutgoingTypedLinksResponse ListOutgoingTypedLinks
        {
            get { return this._listOutgoingTypedLinks; }
            set { this._listOutgoingTypedLinks = value; }
        }

        // Check to see if ListOutgoingTypedLinks property is set
        internal bool IsSetListOutgoingTypedLinks()
        {
            return this._listOutgoingTypedLinks != null;
        }

        /// <summary>
        /// Gets and sets the property ListPolicyAttachments. 
        /// <para>
        /// Returns all of the <c>ObjectIdentifiers</c> to which a given policy is attached.
        /// </para>
        /// </summary>
        public BatchListPolicyAttachmentsResponse ListPolicyAttachments
        {
            get { return this._listPolicyAttachments; }
            set { this._listPolicyAttachments = value; }
        }

        // Check to see if ListPolicyAttachments property is set
        internal bool IsSetListPolicyAttachments()
        {
            return this._listPolicyAttachments != null;
        }

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
        public BatchLookupPolicyResponse LookupPolicy
        {
            get { return this._lookupPolicy; }
            set { this._lookupPolicy = value; }
        }

        // Check to see if LookupPolicy property is set
        internal bool IsSetLookupPolicy()
        {
            return this._lookupPolicy != null;
        }

    }
}