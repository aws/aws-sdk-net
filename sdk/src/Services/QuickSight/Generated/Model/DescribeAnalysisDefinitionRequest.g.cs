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
    /// Container for the parameters to the DescribeAnalysisDefinition operation. Provides
    /// a detailed description of the definition of an analysis. <note> <para> If you do not
    /// need to know details about the content of an Analysis, for instance if you are trying
    /// to check the status of a recently created or updated Analysis, use the <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_DescribeAnalysis.html">
    /// <c>DescribeAnalysis</c> </a> instead. </para> </note>
    /// </summary>
    public partial class DescribeAnalysisDefinitionRequest : AmazonQuickSightRequest
    {
        /// <summary>
        /// Gets and sets the property AnalysisId. 
        /// <para>
        /// The ID of the analysis that you're describing. The ID is part of the URL of the analysis.
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
        /// The ID of the Amazon Web Services account that contains the analysis. You must be
        /// using the Amazon Web Services account that the analysis is in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 12)]
        public string AwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AwsAccountId property is set.
        /// </summary>
        internal bool IsSetAwsAccountId() => this.AwsAccountId != null;
    }
}
