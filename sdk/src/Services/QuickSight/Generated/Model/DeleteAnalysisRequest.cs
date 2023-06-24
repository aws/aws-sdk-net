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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteAnalysis operation.
    /// Deletes an analysis from Amazon QuickSight. You can optionally include a recovery
    /// window during which you can restore the analysis. If you don't specify a recovery
    /// window value, the operation defaults to 30 days. Amazon QuickSight attaches a <code>DeletionTime</code>
    /// stamp to the response that specifies the end of the recovery window. At the end of
    /// the recovery window, Amazon QuickSight deletes the analysis permanently.
    /// 
    ///  
    /// <para>
    /// At any time before recovery window ends, you can use the <code>RestoreAnalysis</code>
    /// API operation to remove the <code>DeletionTime</code> stamp and cancel the deletion
    /// of the analysis. The analysis remains visible in the API until it's deleted, so you
    /// can describe it but you can't make a template from it.
    /// </para>
    ///  
    /// <para>
    /// An analysis that's scheduled for deletion isn't accessible in the Amazon QuickSight
    /// console. To access it in the console, restore it. Deleting an analysis doesn't delete
    /// the dashboards that you publish from it.
    /// </para>
    /// </summary>
    public partial class DeleteAnalysisRequest : AmazonQuickSightRequest
    {
        private string _analysisId;
        private string _awsAccountId;
        private bool? _forceDeleteWithoutRecovery;
        private long? _recoveryWindowInDays;

        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The ID of the analysis that you're deleting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=512)]
        public string AnalysisId
        {
            get { return this._analysisId; }
            set { this._analysisId = value; }
        }

        // Check to see if AnalysisId property is set
        internal bool IsSetAnalysisId()
        {
            return this._analysisId != null;
        }

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account where you want to delete an analysis.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property ForceDeleteWithoutRecovery. 
        /// <para>
        /// This option defaults to the value <code>NoForceDeleteWithoutRecovery</code>. To immediately
        /// delete the analysis, add the <code>ForceDeleteWithoutRecovery</code> option. You can't
        /// restore an analysis after it's deleted. 
        /// </para>
        /// </summary>
        public bool ForceDeleteWithoutRecovery
        {
            get { return this._forceDeleteWithoutRecovery.GetValueOrDefault(); }
            set { this._forceDeleteWithoutRecovery = value; }
        }

        // Check to see if ForceDeleteWithoutRecovery property is set
        internal bool IsSetForceDeleteWithoutRecovery()
        {
            return this._forceDeleteWithoutRecovery.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryWindowInDays. 
        /// <para>
        /// A value that specifies the number of days that Amazon QuickSight waits before it deletes
        /// the analysis. You can't use this parameter with the <code>ForceDeleteWithoutRecovery</code>
        /// option in the same API call. The default value is 30.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=30)]
        public long RecoveryWindowInDays
        {
            get { return this._recoveryWindowInDays.GetValueOrDefault(); }
            set { this._recoveryWindowInDays = value; }
        }

        // Check to see if RecoveryWindowInDays property is set
        internal bool IsSetRecoveryWindowInDays()
        {
            return this._recoveryWindowInDays.HasValue; 
        }

    }
}