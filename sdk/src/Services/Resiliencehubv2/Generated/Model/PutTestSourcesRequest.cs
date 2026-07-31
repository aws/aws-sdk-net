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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Container for the parameters to the PutTestSources operation.
    /// Adds or updates the monitoring sources on a test. The operation is transactional —
    /// either every source is written or the call fails and nothing is written.
    /// </summary>
    public partial class PutTestSourcesRequest : AmazonResiliencehubv2Request
    {
        private string _serviceArn;
        private string _testId;
        private List<TestSourceInput> _testSources = AWSConfigs.InitializeCollections ? new List<TestSourceInput>() : null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service the test belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TestId. 
        /// <para>
        /// The identifier of the test to add sources to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestId
        {
            get { return this._testId; }
            set { this._testId = value; }
        }

        // Check to see if TestId property is set
        internal bool IsSetTestId()
        {
            return this._testId != null;
        }

        /// <summary>
        /// Gets and sets the property TestSources. 
        /// <para>
        /// The monitoring sources to add or update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<TestSourceInput> TestSources
        {
            get { return this._testSources; }
            set { this._testSources = value; }
        }

        // Check to see if TestSources property is set
        internal bool IsSetTestSources()
        {
            return this._testSources != null && (this._testSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}