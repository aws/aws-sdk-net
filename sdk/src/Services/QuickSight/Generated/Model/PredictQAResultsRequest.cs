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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the PredictQAResults operation.
    /// Predicts existing visuals or generates new visuals to answer a given query.
    /// 
    ///  
    /// <para>
    /// This API uses <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation.html">trusted
    /// identity propagation</a> to ensure that an end user is authenticated and receives
    /// the embed URL that is specific to that user. The IAM Identity Center application that
    /// the user has logged into needs to have <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-using-customermanagedapps-specify-trusted-apps.html">trusted
    /// Identity Propagation enabled for QuickSight</a> with the scope value set to <c>quicksight:read</c>.
    /// Before you use this action, make sure that you have configured the relevant QuickSight
    /// resource and permissions.
    /// </para>
    ///  
    /// <para>
    /// We recommend enabling the <c>QSearchStatus</c> API to unlock the full potential of
    /// <c>PredictQnA</c>. When <c>QSearchStatus</c> is enabled, it first checks the specified
    /// dashboard for any existing visuals that match the question. If no matching visuals
    /// are found, <c>PredictQnA</c> uses generative Q&amp;A to provide an answer. To update
    /// the <c>QSearchStatus</c>, see <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateQuickSightQSearchConfiguration.html">UpdateQuickSightQSearchConfiguration</a>.
    /// </para>
    /// </summary>
    public partial class PredictQAResultsRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private IncludeGeneratedAnswer _includeGeneratedAnswer;
        private IncludeQuickSightQIndex _includeQuickSightQIndex;
        private int? _maxTopicsToConsider;
        private string _queryText;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that the user wants to execute Predict QA
        /// results in.
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
        /// Gets and sets the property IncludeGeneratedAnswer. 
        /// <para>
        /// Indicates whether generated answers are included or excluded.
        /// </para>
        /// </summary>
        public IncludeGeneratedAnswer IncludeGeneratedAnswer
        {
            get { return this._includeGeneratedAnswer; }
            set { this._includeGeneratedAnswer = value; }
        }

        // Check to see if IncludeGeneratedAnswer property is set
        internal bool IsSetIncludeGeneratedAnswer()
        {
            return this._includeGeneratedAnswer != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeQuickSightQIndex. 
        /// <para>
        /// Indicates whether Q indicies are included or excluded.
        /// </para>
        /// </summary>
        public IncludeQuickSightQIndex IncludeQuickSightQIndex
        {
            get { return this._includeQuickSightQIndex; }
            set { this._includeQuickSightQIndex = value; }
        }

        // Check to see if IncludeQuickSightQIndex property is set
        internal bool IsSetIncludeQuickSightQIndex()
        {
            return this._includeQuickSightQIndex != null;
        }

        /// <summary>
        /// Gets and sets the property MaxTopicsToConsider. 
        /// <para>
        /// The number of maximum topics to be considered to predict QA results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public int? MaxTopicsToConsider
        {
            get { return this._maxTopicsToConsider; }
            set { this._maxTopicsToConsider = value; }
        }

        // Check to see if MaxTopicsToConsider property is set
        internal bool IsSetMaxTopicsToConsider()
        {
            return this._maxTopicsToConsider.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The query text to be used to predict QA results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string QueryText
        {
            get { return this._queryText; }
            set { this._queryText = value; }
        }

        // Check to see if QueryText property is set
        internal bool IsSetQueryText()
        {
            return this._queryText != null;
        }

    }
}