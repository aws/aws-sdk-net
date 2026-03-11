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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// Represents a subscription filter.
    /// </summary>
    public partial class SubscriptionFilter
    {
        private bool? _applyOnTransformedLogs;
        private long? _creationTime;
        private string _destinationArn;
        private Distribution _distribution;
        private List<string> _emitSystemFields = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _fieldSelectionCriteria;
        private string _filterName;
        private string _filterPattern;
        private string _logGroupName;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ApplyOnTransformedLogs. 
        /// <para>
        /// This parameter is valid only for log groups that have an active log transformer. For
        /// more information about log transformers, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutTransformer.html">PutTransformer</a>.
        /// </para>
        ///  
        /// <para>
        /// If this value is <c>true</c>, the subscription filter is applied on the transformed
        /// version of the log events instead of the original ingested log events.
        /// </para>
        /// </summary>
        public bool? ApplyOnTransformedLogs
        {
            get { return this._applyOnTransformedLogs; }
            set { this._applyOnTransformedLogs = value; }
        }

        // Check to see if ApplyOnTransformedLogs property is set
        internal bool IsSetApplyOnTransformedLogs()
        {
            return this._applyOnTransformedLogs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the subscription filter, expressed as the number of milliseconds
        /// after <c>Jan 1, 1970 00:00:00 UTC</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string DestinationArn
        {
            get { return this._destinationArn; }
            set { this._destinationArn = value; }
        }

        // Check to see if DestinationArn property is set
        internal bool IsSetDestinationArn()
        {
            return this._destinationArn != null;
        }

        /// <summary>
        /// Gets and sets the property Distribution.
        /// </summary>
        public Distribution Distribution
        {
            get { return this._distribution; }
            set { this._distribution = value; }
        }

        // Check to see if Distribution property is set
        internal bool IsSetDistribution()
        {
            return this._distribution != null;
        }

        /// <summary>
        /// Gets and sets the property EmitSystemFields. 
        /// <para>
        /// The list of system fields that are included in the log events sent to the subscription
        /// destination. Returns the <c>emitSystemFields</c> value if it was specified when the
        /// subscription filter was created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EmitSystemFields
        {
            get { return this._emitSystemFields; }
            set { this._emitSystemFields = value; }
        }

        // Check to see if EmitSystemFields property is set
        internal bool IsSetEmitSystemFields()
        {
            return this._emitSystemFields != null && (this._emitSystemFields.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FieldSelectionCriteria. 
        /// <para>
        /// The filter expression that specifies which log events are processed by this subscription
        /// filter based on system fields. Returns the <c>fieldSelectionCriteria</c> value if
        /// it was specified when the subscription filter was created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2000)]
        public string FieldSelectionCriteria
        {
            get { return this._fieldSelectionCriteria; }
            set { this._fieldSelectionCriteria = value; }
        }

        // Check to see if FieldSelectionCriteria property is set
        internal bool IsSetFieldSelectionCriteria()
        {
            return this._fieldSelectionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property FilterName. 
        /// <para>
        /// The name of the subscription filter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string FilterName
        {
            get { return this._filterName; }
            set { this._filterName = value; }
        }

        // Check to see if FilterName property is set
        internal bool IsSetFilterName()
        {
            return this._filterName != null;
        }

        /// <summary>
        /// Gets and sets the property FilterPattern.
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FilterPattern
        {
            get { return this._filterPattern; }
            set { this._filterPattern = value; }
        }

        // Check to see if FilterPattern property is set
        internal bool IsSetFilterPattern()
        {
            return this._filterPattern != null;
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn.
        /// </summary>
        [AWSProperty(Min=1)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}