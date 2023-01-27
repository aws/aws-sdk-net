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
 * Do not modify this file. This file is generated from the elasticfilesystem-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticFileSystem.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFileSystems operation.
    /// Returns the description of a specific Amazon EFS file system if either the file system
    /// <code>CreationToken</code> or the <code>FileSystemId</code> is provided. Otherwise,
    /// it returns descriptions of all file systems owned by the caller's Amazon Web Services
    /// account in the Amazon Web Services Region of the endpoint that you're calling.
    /// 
    ///  
    /// <para>
    /// When retrieving all file system descriptions, you can optionally specify the <code>MaxItems</code>
    /// parameter to limit the number of descriptions in a response. This number is automatically
    /// set to 100. If more file system descriptions remain, Amazon EFS returns a <code>NextMarker</code>,
    /// an opaque token, in the response. In this case, you should send a subsequent request
    /// with the <code>Marker</code> request parameter set to the value of <code>NextMarker</code>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// To retrieve a list of your file system descriptions, this operation is used in an
    /// iterative process, where <code>DescribeFileSystems</code> is called first without
    /// the <code>Marker</code> and then the operation continues to call it with the <code>Marker</code>
    /// parameter set to the value of the <code>NextMarker</code> from the previous response
    /// until the response has no <code>NextMarker</code>. 
    /// </para>
    ///  
    /// <para>
    ///  The order of file systems returned in the response of one <code>DescribeFileSystems</code>
    /// call and the order of file systems returned across the responses of a multi-call iteration
    /// is unspecified. 
    /// </para>
    ///  
    /// <para>
    ///  This operation requires permissions for the <code>elasticfilesystem:DescribeFileSystems</code>
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
        /// (Optional) Restricts the list to the file system with this creation token (String).
        /// You specify a creation token when you create an Amazon EFS file system.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// (Optional) ID of the file system whose description you want to retrieve (String).
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
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
        /// (Optional) Opaque pagination token returned from a previous <code>DescribeFileSystems</code>
        /// operation (String). If present, specifies to continue the list from where the returning
        /// call had left off. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// (Optional) Specifies the maximum number of file systems to return in the response
        /// (integer). This number is automatically set to 100. The response is paginated at 100
        /// per page if you have more than 100 file systems. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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