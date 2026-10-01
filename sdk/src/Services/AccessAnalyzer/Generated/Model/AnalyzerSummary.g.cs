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
    /// Contains information about the analyzer.
    /// </summary>
    public partial class AnalyzerSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies if the analyzer is an external access, unused access, or internal access
        /// analyzer. The <a href="https://docs.aws.amazon.com/access-analyzer/latest/APIReference/API_GetAnalyzer.html">GetAnalyzer</a>
        /// action includes this property in its response if a configuration is specified, while
        /// the <a href="https://docs.aws.amazon.com/access-analyzer/latest/APIReference/API_ListAnalyzers.html">ListAnalyzers</a>
        /// action omits it.
        /// </para>
        /// </summary>
        public AnalyzerConfiguration Configuration { get; set; }

        /// <summary>
        /// Checks to see if the Configuration property is set.
        /// </summary>
        internal bool IsSetConfiguration() => this.Configuration != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp for the time at which the analyzer was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LastResourceAnalyzed. 
        /// <para>
        /// The resource that was most recently analyzed by the analyzer.
        /// </para>
        /// </summary>
        public string LastResourceAnalyzed { get; set; }

        /// <summary>
        /// Checks to see if the LastResourceAnalyzed property is set.
        /// </summary>
        internal bool IsSetLastResourceAnalyzed() => this.LastResourceAnalyzed != null;

        /// <summary>
        /// Gets and sets the property LastResourceAnalyzedAt. 
        /// <para>
        /// The time at which the most recently analyzed resource was analyzed.
        /// </para>
        /// </summary>
        public DateTime? LastResourceAnalyzedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastResourceAnalyzedAt property is set.
        /// </summary>
        internal bool IsSetLastResourceAnalyzedAt() => this.LastResourceAnalyzedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The service principal that manages this analyzer (for example, <c>securityhubv2.amazonaws.com</c>).
        /// This field is only present for service-linked analyzers and is not included for customer-managed
        /// analyzers.
        /// </para>
        /// </summary>
        public string ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the analyzer. An <c>Active</c> analyzer successfully monitors supported
        /// resources and generates new findings. The analyzer is <c>Disabled</c> when a user
        /// action, such as removing trusted access for Identity and Access Management Access
        /// Analyzer from Organizations, causes the analyzer to stop generating new findings.
        /// The status is <c>Creating</c> when the analyzer creation is in progress and <c>Failed</c>
        /// when the analyzer creation has failed. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AnalyzerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The <c>statusReason</c> provides more details about the current status of the analyzer.
        /// For example, if the creation for the analyzer fails, a <c>Failed</c> status is returned.
        /// For an analyzer with organization as the type, this failure can be due to an issue
        /// with creating the service-linked roles required in the member accounts of the Amazon
        /// Web Services organization.
        /// </para>
        /// </summary>
        public StatusReason StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An array of key-value pairs applied to the analyzer. The key-value pairs consist of
        /// the set of Unicode letters, digits, whitespace, <c>_</c>, <c>.</c>, <c>/</c>, <c>=</c>,
        /// <c>+</c>, and <c>-</c>.
        /// </para>
        ///  
        /// <para>
        /// The tag key is a value that is 1 to 128 characters in length and cannot be prefixed
        /// with <c>aws:</c>.
        /// </para>
        ///  
        /// <para>
        /// The tag value is a value that is 0 to 256 characters in length.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type represents the zone of trust or scope for the analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Type Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
