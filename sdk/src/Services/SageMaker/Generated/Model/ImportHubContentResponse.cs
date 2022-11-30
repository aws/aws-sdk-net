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
    /// This is the response object from the ImportHubContent operation.
    /// </summary>
    public partial class ImportHubContentResponse : AmazonWebServiceResponse
    {
        private string _hubArn;
        private string _hubContentArn;

        /// <summary>
        /// Gets and sets the property HubArn. 
        /// <para>
        /// The ARN of the hub that the content was imported into.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string HubArn
        {
            get { return this._hubArn; }
            set { this._hubArn = value; }
        }

        // Check to see if HubArn property is set
        internal bool IsSetHubArn()
        {
            return this._hubArn != null;
        }

        /// <summary>
        /// Gets and sets the property HubContentArn. 
        /// <para>
        /// The ARN of the hub content that was imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string HubContentArn
        {
            get { return this._hubContentArn; }
            set { this._hubContentArn = value; }
        }

        // Check to see if HubContentArn property is set
        internal bool IsSetHubContentArn()
        {
            return this._hubContentArn != null;
        }

    }
}