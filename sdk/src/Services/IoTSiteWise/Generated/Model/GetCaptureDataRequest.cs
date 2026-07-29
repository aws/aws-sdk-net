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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the GetCaptureData operation.
    /// Retrieves video data for a specific time range.
    /// </summary>
    public partial class GetCaptureDataRequest : AmazonIoTSiteWiseRequest
    {
        private TimeInNanos _endTime;
        private FormatSettings _formatSettings;
        private string _nextToken;
        private string _propertyAlias;
        private TimeInNanos _startTime;
        private string _timeSeriesId;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time for the video data range. Must be greater than startTime.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime != null;
        }

        /// <summary>
        /// Gets and sets the property FormatSettings. 
        /// <para>
        /// The optional format settings for the output.
        /// </para>
        /// </summary>
        public FormatSettings FormatSettings
        {
            get { return this._formatSettings; }
            set { this._formatSettings = value; }
        }

        // Check to see if FormatSettings property is set
        internal bool IsSetFormatSettings()
        {
            return this._formatSettings != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token from a previous response used to continue retrieving data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyAlias. 
        /// <para>
        /// The property alias that identifies the capture source. Mutually exclusive with timeSeriesId.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string PropertyAlias
        {
            get { return this._propertyAlias; }
            set { this._propertyAlias = value; }
        }

        // Check to see if PropertyAlias property is set
        internal bool IsSetPropertyAlias()
        {
            return this._propertyAlias != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time for the video data range.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TimeInNanos StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property TimeSeriesId. 
        /// <para>
        /// The time series ID that identifies the capture source. Mutually exclusive with propertyAlias.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=73)]
        public string TimeSeriesId
        {
            get { return this._timeSeriesId; }
            set { this._timeSeriesId = value; }
        }

        // Check to see if TimeSeriesId property is set
        internal bool IsSetTimeSeriesId()
        {
            return this._timeSeriesId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace that contains the capture source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}