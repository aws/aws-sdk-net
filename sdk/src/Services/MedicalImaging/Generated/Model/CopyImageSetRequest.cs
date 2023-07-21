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

namespace Amazon.MedicalImaging.Model
{
    /// <summary>
    /// Container for the parameters to the CopyImageSet operation.
    /// Copy an image set.
    /// </summary>
    public partial class CopyImageSetRequest : AmazonMedicalImagingRequest
    {
        private CopyImageSetInformation _copyImageSetInformation;
        private string _datastoreId;
        private string _sourceImageSetId;

        /// <summary>
        /// Gets and sets the property CopyImageSetInformation. 
        /// <para>
        /// Copy image set information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CopyImageSetInformation CopyImageSetInformation
        {
            get { return this._copyImageSetInformation; }
            set { this._copyImageSetInformation = value; }
        }

        // Check to see if CopyImageSetInformation property is set
        internal bool IsSetCopyImageSetInformation()
        {
            return this._copyImageSetInformation != null;
        }

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
        /// Gets and sets the property SourceImageSetId. 
        /// <para>
        /// The source image set identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SourceImageSetId
        {
            get { return this._sourceImageSetId; }
            set { this._sourceImageSetId = value; }
        }

        // Check to see if SourceImageSetId property is set
        internal bool IsSetSourceImageSetId()
        {
            return this._sourceImageSetId != null;
        }

    }
}