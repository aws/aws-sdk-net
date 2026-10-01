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

namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// This is the response object from the UpdateImageSetMetadata operation.
    /// </summary>
    public partial class UpdateImageSetMetadataResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when image set metadata was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DatastoreId { get; set; }

        /// <summary>
        /// Checks to see if the DatastoreId property is set.
        /// </summary>
        internal bool IsSetDatastoreId() => this.DatastoreId != null;

        /// <summary>
        /// Gets and sets the property ImageSetId. 
        /// <para>
        /// The image set identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImageSetId { get; set; }

        /// <summary>
        /// Checks to see if the ImageSetId property is set.
        /// </summary>
        internal bool IsSetImageSetId() => this.ImageSetId != null;

        /// <summary>
        /// Gets and sets the property ImageSetState. 
        /// <para>
        /// The image set state.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ImageSetState ImageSetState { get; set; }

        /// <summary>
        /// Checks to see if the ImageSetState property is set.
        /// </summary>
        internal bool IsSetImageSetState() => this.ImageSetState != null;

        /// <summary>
        /// Gets and sets the property ImageSetWorkflowStatus. 
        /// <para>
        /// The image set workflow status.
        /// </para>
        /// </summary>
        public ImageSetWorkflowStatus ImageSetWorkflowStatus { get; set; }

        /// <summary>
        /// Checks to see if the ImageSetWorkflowStatus property is set.
        /// </summary>
        internal bool IsSetImageSetWorkflowStatus() => this.ImageSetWorkflowStatus != null;

        /// <summary>
        /// Gets and sets the property LatestVersionId. 
        /// <para>
        /// The latest image set version identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LatestVersionId { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionId property is set.
        /// </summary>
        internal bool IsSetLatestVersionId() => this.LatestVersionId != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The error message thrown if an update image set metadata action fails.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when image set metadata was updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
