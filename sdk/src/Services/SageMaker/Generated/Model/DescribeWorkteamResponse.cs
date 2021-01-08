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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeWorkteam operation.
    /// </summary>
    public partial class DescribeWorkteamResponse : AmazonWebServiceResponse
    {
        private Workteam _workteam;

        /// <summary>
        /// Gets and sets the property Workteam. 
        /// <para>
        /// A <code>Workteam</code> instance that contains information about the work team. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Workteam Workteam
        {
            get { return this._workteam; }
            set { this._workteam = value; }
        }

        // Check to see if Workteam property is set
        internal bool IsSetWorkteam()
        {
            return this._workteam != null;
        }

    }
}