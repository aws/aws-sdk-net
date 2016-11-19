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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
    /// The output for the <a>CancelSteps</a> operation.
    /// </summary>
    public partial class CancelStepsResponse : AmazonWebServiceResponse
    {
        private List<CancelStepsInfo> _cancelStepsInfoList = new List<CancelStepsInfo>();

        /// <summary>
        /// Gets and sets the property CancelStepsInfoList. 
        /// <para>
        /// A list of <a>CancelStepsInfo</a>, which shows the status of specified cancel requests
        /// for each <code>StepID</code> specified.
        /// </para>
        /// </summary>
        public List<CancelStepsInfo> CancelStepsInfoList
        {
            get { return this._cancelStepsInfoList; }
            set { this._cancelStepsInfoList = value; }
        }

        // Check to see if CancelStepsInfoList property is set
        internal bool IsSetCancelStepsInfoList()
        {
            return this._cancelStepsInfoList != null && this._cancelStepsInfoList.Count > 0; 
        }

    }
}