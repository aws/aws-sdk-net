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
    /// This is the response object from the GetModelManifest operation.
    /// </summary>
    public partial class GetModelManifestResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the vehicle model. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the vehicle model was created, in seconds since epoch (January 1, 1970 at
        /// midnight UTC time).
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
        ///  A brief description of the vehicle model. 
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
        /// The last time the vehicle model was modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the vehicle model. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SignalCatalogArn. 
        /// <para>
        ///  The ARN of the signal catalog associated with the vehicle model. 
        /// </para>
        /// </summary>
        public string SignalCatalogArn { get; set; }

        /// <summary>
        /// Checks to see if the SignalCatalogArn property is set.
        /// </summary>
        internal bool IsSetSignalCatalogArn() => this.SignalCatalogArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///  The state of the vehicle model. If the status is <c>ACTIVE</c>, the vehicle model
        /// can't be edited. You can edit the vehicle model if the status is marked <c>DRAFT</c>.
        /// </para>
        /// </summary>
        public ManifestStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
