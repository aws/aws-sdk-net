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
 * Do not modify this file. This file is generated from the imagebuilder-2019-12-02.normal.json service model.
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
namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the CancelLifecycleExecution operation.
    /// Cancel a specific image lifecycle policy runtime instance.
    /// </summary>
    public partial class CancelLifecycleExecutionRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private string _lifecycleExecutionId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a> in the <i>Amazon EC2 API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleExecutionId. 
        /// <para>
        /// Identifies the specific runtime instance of the image lifecycle to cancel.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string LifecycleExecutionId
        {
            get { return this._lifecycleExecutionId; }
            set { this._lifecycleExecutionId = value; }
        }

        // Check to see if LifecycleExecutionId property is set
        internal bool IsSetLifecycleExecutionId()
        {
            return this._lifecycleExecutionId != null;
        }

    }
}