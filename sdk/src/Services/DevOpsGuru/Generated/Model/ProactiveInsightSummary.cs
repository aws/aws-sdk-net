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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Details about a proactive insight. This object is returned by <code>DescribeInsight.</code>
    /// </summary>
    public partial class ProactiveInsightSummary
    {
        private string _id;
        private InsightTimeRange _insightTimeRange;
        private string _name;
        private PredictionTimeRange _predictionTimeRange;
        private ResourceCollection _resourceCollection;
        private InsightSeverity _severity;
        private InsightStatus _status;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the proactive insight. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property InsightTimeRange.
        /// </summary>
        public InsightTimeRange InsightTimeRange
        {
            get { return this._insightTimeRange; }
            set { this._insightTimeRange = value; }
        }

        // Check to see if InsightTimeRange property is set
        internal bool IsSetInsightTimeRange()
        {
            return this._insightTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the proactive insight. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=530)]
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
        /// Gets and sets the property PredictionTimeRange.
        /// </summary>
        public PredictionTimeRange PredictionTimeRange
        {
            get { return this._predictionTimeRange; }
            set { this._predictionTimeRange = value; }
        }

        // Check to see if PredictionTimeRange property is set
        internal bool IsSetPredictionTimeRange()
        {
            return this._predictionTimeRange != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceCollection.
        /// </summary>
        public ResourceCollection ResourceCollection
        {
            get { return this._resourceCollection; }
            set { this._resourceCollection = value; }
        }

        // Check to see if ResourceCollection property is set
        internal bool IsSetResourceCollection()
        {
            return this._resourceCollection != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the proactive insight. 
        /// </para>
        /// </summary>
        public InsightSeverity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the proactive insight. 
        /// </para>
        /// </summary>
        public InsightStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}