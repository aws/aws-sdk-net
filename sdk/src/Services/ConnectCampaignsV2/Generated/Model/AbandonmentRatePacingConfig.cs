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
 * Do not modify this file. This file is generated from the connectcampaignsv2-2024-04-23.normal.json service model.
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
namespace Amazon.ConnectCampaignsV2.Model
{
    /// <summary>
    /// Configuration for abandonment-rate-based dialer throttling.
    /// </summary>
    public partial class AbandonmentRatePacingConfig
    {
        private ConnectionStartPoint _connectionStartPoint;
        private int? _connectionThresholdSeconds;
        private string _evaluationWindow;
        private double? _targetRate;

        /// <summary>
        /// Gets and sets the property ConnectionStartPoint. 
        /// <para>
        /// Event from which connectionThresholdSeconds is measured.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ConnectionStartPoint ConnectionStartPoint
        {
            get { return this._connectionStartPoint; }
            set { this._connectionStartPoint = value; }
        }

        // Check to see if ConnectionStartPoint property is set
        internal bool IsSetConnectionStartPoint()
        {
            return this._connectionStartPoint != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionThresholdSeconds. 
        /// <para>
        /// Seconds after connectionStartPoint before a contact counts as abandoned.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public int? ConnectionThresholdSeconds
        {
            get { return this._connectionThresholdSeconds; }
            set { this._connectionThresholdSeconds = value; }
        }

        // Check to see if ConnectionThresholdSeconds property is set
        internal bool IsSetConnectionThresholdSeconds()
        {
            return this._connectionThresholdSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationWindow. 
        /// <para>
        /// Rolling window over which abandonmentRate is computed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5)]
        public string EvaluationWindow
        {
            get { return this._evaluationWindow; }
            set { this._evaluationWindow = value; }
        }

        // Check to see if EvaluationWindow property is set
        internal bool IsSetEvaluationWindow()
        {
            return this._evaluationWindow != null;
        }

        /// <summary>
        /// Gets and sets the property TargetRate.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1)]
        public double? TargetRate
        {
            get { return this._targetRate; }
            set { this._targetRate = value; }
        }

        // Check to see if TargetRate property is set
        internal bool IsSetTargetRate()
        {
            return this._targetRate.HasValue; 
        }

    }
}