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

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// Defines the compliance of an Application Component against the resiliency policy.
    /// </summary>
    public partial class AppComponentCompliance
    {
        /// <summary>
        /// Gets and sets the property AppComponentName. 
        /// <para>
        /// Name of the Application Component.
        /// </para>
        /// </summary>
        public string AppComponentName { get; set; }

        /// <summary>
        /// Checks to see if the AppComponentName property is set.
        /// </summary>
        internal bool IsSetAppComponentName() => this.AppComponentName != null;

        /// <summary>
        /// Gets and sets the property Compliance. 
        /// <para>
        /// The compliance of the Application Component against the resiliency policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, DisruptionCompliance> Compliance { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, DisruptionCompliance>() : null;

        /// <summary>
        /// Checks to see if the Compliance property is set.
        /// </summary>
        internal bool IsSetCompliance() => this.Compliance != null && (this.Compliance.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cost. 
        /// <para>
        /// The cost for the application.
        /// </para>
        /// </summary>
        public Cost Cost { get; set; }

        /// <summary>
        /// Checks to see if the Cost property is set.
        /// </summary>
        internal bool IsSetCost() => this.Cost != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The compliance message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 500)]
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property ResiliencyScore. 
        /// <para>
        /// The current resiliency score for the application.
        /// </para>
        /// </summary>
        public ResiliencyScore ResiliencyScore { get; set; }

        /// <summary>
        /// Checks to see if the ResiliencyScore property is set.
        /// </summary>
        internal bool IsSetResiliencyScore() => this.ResiliencyScore != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the action.
        /// </para>
        /// </summary>
        public ComplianceStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
