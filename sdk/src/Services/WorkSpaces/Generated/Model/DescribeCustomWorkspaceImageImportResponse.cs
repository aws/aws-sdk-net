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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
        private DateTime? _created;
        private List<CustomWorkspaceImageImportErrorDetails> _errorDetails = AWSConfigs.InitializeCollections ? new List<CustomWorkspaceImageImportErrorDetails>() : null;
        private string _imageBuilderInstanceId;
        private string _imageId;
        private ImageSourceIdentifier _imageSource;
        private string _infrastructureConfigurationArn;
        private DateTime? _lastUpdatedTime;
        private CustomWorkspaceImageImportState _state;

        /// <summary>
        /// Gets and sets the property Created. 
        /// <para>
        /// The timestamp when the WorkSpace image import was created.
        /// </para>
        /// </summary>
        public DateTime? Created
        {
            get { return this._created; }
            set { this._created = value; }
        }

        // Check to see if Created property is set
        internal bool IsSetCreated()
        {
            return this._created.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Describes in-depth details about the error. These details include the possible causes
        /// of the error and troubleshooting information.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CustomWorkspaceImageImportErrorDetails> ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null && (this._errorDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ImageBuilderInstanceId. 
        /// <para>
        /// The image builder instance ID of the WorkSpace image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ImageBuilderInstanceId
        {
            get { return this._imageBuilderInstanceId; }
            set { this._imageBuilderInstanceId = value; }
        }

        // Check to see if ImageBuilderInstanceId property is set
        internal bool IsSetImageBuilderInstanceId()
        {
            return this._imageBuilderInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier of the WorkSpace image.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSource. 
        /// <para>
        /// Describes the image import source.
        /// </para>
        /// </summary>
        public ImageSourceIdentifier ImageSource
        {
            get { return this._imageSource; }
            set { this._imageSource = value; }
        }

        // Check to see if ImageSource property is set
        internal bool IsSetImageSource()
        {
            return this._imageSource != null;
        }

        /// <summary>
        /// Gets and sets the property InfrastructureConfigurationArn. 
        /// <para>
        /// The infrastructure configuration ARN that specifies how the WorkSpace image is built.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string InfrastructureConfigurationArn
        {
            get { return this._infrastructureConfigurationArn; }
            set { this._infrastructureConfigurationArn = value; }
        }

        // Check to see if InfrastructureConfigurationArn property is set
        internal bool IsSetInfrastructureConfigurationArn()
        {
            return this._infrastructureConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the WorkSpace image import was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the WorkSpace image.
        /// </para>
        /// </summary>
        public CustomWorkspaceImageImportState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}