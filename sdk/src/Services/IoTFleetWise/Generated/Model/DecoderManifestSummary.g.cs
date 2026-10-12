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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Information about a created decoder manifest. You can use the API operation to return
    /// this information about multiple decoder manifests.
    /// </summary>
    public partial class DecoderManifestSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of a vehicle model (model manifest) associated with the decoder manifest.
        /// 
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the decoder manifest was created in seconds since epoch (January 1, 1970
        /// at midnight UTC time).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the decoder manifest.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The time the decoder manifest was last updated in seconds since epoch (January 1,
        /// 1970 at midnight UTC time).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The detailed message for the decoder manifest. When a decoder manifest is in an <c>INVALID</c>
        /// status, the message contains detailed reason and help information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ModelManifestArn. 
        /// <para>
        /// The ARN of a vehicle model (model manifest) associated with the decoder manifest.
        /// </para>
        /// </summary>
        public string ModelManifestArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelManifestArn property is set.
        /// </summary>
        internal bool IsSetModelManifestArn() => this.ModelManifestArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the decoder manifest.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The state of the decoder manifest. If the status is <c>ACTIVE</c>, the decoder manifest
        /// can't be edited. If the status is marked <c>DRAFT</c>, you can edit the decoder manifest.
        /// </para>
        /// </summary>
        public ManifestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
