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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Contains information about an access preview.
    /// </summary>
    public partial class AccessPreview
    {
        /// <summary>
        /// Gets and sets the property AnalyzerArn. 
        /// <para>
        /// The ARN of the analyzer used to generate the access preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AnalyzerArn { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzerArn property is set.
        /// </summary>
        internal bool IsSetAnalyzerArn() => this.AnalyzerArn != null;

        /// <summary>
        /// Gets and sets the property Configurations. 
        /// <para>
        /// A map of resource ARNs for the proposed resource configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, Configuration> Configurations { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, Configuration>() : null;

        /// <summary>
        /// Checks to see if the Configurations property is set.
        /// </summary>
        internal bool IsSetConfigurations() => this.Configurations != null && (this.Configurations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the access preview was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique ID for the access preview.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the access preview.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - The access preview creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Completed</c> - The access preview is complete. You can preview findings for external
        /// access to the resource.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - The access preview creation has failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccessPreviewStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Provides more details about the current status of the access preview.
        /// </para>
        ///  
        /// <para>
        /// For example, if the creation of the access preview fails, a <c>Failed</c> status is
        /// returned. This failure can be due to an internal issue with the analysis or due to
        /// an invalid resource configuration.
        /// </para>
        /// </summary>
        public AccessPreviewStatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
