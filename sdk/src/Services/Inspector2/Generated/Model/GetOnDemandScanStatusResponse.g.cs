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

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// This is the response object from the GetOnDemandScanStatus operation.
    /// </summary>
    public partial class GetOnDemandScanStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletedAt. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the on-demand scan completed. This field
        /// is absent if the scan has not completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedAt { get; set; }

        /// <summary>
        /// Checks to see if the CompletedAt property is set.
        /// </summary>
        internal bool IsSetCompletedAt() => this.CompletedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource that was scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1024)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the resource that was scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OnDemandResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property ScanId. 
        /// <para>
        /// The unique identifier of the on-demand scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ScanId { get; set; }

        /// <summary>
        /// Checks to see if the ScanId property is set.
        /// </summary>
        internal bool IsSetScanId() => this.ScanId != null;

        /// <summary>
        /// Gets and sets the property ScanStatus. 
        /// <para>
        /// The current status of the on-demand scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OnDemandScanStatus ScanStatus { get; set; }

        /// <summary>
        /// Checks to see if the ScanStatus property is set.
        /// </summary>
        internal bool IsSetScanStatus() => this.ScanStatus != null;

        /// <summary>
        /// Gets and sets the property ScanStatusReason. 
        /// <para>
        /// The reason associated with the current on-demand scan status.
        /// </para>
        /// </summary>
        public OnDemandScanStatusReason ScanStatusReason { get; set; }

        /// <summary>
        /// Checks to see if the ScanStatusReason property is set.
        /// </summary>
        internal bool IsSetScanStatusReason() => this.ScanStatusReason != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The date and time, in ISO 8601 format, when the on-demand scan started.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;
    }
}
