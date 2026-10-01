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
    /// Copy image set information.
    /// </summary>
    public partial class CopyImageSetInformation
    {
        /// <summary>
        /// Gets and sets the property DestinationImageSet. 
        /// <para>
        /// The destination image set.
        /// </para>
        /// </summary>
        public CopyDestinationImageSet DestinationImageSet { get; set; }

        /// <summary>
        /// Checks to see if the DestinationImageSet property is set.
        /// </summary>
        internal bool IsSetDestinationImageSet() => this.DestinationImageSet != null;

        /// <summary>
        /// Gets and sets the property SourceImageSet. 
        /// <para>
        /// The source image set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CopySourceImageSetInformation SourceImageSet { get; set; }

        /// <summary>
        /// Checks to see if the SourceImageSet property is set.
        /// </summary>
        internal bool IsSetSourceImageSet() => this.SourceImageSet != null;
    }
}
