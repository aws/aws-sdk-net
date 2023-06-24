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

namespace Amazon.Imagebuilder.Model
{
    /// <summary>
    /// Container for the parameters to the CancelImageCreation operation.
    /// CancelImageCreation cancels the creation of Image. This operation can only be used
    /// on images in a non-terminal state.
    /// </summary>
    public partial class CancelImageCreationRequest : AmazonImagebuilderRequest
    {
        private string _clientToken;
        private string _imageBuildVersionArn;

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
        /// Gets and sets the property ImageBuildVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the image that you want to cancel creation for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImageBuildVersionArn
        {
            get { return this._imageBuildVersionArn; }
            set { this._imageBuildVersionArn = value; }
        }

        // Check to see if ImageBuildVersionArn property is set
        internal bool IsSetImageBuildVersionArn()
        {
            return this._imageBuildVersionArn != null;
        }

    }
}