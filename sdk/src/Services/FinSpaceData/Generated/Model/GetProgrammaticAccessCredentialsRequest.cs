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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
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
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Container for the parameters to the GetProgrammaticAccessCredentials operation.
    /// Request programmatic credentials to use with FinSpace SDK. For more information, see
    /// <a href="https://docs.aws.amazon.com/finspace/latest/data-api/fs-using-the-finspace-api.html#accessing-credentials">Step
    /// 2. Access credentials programmatically using IAM access key id and secret access key</a>.
    /// </summary>
    public partial class GetProgrammaticAccessCredentialsRequest : AmazonFinSpaceDataRequest
    {
        private long? _durationInMinutes;
        private string _environmentId;

        /// <summary>
        /// Gets and sets the property DurationInMinutes. 
        /// <para>
        /// The time duration in which the credentials remain valid. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=60)]
        public long? DurationInMinutes
        {
            get { return this._durationInMinutes; }
            set { this._durationInMinutes = value; }
        }

        // Check to see if DurationInMinutes property is set
        internal bool IsSetDurationInMinutes()
        {
            return this._durationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The FinSpace environment identifier.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=26)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

    }
}