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
 * Do not modify this file. This file is generated from the medical-imaging-2023-07-19.normal.json service model.
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
    /// This is the response object from the DeleteImageSet operation.
    /// </summary>
    public partial class DeleteImageSetResponse : AmazonWebServiceResponse
    {
        private string _datastoreId;
        private string _imageSetId;
        private ImageSetState _imageSetState;
        private ImageSetWorkflowStatus _imageSetWorkflowStatus;

        /// <summary>
        /// Gets and sets the property DatastoreId. 
        /// <para>
        /// The data store identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatastoreId
        {
            get { return this._datastoreId; }
            set { this._datastoreId = value; }
        }

        // Check to see if DatastoreId property is set
        internal bool IsSetDatastoreId()
        {
            return this._datastoreId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSetId. 
        /// <para>
        /// The image set identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageSetId
        {
            get { return this._imageSetId; }
            set { this._imageSetId = value; }
        }

        // Check to see if ImageSetId property is set
        internal bool IsSetImageSetId()
        {
            return this._imageSetId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSetState. 
        /// <para>
        /// The image set state.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageSetState ImageSetState
        {
            get { return this._imageSetState; }
            set { this._imageSetState = value; }
        }

        // Check to see if ImageSetState property is set
        internal bool IsSetImageSetState()
        {
            return this._imageSetState != null;
        }

        /// <summary>
        /// Gets and sets the property ImageSetWorkflowStatus. 
        /// <para>
        /// The image set workflow status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImageSetWorkflowStatus ImageSetWorkflowStatus
        {
            get { return this._imageSetWorkflowStatus; }
            set { this._imageSetWorkflowStatus = value; }
        }

        // Check to see if ImageSetWorkflowStatus property is set
        internal bool IsSetImageSetWorkflowStatus()
        {
            return this._imageSetWorkflowStatus != null;
        }

    }
}