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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the DisableControl operation.
    /// This API call turns off a control. It starts an asynchronous operation that deletes
    /// Amazon Web Services resources on the specified organizational unit and the accounts
    /// it contains. The resources will vary according to the control that you specify. For
    /// usage examples, see the <a href="https://docs.aws.amazon.com/controltower/latest/controlreference/control-api-examples-short.html">
    /// <i>Controls Reference Guide</i> </a>.
    /// </summary>
    public partial class DisableControlRequest : AmazonControlTowerRequest
    {
        private string _controlIdentifier;
        private string _targetIdentifier;

        /// <summary>
        /// Gets and sets the property ControlIdentifier. 
        /// <para>
        /// The ARN of the control. Only <b>Strongly recommended</b> and <b>Elective</b> controls
        /// are permitted, with the exception of the <b>Region deny</b> control. For information
        /// on how to find the <c>controlIdentifier</c>, see <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/Welcome.html">the
        /// overview page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ControlIdentifier
        {
            get { return this._controlIdentifier; }
            set { this._controlIdentifier = value; }
        }

        // Check to see if ControlIdentifier property is set
        internal bool IsSetControlIdentifier()
        {
            return this._controlIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TargetIdentifier. 
        /// <para>
        /// The ARN of the organizational unit. For information on how to find the <c>targetIdentifier</c>,
        /// see <a href="https://docs.aws.amazon.com/controltower/latest/APIReference/Welcome.html">the
        /// overview page</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TargetIdentifier
        {
            get { return this._targetIdentifier; }
            set { this._targetIdentifier = value; }
        }

        // Check to see if TargetIdentifier property is set
        internal bool IsSetTargetIdentifier()
        {
            return this._targetIdentifier != null;
        }

    }
}