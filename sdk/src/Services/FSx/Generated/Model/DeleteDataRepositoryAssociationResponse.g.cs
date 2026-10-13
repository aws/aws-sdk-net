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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// This is the response object from the DeleteDataRepositoryAssociation operation.
    /// </summary>
    public partial class DeleteDataRepositoryAssociationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the data repository association being deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 13, Max = 23)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property DeleteDataInFileSystem. 
        /// <para>
        /// Indicates whether data in the file system that corresponds to the data repository
        /// association is being deleted. Default is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DeleteDataInFileSystem { get; set; }

        /// <summary>
        /// Checks to see if the DeleteDataInFileSystem property is set.
        /// </summary>
        internal bool IsSetDeleteDataInFileSystem() => this.DeleteDataInFileSystem.HasValue;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Describes the lifecycle state of the data repository association being deleted.
        /// </para>
        /// </summary>
        public DataRepositoryLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;
    }
}
