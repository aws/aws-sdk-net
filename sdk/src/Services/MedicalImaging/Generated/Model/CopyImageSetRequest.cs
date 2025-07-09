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
    /// Container for the parameters to the CopyImageSet operation.
    /// Copy an image set.
    /// </summary>
    public partial class CopyImageSetRequest : AmazonMedicalImagingRequest
    {
        private CopyImageSetInformation _copyImageSetInformation;
        private string _datastoreId;
        private bool? _force;
        private bool? _promoteToPrimary;
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
        /// Gets and sets the property Force. 
        /// <para>
        /// Providing this parameter will force completion of the <c>CopyImageSet</c> operation,
        /// even if there are inconsistent Patient, Study, and/or Series level metadata elements
        /// between the <c>sourceImageSet</c> and <c>destinationImageSet</c>.
        /// </para>
        /// </summary>
        public bool? Force
        {
            get { return this._force; }
            set { this._force = value; }
        }

        // Check to see if Force property is set
        internal bool IsSetForce()
        {
            return this._force.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PromoteToPrimary. 
        /// <para>
        /// Providing this parameter will configure the <c>CopyImageSet</c> operation to promote
        /// the given image set to the primary DICOM hierarchy. If successful, a new primary image
        /// set ID will be returned as the destination image set.
        /// </para>
        /// </summary>
        public bool? PromoteToPrimary
        {
            get { return this._promoteToPrimary; }
            set { this._promoteToPrimary = value; }
        }

        // Check to see if PromoteToPrimary property is set
        internal bool IsSetPromoteToPrimary()
        {
            return this._promoteToPrimary.HasValue; 
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