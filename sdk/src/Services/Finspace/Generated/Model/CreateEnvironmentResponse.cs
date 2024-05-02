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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// This is the response object from the CreateEnvironment operation.
    /// </summary>
    public partial class CreateEnvironmentResponse : AmazonWebServiceResponse
    {
        private string _environmentArn;
        private string _environmentId;
        private string _environmentUrl;

        /// <summary>
        /// Gets and sets the property EnvironmentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the FinSpace environment that you created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string EnvironmentArn
        {
            get { return this._environmentArn; }
            set { this._environmentArn = value; }
        }

        // Check to see if EnvironmentArn property is set
        internal bool IsSetEnvironmentArn()
        {
            return this._environmentArn != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// The unique identifier for FinSpace environment that you created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
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

        /// <summary>
        /// Gets and sets the property EnvironmentUrl. 
        /// <para>
        /// The sign-in URL for the web application of the FinSpace environment you created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string EnvironmentUrl
        {
            get { return this._environmentUrl; }
            set { this._environmentUrl = value; }
        }

        // Check to see if EnvironmentUrl property is set
        internal bool IsSetEnvironmentUrl()
        {
            return this._environmentUrl != null;
        }

    }
}