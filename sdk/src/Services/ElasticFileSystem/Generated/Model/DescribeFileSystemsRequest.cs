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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFileSystems operation.
    /// Returns the description of a specific Amazon EFS file system if either the file system
    /// <code>CreationToken</code> or the <code>FileSystemId</code> is provided; otherwise,
    /// returns descriptions of all file systems owned by the caller's AWS account in the
    /// AWS region of the endpoint that you're calling.
    /// 
    ///  
    /// <para>
    ///  When retrieving all file system descriptions, you can optionally specify the <code>MaxItems</code>
    /// parameter to limit the number of descriptions in a response. If more file system descriptions
    /// remain, Amazon EFS returns a <code>NextMarker</code>, an opaque token, in the response.
    /// In this case, you should send a subsequent request with the <code>Marker</code> request
    /// parameter set to the value of <code>NextMarker</code>. 
    /// </para>
    ///  
    /// <para>
    ///  So to retrieve a list of your file system descriptions, the expected usage of this
    /// API is an iterative process of first calling <code>DescribeFileSystems</code> without
    /// the <code>Marker</code> and then continuing to call it with the <code>Marker</code>
    /// parameter set to the value of the <code>NextMarker</code> from the previous response
    /// until the response has no <code>NextMarker</code>. 
    /// </para>
    ///  
    /// <para>
    ///  Note that the implementation may return fewer than <code>MaxItems</code> file system
    /// descriptions while still including a <code>NextMarker</code> value. 
    /// </para>
    ///  
    /// <para>
    ///  The order of file systems returned in the response of one <code>DescribeFileSystems</code>
    /// call, and the order of file systems returned across the responses of a multi-call
    /// iteration, is unspecified. 
    /// </para>
    ///  
    /// <para>
    ///  This operation requires permission for the <code>elasticfilesystem:DescribeFileSystems</code>
    /// action. 
    /// </para>
    /// </summary>
    public partial class DescribeFileSystemsRequest : AmazonElasticFileSystemRequest
    {
        private string _creationToken;
        private string _fileSystemId;
        private string _marker;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property CreationToken. 
        /// <para>
        ///  Optional string. Restricts the list to the file system with this creation token (you
        /// specify a creation token at the time of creating an Amazon EFS file system). 
        /// </para>
        /// </summary>
        public string CreationToken
        {
            get { return this._creationToken; }
            set { this._creationToken = value; }
        }

        // Check to see if CreationToken property is set
        internal bool IsSetCreationToken()
        {
            return this._creationToken != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// Optional string. File system ID whose description you want to retrieve. 
        /// </para>
        /// </summary>
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        ///  Optional string. Opaque pagination token returned from a previous <code>DescribeFileSystems</code>
        /// operation. If present, specifies to continue the list from where the returning call
        /// had left off. 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Optional integer. Specifies the maximum number of file systems to return in the response.
        /// This parameter value must be greater than 0. The number of items Amazon EFS returns
        /// will be the minimum of the <code>MaxItems</code> parameter specified in the request
        /// and the service's internal maximum number of items per page. 
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}