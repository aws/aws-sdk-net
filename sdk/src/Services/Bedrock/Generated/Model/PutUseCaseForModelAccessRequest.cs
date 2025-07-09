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
    /// Container for the parameters to the PutUseCaseForModelAccess operation.
    /// Put usecase for model access.
    /// </summary>
    public partial class PutUseCaseForModelAccessRequest : AmazonBedrockRequest
    {
        private MemoryStream _formData;

        /// <summary>
        /// Gets and sets the property FormData. 
        /// <para>
        /// Put customer profile Request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=16384)]
        public MemoryStream FormData
        {
            get { return this._formData; }
            set { this._formData = value; }
        }

        // Check to see if FormData property is set
        internal bool IsSetFormData()
        {
            return this._formData != null;
        }

    }
}