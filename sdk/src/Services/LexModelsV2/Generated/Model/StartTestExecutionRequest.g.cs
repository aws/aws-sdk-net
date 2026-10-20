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
    /// Container for the parameters to the StartTestExecution operation. The action to start
    /// test set execution.
    /// </summary>
    public partial class StartTestExecutionRequest : AmazonLexModelsV2Request
    {
        /// <summary>
        /// Gets and sets the property ApiMode. 
        /// <para>
        /// Indicates whether we use streaming or non-streaming APIs for the test set execution.
        /// For streaming, StartConversation Runtime API is used. Whereas, for non-streaming,
        /// RecognizeUtterance and RecognizeText Amazon Lex Runtime API are used.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestExecutionApiMode ApiMode { get; set; }

        /// <summary>
        /// Checks to see if the ApiMode property is set.
        /// </summary>
        internal bool IsSetApiMode() => this.ApiMode != null;

        /// <summary>
        /// Gets and sets the property Target. 
        /// <para>
        /// The target bot for the test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TestExecutionTarget Target { get; set; }

        /// <summary>
        /// Checks to see if the Target property is set.
        /// </summary>
        internal bool IsSetTarget() => this.Target != null;

        /// <summary>
        /// Gets and sets the property TestExecutionModality. 
        /// <para>
        /// Indicates whether audio or text is used.
        /// </para>
        /// </summary>
        public TestExecutionModality TestExecutionModality { get; set; }

        /// <summary>
        /// Checks to see if the TestExecutionModality property is set.
        /// </summary>
        internal bool IsSetTestExecutionModality() => this.TestExecutionModality != null;

        /// <summary>
        /// Gets and sets the property TestSetId. 
        /// <para>
        /// The test set Id for the test set execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string TestSetId { get; set; }

        /// <summary>
        /// Checks to see if the TestSetId property is set.
        /// </summary>
        internal bool IsSetTestSetId() => this.TestSetId != null;
    }
}
