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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Represents the output of a test repository triggers operation.
    /// </summary>
    public partial class TestRepositoryTriggersResponse : AmazonWebServiceResponse
    {
        private List<RepositoryTriggerExecutionFailure> _failedExecutions = AWSConfigs.InitializeCollections ? new List<RepositoryTriggerExecutionFailure>() : null;
        private List<string> _successfulExecutions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FailedExecutions. 
        /// <para>
        /// The list of triggers that were not tested. This list provides the names of the triggers
        /// that could not be tested, separated by commas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RepositoryTriggerExecutionFailure> FailedExecutions
        {
            get { return this._failedExecutions; }
            set { this._failedExecutions = value; }
        }

        // Check to see if FailedExecutions property is set
        internal bool IsSetFailedExecutions()
        {
            return this._failedExecutions != null && (this._failedExecutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulExecutions. 
        /// <para>
        /// The list of triggers that were successfully tested. This list provides the names of
        /// the triggers that were successfully tested, separated by commas.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SuccessfulExecutions
        {
            get { return this._successfulExecutions; }
            set { this._successfulExecutions = value; }
        }

        // Check to see if SuccessfulExecutions property is set
        internal bool IsSetSuccessfulExecutions()
        {
            return this._successfulExecutions != null && (this._successfulExecutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}