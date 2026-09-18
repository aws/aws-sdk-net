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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// Alert configuration parameters.
    /// </summary>
    public partial class Alert
    {
        /// <summary>
        /// Gets and sets the property AlertCode. 
        /// <para>
        /// The code for the alert. For example, <c>NOT_PROCESSED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AlertCode { get; set; }

        /// <summary>
        /// Checks to see if the AlertCode property is set.
        /// </summary>
        internal bool IsSetAlertCode() => this.AlertCode != null;

        /// <summary>
        /// Gets and sets the property AlertMessage. 
        /// <para>
        /// If an alert is generated for a resource, an explanation of the reason for the alert.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AlertMessage { get; set; }

        /// <summary>
        /// Checks to see if the AlertMessage property is set.
        /// </summary>
        internal bool IsSetAlertMessage() => this.AlertMessage != null;

        /// <summary>
        /// Gets and sets the property Category. 
        /// <para>
        /// The category that MediaTailor assigns to the alert.
        /// </para>
        /// </summary>
        public AlertCategory Category { get; set; }

        /// <summary>
        /// Checks to see if the Category property is set.
        /// </summary>
        internal bool IsSetCategory() => this.Category != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the alert was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RelatedResourceArns. 
        /// <para>
        /// The Amazon Resource Names (ARNs) related to this alert.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> RelatedResourceArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RelatedResourceArns property is set.
        /// </summary>
        internal bool IsSetRelatedResourceArns() => this.RelatedResourceArns != null && (this.RelatedResourceArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
