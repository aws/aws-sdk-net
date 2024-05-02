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
    /// Container for the parameters to the UpdateMitigationAction operation.
    /// Updates the definition for the specified mitigation action.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateMitigationAction</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class UpdateMitigationActionRequest : AmazonIoTRequest
    {
        private string _actionName;
        private MitigationActionParams _actionParams;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The friendly name for the mitigation action. You cannot change the name by using <c>UpdateMitigationAction</c>.
        /// Instead, you must delete and recreate the mitigation action with the new name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=128)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property ActionParams. 
        /// <para>
        /// Defines the type of action and the parameters for that action.
        /// </para>
        /// </summary>
        public MitigationActionParams ActionParams
        {
            get { return this._actionParams; }
            set { this._actionParams = value; }
        }

        // Check to see if ActionParams property is set
        internal bool IsSetActionParams()
        {
            return this._actionParams != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that is used to apply the mitigation action.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}