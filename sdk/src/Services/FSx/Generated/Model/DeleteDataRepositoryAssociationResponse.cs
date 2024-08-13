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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
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
namespace Amazon.FSx.Model
{
    /// <summary>
    /// This is the response object from the DeleteDataRepositoryAssociation operation.
    /// </summary>
    public partial class DeleteDataRepositoryAssociationResponse : AmazonWebServiceResponse
    {
        private string _associationId;
        private bool? _deleteDataInFileSystem;
        private DataRepositoryLifecycle _lifecycle;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the data repository association being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=13, Max=23)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteDataInFileSystem. 
        /// <para>
        /// Indicates whether data in the file system that corresponds to the data repository
        /// association is being deleted. Default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DeleteDataInFileSystem
        {
            get { return this._deleteDataInFileSystem; }
            set { this._deleteDataInFileSystem = value; }
        }

        // Check to see if DeleteDataInFileSystem property is set
        internal bool IsSetDeleteDataInFileSystem()
        {
            return this._deleteDataInFileSystem.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Describes the lifecycle state of the data repository association being deleted.
        /// </para>
        /// </summary>
        public DataRepositoryLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

    }
}