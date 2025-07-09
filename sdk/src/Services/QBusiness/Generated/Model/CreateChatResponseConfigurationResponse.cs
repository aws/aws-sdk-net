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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// This is the response object from the CreateChatResponseConfiguration operation.
    /// </summary>
    public partial class CreateChatResponseConfigurationResponse : AmazonWebServiceResponse
    {
        private string _chatResponseConfigurationArn;
        private string _chatResponseConfigurationId;

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the newly created chat response configuration, which
        /// uniquely identifies the resource across all Amazon Web Services services. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1284)]
        public string ChatResponseConfigurationArn
        {
            get { return this._chatResponseConfigurationArn; }
            set { this._chatResponseConfigurationArn = value; }
        }

        // Check to see if ChatResponseConfigurationArn property is set
        internal bool IsSetChatResponseConfigurationArn()
        {
            return this._chatResponseConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ChatResponseConfigurationId. 
        /// <para>
        /// The unique identifier assigned to a newly created chat response configuration, used
        /// for subsequent operations on this resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string ChatResponseConfigurationId
        {
            get { return this._chatResponseConfigurationId; }
            set { this._chatResponseConfigurationId = value; }
        }

        // Check to see if ChatResponseConfigurationId property is set
        internal bool IsSetChatResponseConfigurationId()
        {
            return this._chatResponseConfigurationId != null;
        }

    }
}