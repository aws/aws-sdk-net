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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// The result body of the ResetServiceSetting API action.
    /// </summary>
    public partial class ResetServiceSettingResponse : AmazonWebServiceResponse
    {
        private ServiceSetting _serviceSetting;

        /// <summary>
        /// Gets and sets the property ServiceSetting. 
        /// <para>
        /// The current, effective service setting after calling the ResetServiceSetting API action.
        /// </para>
        /// </summary>
        public ServiceSetting ServiceSetting
        {
            get { return this._serviceSetting; }
            set { this._serviceSetting = value; }
        }

        // Check to see if ServiceSetting property is set
        internal bool IsSetServiceSetting()
        {
            return this._serviceSetting != null;
        }

    }
}