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
 * Do not modify this file. This file is generated from the appflow-2020-08-23.normal.json service model.
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
namespace Amazon.Appflow.Model
{
    /// <summary>
    /// This is the response object from the CancelFlowExecutions operation.
    /// </summary>
    public partial class CancelFlowExecutionsResponse : AmazonWebServiceResponse
    {
        private List<string> _invalidExecutions = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property InvalidExecutions. 
        /// <para>
        /// The IDs of runs that Amazon AppFlow couldn't cancel. These runs might be ineligible
        /// for canceling because they haven't started yet or have already completed.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> InvalidExecutions
        {
            get { return this._invalidExecutions; }
            set { this._invalidExecutions = value; }
        }

        // Check to see if InvalidExecutions property is set
        internal bool IsSetInvalidExecutions()
        {
            return this._invalidExecutions != null && (this._invalidExecutions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}