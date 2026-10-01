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
    /// The object containing <c>removableAttributes</c> and <c>updatableAttributes</c>.
    /// </summary>
    public partial class DICOMUpdates
    {
        /// <summary>
        /// Gets and sets the property RemovableAttributes. 
        /// <para>
        /// The DICOM tags to be removed from <c>ImageSetMetadata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 30000)]
        public MemoryStream RemovableAttributes { get; set; }

        /// <summary>
        /// Checks to see if the RemovableAttributes property is set.
        /// </summary>
        internal bool IsSetRemovableAttributes() => this.RemovableAttributes != null;

        /// <summary>
        /// Gets and sets the property UpdatableAttributes. 
        /// <para>
        /// The DICOM tags that need to be updated in <c>ImageSetMetadata</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 30000)]
        public MemoryStream UpdatableAttributes { get; set; }

        /// <summary>
        /// Checks to see if the UpdatableAttributes property is set.
        /// </summary>
        internal bool IsSetUpdatableAttributes() => this.UpdatableAttributes != null;
    }
}
