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
 * Do not modify this file. This file is generated from the observabilityadmin-2018-05-10.normal.json service model.
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
namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the StartTelemetryEvaluation operation.
    /// This action begins onboarding the caller Amazon Web Services account to the telemetry
    /// config feature.
    /// </summary>
    public partial class StartTelemetryEvaluationRequest : AmazonObservabilityAdminRequest
    {
        private bool? _allRegions;
        private List<string> _regions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllRegions. 
        /// <para>
        ///  If set to <c>true</c>, telemetry evaluation starts in all Amazon Web Services Regions
        /// where Amazon CloudWatch Observability Admin is available in the current partition.
        /// The current region becomes the home region for managing multi-region evaluation. When
        /// new regions become available, evaluation automatically expands to include them. Mutually
        /// exclusive with <c>Regions</c>. 
        /// </para>
        /// </summary>
        public bool? AllRegions
        {
            get { return this._allRegions; }
            set { this._allRegions = value; }
        }

        // Check to see if AllRegions property is set
        internal bool IsSetAllRegions()
        {
            return this._allRegions.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        ///  An optional list of Amazon Web Services Regions to include in multi-region telemetry
        /// evaluation. The current region is always implicitly included and must not be specified
        /// in this list. When provided, telemetry evaluation starts in the current region and
        /// propagates to all specified regions. Mutually exclusive with <c>AllRegions</c>. If
        /// neither <c>Regions</c> nor <c>AllRegions</c> is provided, the operation applies only
        /// to the current region. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> Regions
        {
            get { return this._regions; }
            set { this._regions = value; }
        }

        // Check to see if Regions property is set
        internal bool IsSetRegions()
        {
            return this._regions != null && (this._regions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}