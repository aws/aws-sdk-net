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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the CreateContactFlowVersion operation.
    /// </summary>
    public partial class CreateContactFlowVersionResponse : AmazonWebServiceResponse
    {
        private string _contactFlowArn;
        private long? _version;

        /// <summary>
        /// Gets and sets the property ContactFlowArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the flow.
        /// </para>
        /// </summary>
        public string ContactFlowArn
        {
            get { return this._contactFlowArn; }
            set { this._contactFlowArn = value; }
        }

        // Check to see if ContactFlowArn property is set
        internal bool IsSetContactFlowArn()
        {
            return this._contactFlowArn != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The identifier of the flow version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}