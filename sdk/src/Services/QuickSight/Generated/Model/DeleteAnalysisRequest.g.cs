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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAnalysis operation. Deletes an analysis
    /// from Amazon Quick Sight. You can optionally include a recovery window during which
    /// you can restore the analysis. If you don't specify a recovery window value, the operation
    /// defaults to 30 days. Amazon Quick Sight attaches a <c>DeletionTime</c> stamp to the
    /// response that specifies the end of the recovery window. At the end of the recovery
    /// window, Amazon Quick Sight deletes the analysis permanently. <para> At any time before
    /// recovery window ends, you can use the <c>RestoreAnalysis</c> API operation to remove
    /// the <c>DeletionTime</c> stamp and cancel the deletion of the analysis. The analysis
    /// remains visible in the API until it's deleted, so you can describe it but you can't
    /// make a template from it. </para> <para> An analysis that's scheduled for deletion
    /// isn't accessible in the Amazon Quick Sight console. To access it in the console, restore
    /// it. Deleting an analysis doesn't delete the dashboards that you publish from it. </para>
    /// </summary>
    public partial class DeleteAnalysisRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The ID of the analysis that you're deleting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string AnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisId property is set.
        /// </summary>
        internal bool IsSetAnalysisId() => this.AnalysisId != null;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you want to delete an analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property ForceDeleteWithoutRecovery. 
        /// <para>
        /// This option defaults to the value <c>NoForceDeleteWithoutRecovery</c>. To immediately
        /// delete the analysis, add the <c>ForceDeleteWithoutRecovery</c> option. You can't restore
        /// an analysis after it's deleted. 
        /// </para>
        /// </summary>
        public bool? ForceDeleteWithoutRecovery { get; set; }

        /// <summary>
        /// Checks to see if the ForceDeleteWithoutRecovery property is set.
        /// </summary>
        internal bool IsSetForceDeleteWithoutRecovery() => this.ForceDeleteWithoutRecovery.HasValue;

        /// <summary>
        /// Gets and sets the property RecoveryWindowInDays. 
        /// <para>
        /// A value that specifies the number of days that Amazon Quick Sight waits before it
        /// deletes the analysis. You can't use this parameter with the <c>ForceDeleteWithoutRecovery</c>
        /// option in the same API call. The default value is 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 7, Max = 30)]
        public long? RecoveryWindowInDays { get; set; }

        /// <summary>
        /// Checks to see if the RecoveryWindowInDays property is set.
        /// </summary>
        internal bool IsSetRecoveryWindowInDays() => this.RecoveryWindowInDays.HasValue;
    }
}
