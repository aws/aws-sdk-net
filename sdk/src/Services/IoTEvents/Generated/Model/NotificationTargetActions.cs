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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
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
namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Specifies an AWS Lambda function to manage alarm notifications. You can create one
    /// or use the <a href="https://docs.aws.amazon.com/iotevents/latest/developerguide/lambda-support.html">AWS
    /// Lambda function provided by AWS IoT Events</a>.
    /// </summary>
    public partial class NotificationTargetActions
    {
        private LambdaAction _lambdaAction;

        /// <summary>
        /// Gets and sets the property LambdaAction.
        /// </summary>
        public LambdaAction LambdaAction
        {
            get { return this._lambdaAction; }
            set { this._lambdaAction = value; }
        }

        // Check to see if LambdaAction property is set
        internal bool IsSetLambdaAction()
        {
            return this._lambdaAction != null;
        }

    }
}