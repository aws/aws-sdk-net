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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the CreateMitigationAction operation.
    /// </summary>
    public partial class CreateMitigationActionResponse : AmazonWebServiceResponse
    {
        private string _actionArn;
        private string _actionId;

        /// <summary>
        /// Gets and sets the property ActionArn. 
        /// <para>
        /// The ARN for the new mitigation action.
        /// </para>
        /// </summary>
        public string ActionArn
        {
            get { return this._actionArn; }
            set { this._actionArn = value; }
        }

        // Check to see if ActionArn property is set
        internal bool IsSetActionArn()
        {
            return this._actionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ActionId. 
        /// <para>
        /// A unique identifier for the new mitigation action.
        /// </para>
        /// </summary>
        public string ActionId
        {
            get { return this._actionId; }
            set { this._actionId = value; }
        }

        // Check to see if ActionId property is set
        internal bool IsSetActionId()
        {
            return this._actionId != null;
        }

    }
}