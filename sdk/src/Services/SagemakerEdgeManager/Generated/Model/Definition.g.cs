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

namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// </summary>
    public partial class Definition
    {
        /// <summary>
        /// Gets and sets the property Checksum. 
        /// <para>
        /// The checksum information of the model.
        /// </para>
        /// </summary>
        public Checksum Checksum { get; set; }

        /// <summary>
        /// Checks to see if the Checksum property is set.
        /// </summary>
        internal bool IsSetChecksum() => this.Checksum != null;

        /// <summary>
        /// Gets and sets the property ModelHandle. 
        /// <para>
        /// The unique model handle.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ModelHandle { get; set; }

        /// <summary>
        /// Checks to see if the ModelHandle property is set.
        /// </summary>
        internal bool IsSetModelHandle() => this.ModelHandle != null;

        /// <summary>
        /// Gets and sets the property S3Url. 
        /// <para>
        /// The absolute S3 location of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3Url { get; set; }

        /// <summary>
        /// Checks to see if the S3Url property is set.
        /// </summary>
        internal bool IsSetS3Url() => this.S3Url != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The desired state of the model.
        /// </para>
        /// </summary>
        public ModelState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
