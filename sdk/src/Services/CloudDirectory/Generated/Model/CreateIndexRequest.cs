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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the CreateIndex operation.
    /// Creates an index object. See <a href="https://docs.aws.amazon.com/clouddirectory/latest/developerguide/indexing_search.html">Indexing
    /// and search</a> for more information.
    /// </summary>
    public partial class CreateIndexRequest : AmazonCloudDirectoryRequest
    {
        private string _directoryArn;
        private bool? _isUnique;
        private string _linkName;
        private List<AttributeKey> _orderedIndexedAttributeList = new List<AttributeKey>();
        private ObjectReference _parentReference;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The ARN of the directory where the index should be created.
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
        /// Gets and sets the property IsUnique. 
        /// <para>
        /// Indicates whether the attribute that is being indexed has unique values or not.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool IsUnique
        {
            get { return this._isUnique.GetValueOrDefault(); }
            set { this._isUnique = value; }
        }

        // Check to see if IsUnique property is set
        internal bool IsSetIsUnique()
        {
            return this._isUnique.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LinkName. 
        /// <para>
        /// The name of the link between the parent object and the index object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string LinkName
        {
            get { return this._linkName; }
            set { this._linkName = value; }
        }

        // Check to see if LinkName property is set
        internal bool IsSetLinkName()
        {
            return this._linkName != null;
        }

        /// <summary>
        /// Gets and sets the property OrderedIndexedAttributeList. 
        /// <para>
        /// Specifies the attributes that should be indexed on. Currently only a single attribute
        /// is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AttributeKey> OrderedIndexedAttributeList
        {
            get { return this._orderedIndexedAttributeList; }
            set { this._orderedIndexedAttributeList = value; }
        }

        // Check to see if OrderedIndexedAttributeList property is set
        internal bool IsSetOrderedIndexedAttributeList()
        {
            return this._orderedIndexedAttributeList != null && this._orderedIndexedAttributeList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ParentReference. 
        /// <para>
        /// A reference to the parent object that contains the index object.
        /// </para>
        /// </summary>
        public ObjectReference ParentReference
        {
            get { return this._parentReference; }
            set { this._parentReference = value; }
        }

        // Check to see if ParentReference property is set
        internal bool IsSetParentReference()
        {
            return this._parentReference != null;
        }

    }
}