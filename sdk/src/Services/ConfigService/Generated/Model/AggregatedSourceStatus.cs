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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The current sync status between the source and the aggregator account.
    /// </summary>
    public partial class AggregatedSourceStatus
    {
        private string _awsRegion;
        private string _lastErrorCode;
        private string _lastErrorMessage;
        private AggregatedSourceStatusType _lastUpdateStatus;
        private DateTime? _lastUpdateTime;
        private string _sourceId;
        private AggregatedSourceType _sourceType;

        /// <summary>
        /// Gets and sets the property AwsRegion. 
        /// <para>
        /// The region authorized to collect aggregated data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string AwsRegion
        {
            get { return this._awsRegion; }
            set { this._awsRegion = value; }
        }

        // Check to see if AwsRegion property is set
        internal bool IsSetAwsRegion()
        {
            return this._awsRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastErrorCode. 
        /// <para>
        /// The error code that Config returned when the source account aggregation last failed.
        /// </para>
        /// </summary>
        public string LastErrorCode
        {
            get { return this._lastErrorCode; }
            set { this._lastErrorCode = value; }
        }

        // Check to see if LastErrorCode property is set
        internal bool IsSetLastErrorCode()
        {
            return this._lastErrorCode != null;
        }

        /// <summary>
        /// Gets and sets the property LastErrorMessage. 
        /// <para>
        /// The message indicating that the source account aggregation failed due to an error.
        /// </para>
        /// </summary>
        public string LastErrorMessage
        {
            get { return this._lastErrorMessage; }
            set { this._lastErrorMessage = value; }
        }

        // Check to see if LastErrorMessage property is set
        internal bool IsSetLastErrorMessage()
        {
            return this._lastErrorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// Filters the last updated status type.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Valid value FAILED indicates errors while moving data.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid value SUCCEEDED indicates the data was successfully moved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Valid value OUTDATED indicates the data is not the most recent.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AggregatedSourceStatusType LastUpdateStatus
        {
            get { return this._lastUpdateStatus; }
            set { this._lastUpdateStatus = value; }
        }

        // Check to see if LastUpdateStatus property is set
        internal bool IsSetLastUpdateStatus()
        {
            return this._lastUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time of the last update.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime
        {
            get { return this._lastUpdateTime; }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The source account ID or an organization.
        /// </para>
        /// </summary>
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source account or an organization.
        /// </para>
        /// </summary>
        public AggregatedSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

    }
}