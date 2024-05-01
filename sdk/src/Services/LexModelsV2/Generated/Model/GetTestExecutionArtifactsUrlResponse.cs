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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
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
    /// This is the response object from the GetTestExecutionArtifactsUrl operation.
    /// </summary>
    public partial class GetTestExecutionArtifactsUrlResponse : AmazonWebServiceResponse
    {
        private string _downloadArtifactsUrl;
        private string _testExecutionId;

        /// <summary>
        /// Gets and sets the property DownloadArtifactsUrl. 
        /// <para>
        /// The pre-signed Amazon S3 URL to download completed test execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DownloadArtifactsUrl
        {
            get { return this._downloadArtifactsUrl; }
            set { this._downloadArtifactsUrl = value; }
        }

        // Check to see if DownloadArtifactsUrl property is set
        internal bool IsSetDownloadArtifactsUrl()
        {
            return this._downloadArtifactsUrl != null;
        }

        /// <summary>
        /// Gets and sets the property TestExecutionId. 
        /// <para>
        /// The unique identifier of the completed test execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=10)]
        public string TestExecutionId
        {
            get { return this._testExecutionId; }
            set { this._testExecutionId = value; }
        }

        // Check to see if TestExecutionId property is set
        internal bool IsSetTestExecutionId()
        {
            return this._testExecutionId != null;
        }

    }
}