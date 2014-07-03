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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The output for the <a>AddJobFlowSteps</a> operation.
    /// </summary>
    public partial class AddJobFlowStepsResult : AmazonWebServiceResponse
    {
        private List<string> _stepIds = new List<string>();


        /// <summary>
        /// Gets and sets the property StepIds. 
        /// <para>
        /// The identifiers of the list of steps added to the job flow.
        /// </para>
        /// </summary>
        public List<string> StepIds
        {
            get { return this._stepIds; }
            set { this._stepIds = value; }
        }

        // Check to see if StepIds property is set
        internal bool IsSetStepIds()
        {
            return this._stepIds != null && this._stepIds.Count > 0; 
        }

    }
}