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
    /// Container for the parameters to the DeleteDataRepositoryAssociation operation. Deletes
    /// a data repository association on an Amazon FSx for Lustre file system. Deleting the
    /// data repository association unlinks the file system from the Amazon S3 bucket. When
    /// deleting a data repository association, you have the option of deleting the data in
    /// the file system that corresponds to the data repository association. Data repository
    /// associations are supported on all FSx for Lustre 2.12 and 2.15 file systems, excluding
    /// <c>scratch_1</c> deployment type.
    /// </summary>
    public partial class DeleteDataRepositoryAssociationRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The ID of the data repository association that you want to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 13, Max = 23)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property DeleteDataInFileSystem. 
        /// <para>
        /// Set to <c>true</c> to delete the data in the file system that corresponds to the data
        /// repository association.
        /// </para>
        /// </summary>
        public bool? DeleteDataInFileSystem { get; set; }

        /// <summary>
        /// Checks to see if the DeleteDataInFileSystem property is set.
        /// </summary>
        internal bool IsSetDeleteDataInFileSystem() => this.DeleteDataInFileSystem.HasValue;
    }
}
