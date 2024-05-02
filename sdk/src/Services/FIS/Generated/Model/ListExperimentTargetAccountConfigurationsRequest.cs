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
 * Do not modify this file. This file is generated from the fis-2020-12-01.normal.json service model.
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
namespace Amazon.FIS.Model
{
    /// <summary>
    /// Container for the parameters to the ListExperimentTargetAccountConfigurations operation.
    /// Lists the target account configurations of the specified experiment.
    /// </summary>
    public partial class ListExperimentTargetAccountConfigurationsRequest : AmazonFISRequest
    {
        private string _experimentId;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExperimentId. 
        /// <para>
        /// The ID of the experiment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=64)]
        public string ExperimentId
        {
            get { return this._experimentId; }
            set { this._experimentId = value; }
        }

        // Check to see if ExperimentId property is set
        internal bool IsSetExperimentId()
        {
            return this._experimentId != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}