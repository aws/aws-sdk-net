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
    /// Represents the output of a <code>BatchRead</code> operation.
    /// </summary>
    public partial class BatchReadOperation
    {
        private BatchGetObjectAttributes _getObjectAttributes;
        private BatchGetObjectInformation _getObjectInformation;
        private BatchListAttachedIndices _listAttachedIndices;
        private BatchListIncomingTypedLinks _listIncomingTypedLinks;
        private BatchListIndex _listIndex;
        private BatchListObjectAttributes _listObjectAttributes;
        private BatchListObjectChildren _listObjectChildren;
        private BatchListObjectParentPaths _listObjectParentPaths;
        private BatchListObjectPolicies _listObjectPolicies;
        private BatchListOutgoingTypedLinks _listOutgoingTypedLinks;
        private BatchListPolicyAttachments _listPolicyAttachments;
        private BatchLookupPolicy _lookupPolicy;

        /// <summary>
        /// Gets and sets the property GetObjectAttributes. 
        /// <para>
        /// Retrieves attributes within a facet that are associated with an object.
        /// </para>
        /// </summary>
        public BatchGetObjectAttributes GetObjectAttributes
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
        public BatchGetObjectInformation GetObjectInformation
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
        public BatchListAttachedIndices ListAttachedIndices
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
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </para>
        /// </summary>
        public BatchListIncomingTypedLinks ListIncomingTypedLinks
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
        public BatchListIndex ListIndex
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
        public BatchListObjectAttributes ListObjectAttributes
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
        public BatchListObjectChildren ListObjectChildren
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
        /// policy node, and index node objects. For more information about objects, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_key_concepts.html#dirstructure">Directory
        /// Structure</a>.
        /// </para>
        /// </summary>
        public BatchListObjectParentPaths ListObjectParentPaths
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
        /// Gets and sets the property ListObjectPolicies. 
        /// <para>
        /// Returns policies attached to an object in pagination fashion.
        /// </para>
        /// </summary>
        public BatchListObjectPolicies ListObjectPolicies
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
        /// For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/objectsandlinks.html#typedlink">Typed
        /// link</a>.
        /// </para>
        /// </summary>
        public BatchListOutgoingTypedLinks ListOutgoingTypedLinks
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
        /// Returns all of the <code>ObjectIdentifiers</code> to which a given policy is attached.
        /// </para>
        /// </summary>
        public BatchListPolicyAttachments ListPolicyAttachments
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
        /// and if some objects don't have the policies attached, it returns the <code>ObjectIdentifier</code>
        /// for such objects. If policies are present, it returns <code>ObjectIdentifier</code>,
        /// <code>policyId</code>, and <code>policyType</code>. Paths that don't lead to the root
        /// from the target object are ignored. For more information, see <a href="http://docs.aws.amazon.com/directoryservice/latest/admin-guide/cd_key_concepts.html#policies">Policies</a>.
        /// </para>
        /// </summary>
        public BatchLookupPolicy LookupPolicy
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