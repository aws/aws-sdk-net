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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Container for the parameters to the GetTestRun operation. Retrieves a test run by
    /// ID, including its status, results, and the configuration snapshotted when the run
    /// started.
    /// </summary>
    public partial class GetTestRunRequest : AmazonResiliencehubv2Request
    {
        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The ARN of the service the test run belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property TestRunId. 
        /// <para>
        /// The identifier of the test run to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string TestRunId { get; set; }

        /// <summary>
        /// Checks to see if the TestRunId property is set.
        /// </summary>
        internal bool IsSetTestRunId() => this.TestRunId != null;
    }
}
