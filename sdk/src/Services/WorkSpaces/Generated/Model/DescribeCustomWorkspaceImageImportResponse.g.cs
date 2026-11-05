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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// This is the response object from the DescribeCustomWorkspaceImageImport operation.
    /// </summary>
    public partial class DescribeCustomWorkspaceImageImportResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The timestamp when the WorkSpace image import was created.
        /// </para>
        /// </summary>
        public DateTime? Created { get; set; }

        /// <summary>
        /// Checks to see if the Created property is set.
        /// </summary>
        internal bool IsSetCreated() => this.Created.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Describes in-depth details about the error. These details include the possible causes
        /// of the error and troubleshooting information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomWorkspaceImageImportErrorDetails> ErrorDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomWorkspaceImageImportErrorDetails>() : null;

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null && (this.ErrorDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageBuilderInstanceId. 
        /// <para>
        /// The image builder instance ID of the WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public string ImageBuilderInstanceId { get; set; }

        /// <summary>
        /// Checks to see if the ImageBuilderInstanceId property is set.
        /// </summary>
        internal bool IsSetImageBuilderInstanceId() => this.ImageBuilderInstanceId != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier of the WorkSpace image.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property ImageSource. 
        /// <para>
        /// Describes the image import source.
        /// </para>
        /// </summary>
        public ImageSourceIdentifier ImageSource { get; set; }

        /// <summary>
        /// Checks to see if the ImageSource property is set.
        /// </summary>
        internal bool IsSetImageSource() => this.ImageSource != null;

        /// <summary>
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The infrastructure configuration ARN that specifies how the WorkSpace image is built.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string InfrastructureConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the InfrastructureConfigurationArn property is set.
        /// </summary>
        internal bool IsSetInfrastructureConfigurationArn() => this.InfrastructureConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the WorkSpace image import was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressPercentage. 
        /// <para>
        /// The estimated progress percentage of the WorkSpace image import workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? ProgressPercentage { get; set; }

        /// <summary>
        /// Checks to see if the ProgressPercentage property is set.
        /// </summary>
        internal bool IsSetProgressPercentage() => this.ProgressPercentage.HasValue;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the WorkSpace image.
        /// </para>
        /// </summary>
        public CustomWorkspaceImageImportState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StateMessage. 
        /// <para>
        /// The state message of the WorkSpace image import workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public string StateMessage { get; set; }

        /// <summary>
        /// Checks to see if the StateMessage property is set.
        /// </summary>
        internal bool IsSetStateMessage() => this.StateMessage != null;
    }
}
