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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Provides information about the Explainability resource.
    /// </summary>
    public partial class ExplainabilityInfo
    {
        private string _explainabilityArn;
        private string _status;

        /// <summary>
        /// Gets and sets the property ExplainabilityArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Explainability.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string ExplainabilityArn
        {
            get { return this._explainabilityArn; }
            set { this._explainabilityArn = value; }
        }

        // Check to see if ExplainabilityArn property is set
        internal bool IsSetExplainabilityArn()
        {
            return this._explainabilityArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the Explainability. States include: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code>, <code>CREATE_IN_PROGRESS</code>, <code>CREATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_STOPPING</code>, <code>CREATE_STOPPED</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_PENDING</code>, <code>DELETE_IN_PROGRESS</code>, <code>DELETE_FAILED</code>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}