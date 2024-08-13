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
    /// Contains DICOMUpdates.
    /// </summary>
    public partial class MetadataUpdates
    {
        private DICOMUpdates _dicomUpdates;
        private string _revertToVersionId;

        /// <summary>
        /// Gets and sets the property DICOMUpdates. 
        /// <para>
        /// The object containing <c>removableAttributes</c> and <c>updatableAttributes</c>.
        /// </para>
        /// </summary>
        public DICOMUpdates DICOMUpdates
        {
            get { return this._dicomUpdates; }
            set { this._dicomUpdates = value; }
        }

        // Check to see if DICOMUpdates property is set
        internal bool IsSetDICOMUpdates()
        {
            return this._dicomUpdates != null;
        }

        /// <summary>
        /// Gets and sets the property RevertToVersionId. 
        /// <para>
        /// Specifies the previous image set version ID to revert the current image set back to.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must provide either <c>revertToVersionId</c> or <c>DICOMUpdates</c> in your request.
        /// A <c>ValidationException</c> error is thrown if both parameters are provided at the
        /// same time.
        /// </para>
        ///  </note>
        /// </summary>
        public string RevertToVersionId
        {
            get { return this._revertToVersionId; }
            set { this._revertToVersionId = value; }
        }

        // Check to see if RevertToVersionId property is set
        internal bool IsSetRevertToVersionId()
        {
            return this._revertToVersionId != null;
        }

    }
}