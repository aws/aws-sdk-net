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
 * Do not modify this file. This file is generated from the apptest-2022-12-06.normal.json service model.
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
namespace Amazon.AppTest.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateTestSuite operation.
    /// Updates a test suite.
    /// </summary>
    public partial class UpdateTestSuiteRequest : AmazonAppTestRequest
    {
        private List<Step> _afterSteps = AWSConfigs.InitializeCollections ? new List<Step>() : null;
        private List<Step> _beforeSteps = AWSConfigs.InitializeCollections ? new List<Step>() : null;
        private string _description;
        private TestCases _testCases;
        private string _testSuiteId;

        /// <summary>
        /// Gets and sets the property AfterSteps. 
        /// <para>
        /// The after steps of the test suite.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<Step> AfterSteps
        {
            get { return this._afterSteps; }
            set { this._afterSteps = value; }
        }

        // Check to see if AfterSteps property is set
        internal bool IsSetAfterSteps()
        {
            return this._afterSteps != null && (this._afterSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BeforeSteps. 
        /// <para>
        /// The before steps for the test suite.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<Step> BeforeSteps
        {
            get { return this._beforeSteps; }
            set { this._beforeSteps = value; }
        }

        // Check to see if BeforeSteps property is set
        internal bool IsSetBeforeSteps()
        {
            return this._beforeSteps != null && (this._beforeSteps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property TestCases. 
        /// <para>
        /// The test cases in the test suite.
        /// </para>
        /// </summary>
        public TestCases TestCases
        {
            get { return this._testCases; }
            set { this._testCases = value; }
        }

        // Check to see if TestCases property is set
        internal bool IsSetTestCases()
        {
            return this._testCases != null;
        }

        /// <summary>
        /// Gets and sets the property TestSuiteId. 
        /// <para>
        /// The test suite ID of the test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TestSuiteId
        {
            get { return this._testSuiteId; }
            set { this._testSuiteId = value; }
        }

        // Check to see if TestSuiteId property is set
        internal bool IsSetTestSuiteId()
        {
            return this._testSuiteId != null;
        }

    }
}