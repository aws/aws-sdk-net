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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Container for the parameters to the BatchCreateVariable operation.
    /// Creates a batch of variables.
    /// </summary>
    public partial class BatchCreateVariableRequest : AmazonFraudDetectorRequest
    {
        private List<VariableEntry> _variableEntries = new List<VariableEntry>();

        /// <summary>
        /// Gets and sets the property VariableEntries. 
        /// <para>
        /// The list of variables for the batch create variable request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<VariableEntry> VariableEntries
        {
            get { return this._variableEntries; }
            set { this._variableEntries = value; }
        }

        // Check to see if VariableEntries property is set
        internal bool IsSetVariableEntries()
        {
            return this._variableEntries != null && this._variableEntries.Count > 0; 
        }

    }
}