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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// The details of the streaming configuration of an <code>AppInstance</code>.
    /// </summary>
    public partial class AppInstanceStreamingConfiguration
    {
        private AppInstanceDataType _appInstanceDataType;
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property AppInstanceDataType. 
        /// <para>
        /// The type of data to be streamed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AppInstanceDataType AppInstanceDataType
        {
            get { return this._appInstanceDataType; }
            set { this._appInstanceDataType = value; }
        }

        // Check to see if AppInstanceDataType property is set
        internal bool IsSetAppInstanceDataType()
        {
            return this._appInstanceDataType != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The resource ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=1024)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}