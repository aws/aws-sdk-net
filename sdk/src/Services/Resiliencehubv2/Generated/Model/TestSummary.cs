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
    /// Contains summary information about a test.
    /// </summary>
    public partial class TestSummary
    {
        private DateTime? _creationTime;
        private string _serviceArn;
        private int? _successfulTestRuns;
        private string _testId;
        private string _testTemplateArn;
        private int? _totalTestRuns;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the test was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

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
        /// Gets and sets the property SuccessfulTestRuns. 
        /// <para>
        /// The number of successful runs of the test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? SuccessfulTestRuns
        {
            get { return this._successfulTestRuns; }
            set { this._successfulTestRuns = value; }
        }

        // Check to see if SuccessfulTestRuns property is set
        internal bool IsSetSuccessfulTestRuns()
        {
            return this._successfulTestRuns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestId. 
        /// <para>
        /// The unique identifier of the test.
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
        /// Gets and sets the property TestTemplateArn. 
        /// <para>
        /// The ARN of the test template the test was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string TestTemplateArn
        {
            get { return this._testTemplateArn; }
            set { this._testTemplateArn = value; }
        }

        // Check to see if TestTemplateArn property is set
        internal bool IsSetTestTemplateArn()
        {
            return this._testTemplateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TotalTestRuns. 
        /// <para>
        /// The total number of runs of the test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalTestRuns
        {
            get { return this._totalTestRuns; }
            set { this._totalTestRuns = value; }
        }

        // Check to see if TotalTestRuns property is set
        internal bool IsSetTotalTestRuns()
        {
            return this._totalTestRuns.HasValue; 
        }

    }
}