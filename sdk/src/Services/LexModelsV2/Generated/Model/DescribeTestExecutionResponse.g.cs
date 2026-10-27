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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// This is the response object from the DescribeTestExecution operation.
    /// </summary>
    public partial class DescribeTestExecutionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property ApiMode. 
        /// <para>
        /// Indicates whether we use streaming or non-streaming APIs are used for the test set
        /// execution. For streaming, <c>StartConversation</c> Amazon Lex Runtime API is used.
        /// Whereas for non-streaming, <c>RecognizeUtterance</c> and <c>RecognizeText</c> Amazon
        /// Lex Runtime API is used.
        /// </para>
        /// </summary>
        public TestExecutionApiMode ApiMode { get; set; }

        /// <summary>
        /// Checks to see if the ApiMode property is set.
        /// </summary>
        internal bool IsSetApiMode() => this.ApiMode != null;

        /// <summary>
        /// Gets and sets the property CreationDateTime. 
        /// <para>
        /// The execution creation date and time for the test set execution.
        /// </para>
        /// </summary>
        public DateTime? CreationDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationDateTime property is set.
        /// </summary>
        internal bool IsSetCreationDateTime() => this.CreationDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReasons. 
        /// <para>
        /// Reasons for the failure of the test set execution.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the FailureReasons property is set.
        /// </summary>
        internal bool IsSetFailureReasons() => this.FailureReasons != null && (this.FailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time of the last update for the execution.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedDateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedDateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedDateTime() => this.LastUpdatedDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target bot for the test set execution details.
        /// </para>
        /// </summary>
        public TestExecutionTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TestExecutionId. 
        /// <para>
        /// The execution Id for the test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string TestExecutionId { get; set; }

        /// <summary>
        /// Checks to see if the TestExecutionId property is set.
        /// </summary>
        internal bool IsSetTestExecutionId() => this.TestExecutionId != null;

        /// <summary>
        /// Gets and sets the property TestExecutionModality. 
        /// <para>
        /// Indicates whether test set is audio or text.
        /// </para>
        /// </summary>
        public TestExecutionModality TestExecutionModality { get; set; }

        /// <summary>
        /// Checks to see if the TestExecutionModality property is set.
        /// </summary>
        internal bool IsSetTestExecutionModality() => this.TestExecutionModality != null;

        /// <summary>
        /// Gets and sets the property TestExecutionStatus. 
        /// <para>
        /// The test execution status for the test execution.
        /// </para>
        /// </summary>
        public TestExecutionStatus TestExecutionStatus { get; set; }

        /// <summary>
        /// Checks to see if the TestExecutionStatus property is set.
        /// </summary>
        internal bool IsSetTestExecutionStatus() => this.TestExecutionStatus != null;

        /// <summary>
        /// Gets and sets the property TestSetId. 
        /// <para>
        /// The test set Id for the test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 10)]
        public string TestSetId { get; set; }

        /// <summary>
        /// Checks to see if the TestSetId property is set.
        /// </summary>
        internal bool IsSetTestSetId() => this.TestSetId != null;

        /// <summary>
        /// Gets and sets the property TestSetName. 
        /// <para>
        /// The test set name of the test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string TestSetName { get; set; }

        /// <summary>
        /// Checks to see if the TestSetName property is set.
        /// </summary>
        internal bool IsSetTestSetName() => this.TestSetName != null;
    }
}
