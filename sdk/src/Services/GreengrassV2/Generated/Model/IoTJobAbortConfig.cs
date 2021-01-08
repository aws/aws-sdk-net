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
 * Do not modify this file. This file is generated from the greengrassv2-2020-11-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GreengrassV2.Model
{
    /// <summary>
    /// Contains a list of criteria that define when and how to cancel a configuration deployment.
    /// </summary>
    public partial class IoTJobAbortConfig
    {
        private List<IoTJobAbortCriteria> _criteriaList = new List<IoTJobAbortCriteria>();

        /// <summary>
        /// Gets and sets the property CriteriaList. 
        /// <para>
        /// The list of criteria that define when and how to cancel the configuration deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<IoTJobAbortCriteria> CriteriaList
        {
            get { return this._criteriaList; }
            set { this._criteriaList = value; }
        }

        // Check to see if CriteriaList property is set
        internal bool IsSetCriteriaList()
        {
            return this._criteriaList != null && this._criteriaList.Count > 0; 
        }

    }
}