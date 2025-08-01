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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Configuration for Amazon Web Services Lambda functions that perform custom actions
    /// during a Region switch.
    /// </summary>
    public partial class CustomActionLambdaConfiguration
    {
        private List<Lambdas> _lambdas = AWSConfigs.InitializeCollections ? new List<Lambdas>() : null;
        private RegionToRunIn _regionToRun;
        private float? _retryIntervalMinutes;
        private int? _timeoutMinutes;
        private LambdaUngraceful _ungraceful;

        /// <summary>
        /// Gets and sets the property Lambdas. 
        /// <para>
        /// The Amazon Web Services Lambda functions for the execution block.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<Lambdas> Lambdas
        {
            get { return this._lambdas; }
            set { this._lambdas = value; }
        }

        // Check to see if Lambdas property is set
        internal bool IsSetLambdas()
        {
            return this._lambdas != null && (this._lambdas.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegionToRun. 
        /// <para>
        /// The Amazon Web Services Region for the function to run in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegionToRunIn RegionToRun
        {
            get { return this._regionToRun; }
            set { this._regionToRun = value; }
        }

        // Check to see if RegionToRun property is set
        internal bool IsSetRegionToRun()
        {
            return this._regionToRun != null;
        }

        /// <summary>
        /// Gets and sets the property RetryIntervalMinutes. 
        /// <para>
        /// The retry interval specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public float? RetryIntervalMinutes
        {
            get { return this._retryIntervalMinutes; }
            set { this._retryIntervalMinutes = value; }
        }

        // Check to see if RetryIntervalMinutes property is set
        internal bool IsSetRetryIntervalMinutes()
        {
            return this._retryIntervalMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TimeoutMinutes
        {
            get { return this._timeoutMinutes; }
            set { this._timeoutMinutes = value; }
        }

        // Check to see if TimeoutMinutes property is set
        internal bool IsSetTimeoutMinutes()
        {
            return this._timeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ungraceful. 
        /// <para>
        /// The settings for ungraceful execution.
        /// </para>
        /// </summary>
        public LambdaUngraceful Ungraceful
        {
            get { return this._ungraceful; }
            set { this._ungraceful = value; }
        }

        // Check to see if Ungraceful property is set
        internal bool IsSetUngraceful()
        {
            return this._ungraceful != null;
        }

    }
}