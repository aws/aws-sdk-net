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
    /// Container for the parameters to the PredictQAResults operation. Predicts existing
    /// visuals or generates new visuals to answer a given query. <para> This API uses <a
    /// href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation.html">trusted
    /// identity propagation</a> to ensure that an end user is authenticated and receives
    /// the embed URL that is specific to that user. The IAM Identity Center application that
    /// the user has logged into needs to have <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-using-customermanagedapps-specify-trusted-apps.html">trusted
    /// Identity Propagation enabled for Quick</a> with the scope value set to <c>quicksight:read</c>.
    /// Before you use this action, make sure that you have configured the relevant Quick
    /// resource and permissions. </para> <para> We recommend enabling the <c>QSearchStatus</c>
    /// API to unlock the full potential of <c>PredictQnA</c>. When <c>QSearchStatus</c> is
    /// enabled, it first checks the specified dashboard for any existing visuals that match
    /// the question. If no matching visuals are found, <c>PredictQnA</c> uses generative
    /// Q&amp;A to provide an answer. To update the <c>QSearchStatus</c>, see <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_UpdateQuickSightQSearchConfiguration.html">UpdateQuickSightQSearchConfiguration</a>.
    /// </para>
    /// </summary>
    public partial class PredictQAResultsRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The ID of the Amazon Web Services account that the user wants to execute Predict QA
        /// results in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;

        /// <summary>
        /// Gets and sets the property IncludeGeneratedAnswer. 
        /// <para>
        /// Indicates whether generated answers are included or excluded.
        /// </para>
        /// </summary>
        public IncludeGeneratedAnswer IncludeGeneratedAnswer { get; set; }

        /// <summary>
        /// Checks to see if the IncludeGeneratedAnswer property is set.
        /// </summary>
        internal bool IsSetIncludeGeneratedAnswer() => this.IncludeGeneratedAnswer != null;

        /// <summary>
        /// Gets and sets the property IncludeQuickSightQIndex. 
        /// <para>
        /// Indicates whether Q indicies are included or excluded.
        /// </para>
        /// </summary>
        public IncludeQuickSightQIndex IncludeQuickSightQIndex { get; set; }

        /// <summary>
        /// Checks to see if the IncludeQuickSightQIndex property is set.
        /// </summary>
        internal bool IsSetIncludeQuickSightQIndex() => this.IncludeQuickSightQIndex != null;

        /// <summary>
        /// Gets and sets the property MaxTopicsToConsider. 
        /// <para>
        /// The number of maximum topics to be considered to predict QA results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public int? MaxTopicsToConsider { get; set; }

        /// <summary>
        /// Checks to see if the MaxTopicsToConsider property is set.
        /// </summary>
        internal bool IsSetMaxTopicsToConsider() => this.MaxTopicsToConsider.HasValue;

        /// <summary>
        /// Gets and sets the property QueryText. 
        /// <para>
        /// The query text to be used to predict QA results.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string QueryText { get; set; }

        /// <summary>
        /// Checks to see if the QueryText property is set.
        /// </summary>
        internal bool IsSetQueryText() => this.QueryText != null;
    }
}
