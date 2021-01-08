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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the BatchDeleteWorlds operation.
    /// </summary>
    public partial class BatchDeleteWorldsResponse : AmazonWebServiceResponse
    {
        private List<string> _unprocessedWorlds = new List<string>();

        /// <summary>
        /// Gets and sets the property UnprocessedWorlds. 
        /// <para>
        /// A list of unprocessed worlds associated with the call. These worlds were not deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> UnprocessedWorlds
        {
            get { return this._unprocessedWorlds; }
            set { this._unprocessedWorlds = value; }
        }

        // Check to see if UnprocessedWorlds property is set
        internal bool IsSetUnprocessedWorlds()
        {
            return this._unprocessedWorlds != null && this._unprocessedWorlds.Count > 0; 
        }

    }
}