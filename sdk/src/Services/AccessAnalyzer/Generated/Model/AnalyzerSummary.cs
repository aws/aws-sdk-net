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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
        private string _arn;
        private AnalyzerConfiguration _configuration;
        private DateTime? _createdAt;
        private string _lastResourceAnalyzed;
        private DateTime? _lastResourceAnalyzedAt;
        private string _name;
        private AnalyzerStatus _status;
        private StatusReason _statusReason;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Type _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies if the analyzer is an external access, unused access, or internal access
        /// analyzer.
        /// </para>
        /// </summary>
        public AnalyzerConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp for the time at which the analyzer was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastResourceAnalyzed. 
        /// <para>
        /// The resource that was most recently analyzed by the analyzer.
        /// </para>
        /// </summary>
        public string LastResourceAnalyzed
        {
            get { return this._lastResourceAnalyzed; }
            set { this._lastResourceAnalyzed = value; }
        }

        // Check to see if LastResourceAnalyzed property is set
        internal bool IsSetLastResourceAnalyzed()
        {
            return this._lastResourceAnalyzed != null;
        }

        /// <summary>
        /// Gets and sets the property LastResourceAnalyzedAt. 
        /// <para>
        /// The time at which the most recently analyzed resource was analyzed.
        /// </para>
        /// </summary>
        public DateTime? LastResourceAnalyzedAt
        {
            get { return this._lastResourceAnalyzedAt; }
            set { this._lastResourceAnalyzedAt = value; }
        }

        // Check to see if LastResourceAnalyzedAt property is set
        internal bool IsSetLastResourceAnalyzedAt()
        {
            return this._lastResourceAnalyzedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

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
        [AWSProperty(Required=true)]
        public AnalyzerStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

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
        public StatusReason StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags added to the analyzer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of analyzer, which corresponds to the zone of trust chosen for the analyzer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}