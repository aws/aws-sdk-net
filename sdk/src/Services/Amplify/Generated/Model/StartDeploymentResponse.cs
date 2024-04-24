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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// The result structure for the start a deployment request.
    /// </summary>
    public partial class StartDeploymentResponse : AmazonWebServiceResponse
    {
        private JobSummary _jobSummary;

        /// <summary>
        /// Gets and sets the property JobSummary. 
        /// <para>
        /// The summary for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobSummary JobSummary
        {
            get { return this._jobSummary; }
            set { this._jobSummary = value; }
        }

        // Check to see if JobSummary property is set
        internal bool IsSetJobSummary()
        {
            return this._jobSummary != null;
        }

    }
}