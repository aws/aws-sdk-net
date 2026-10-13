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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeHub operation.
    /// </summary>
    public partial class DescribeHubResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the hub was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason if importing hub content failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property HubArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 255)]
        public string HubArn { get; set; }

        /// <summary>
        /// Checks to see if the HubArn property is set.
        /// </summary>
        internal bool IsSetHubArn() => this.HubArn != null;

        /// <summary>
        /// Gets and sets the property HubDescription. 
        /// <para>
        /// A description of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1023)]
        public string HubDescription { get; set; }

        /// <summary>
        /// Checks to see if the HubDescription property is set.
        /// </summary>
        internal bool IsSetHubDescription() => this.HubDescription != null;

        /// <summary>
        /// Gets and sets the property HubDisplayName. 
        /// <para>
        /// The display name of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string HubDisplayName { get; set; }

        /// <summary>
        /// Checks to see if the HubDisplayName property is set.
        /// </summary>
        internal bool IsSetHubDisplayName() => this.HubDisplayName != null;

        /// <summary>
        /// Gets and sets the property HubName. 
        /// <para>
        /// The name of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 63)]
        public string HubName { get; set; }

        /// <summary>
        /// Checks to see if the HubName property is set.
        /// </summary>
        internal bool IsSetHubName() => this.HubName != null;

        /// <summary>
        /// Gets and sets the property HubSearchKeywords. 
        /// <para>
        /// The searchable keywords for the hub.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<string> HubSearchKeywords { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HubSearchKeywords property is set.
        /// </summary>
        internal bool IsSetHubSearchKeywords() => this.HubSearchKeywords != null && (this.HubSearchKeywords.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HubStatus. 
        /// <para>
        /// The status of the hub.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public HubStatus HubStatus { get; set; }

        /// <summary>
        /// Checks to see if the HubStatus property is set.
        /// </summary>
        internal bool IsSetHubStatus() => this.HubStatus != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the hub was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property S3StorageConfig. 
        /// <para>
        /// The Amazon S3 storage configuration for the hub.
        /// </para>
        /// </summary>
        public HubS3StorageConfig S3StorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the S3StorageConfig property is set.
        /// </summary>
        internal bool IsSetS3StorageConfig() => this.S3StorageConfig != null;
    }
}
