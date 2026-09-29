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
    /// Copy the image set properties of the destination image set.
    /// </summary>
    public partial class CopyDestinationImageSetProperties
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the destination image set properties were created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ImageSetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) assigned to the destination image set.
        /// </para>
        /// </summary>
        public string ImageSetArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageSetArn property is set.
        /// </summary>
        internal bool IsSetImageSetArn() => this.ImageSetArn != null;

        /// <summary>
        /// Gets and sets the property ImageSetId. 
        /// <para>
        /// The image set identifier of the copied image set properties.
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
        /// The image set state of the destination image set properties.
        /// </para>
        /// </summary>
        public ImageSetState ImageSetState { get; set; }

        /// <summary>
        /// Checks to see if the ImageSetState property is set.
        /// </summary>
        internal bool IsSetImageSetState() => this.ImageSetState != null;

        /// <summary>
        /// Gets and sets the property ImageSetWorkflowStatus. 
        /// <para>
        /// The image set workflow status of the destination image set properties.
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
        /// The latest version identifier for the destination image set properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LatestVersionId { get; set; }

        /// <summary>
        /// Checks to see if the LatestVersionId property is set.
        /// </summary>
        internal bool IsSetLatestVersionId() => this.LatestVersionId != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the destination image set properties were last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
