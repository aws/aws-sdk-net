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
    /// The object containing <c>removableAttributes</c> and <c>updatableAttributes</c>.
    /// </summary>
    public partial class DICOMUpdates
    {
        private MemoryStream _removableAttributes;
        private MemoryStream _updatableAttributes;

        /// <summary>
        /// Gets and sets the property RemovableAttributes. 
        /// <para>
        /// The DICOM tags to be removed from <c>ImageSetMetadata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=10000)]
        public MemoryStream RemovableAttributes
        {
            get { return this._removableAttributes; }
            set { this._removableAttributes = value; }
        }

        // Check to see if RemovableAttributes property is set
        internal bool IsSetRemovableAttributes()
        {
            return this._removableAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatableAttributes. 
        /// <para>
        /// The DICOM tags that need to be updated in <c>ImageSetMetadata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=10000)]
        public MemoryStream UpdatableAttributes
        {
            get { return this._updatableAttributes; }
            set { this._updatableAttributes = value; }
        }

        // Check to see if UpdatableAttributes property is set
        internal bool IsSetUpdatableAttributes()
        {
            return this._updatableAttributes != null;
        }

    }
}