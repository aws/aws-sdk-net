/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Represents the output of a test repository triggers operation.
    /// </summary>
    public partial class TestRepositoryTriggersResponse : AmazonWebServiceResponse
    {
        private List<RepositoryTriggerExecutionFailure> _failedExecutions = new List<RepositoryTriggerExecutionFailure>();
        private List<string> _successfulExecutions = new List<string>();

        /// <summary>
        /// Gets and sets the property FailedExecutions. 
        /// <para>
        /// The list of triggers that were not able to be tested. This list provides the names
        /// of the triggers that could not be tested, separated by commas.
        /// </para>
        /// </summary>
        public List<RepositoryTriggerExecutionFailure> FailedExecutions
        {
            get { return this._failedExecutions; }
            set { this._failedExecutions = value; }
        }

        // Check to see if FailedExecutions property is set
        internal bool IsSetFailedExecutions()
        {
            return this._failedExecutions != null && this._failedExecutions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SuccessfulExecutions. 
        /// <para>
        /// The list of triggers that were successfully tested. This list provides the names of
        /// the triggers that were successfully tested, separated by commas.
        /// </para>
        /// </summary>
        public List<string> SuccessfulExecutions
        {
            get { return this._successfulExecutions; }
            set { this._successfulExecutions = value; }
        }

        // Check to see if SuccessfulExecutions property is set
        internal bool IsSetSuccessfulExecutions()
        {
            return this._successfulExecutions != null && this._successfulExecutions.Count > 0; 
        }

    }
}