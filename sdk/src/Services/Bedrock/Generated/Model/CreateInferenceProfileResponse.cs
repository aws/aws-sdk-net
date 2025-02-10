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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the CreateInferenceProfile operation.
    /// </summary>
    public partial class CreateInferenceProfileResponse : AmazonWebServiceResponse
    {
        private string _inferenceProfileArn;
        private InferenceProfileStatus _status;

        /// <summary>
        /// Gets and sets the property InferenceProfileArn. 
        /// <para>
        /// The ARN of the inference profile that you created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string InferenceProfileArn
        {
            get { return this._inferenceProfileArn; }
            set { this._inferenceProfileArn = value; }
        }

        // Check to see if InferenceProfileArn property is set
        internal bool IsSetInferenceProfileArn()
        {
            return this._inferenceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the inference profile. <c>ACTIVE</c> means that the inference profile
        /// is ready to be used.
        /// </para>
        /// </summary>
        public InferenceProfileStatus Status
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