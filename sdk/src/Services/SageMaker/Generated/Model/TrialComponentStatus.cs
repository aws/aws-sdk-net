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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The status of the trial component.
    /// </summary>
    public partial class TrialComponentStatus
    {
        private string _message;
        private TrialComponentPrimaryStatus _primaryStatus;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If the component failed, a message describing why.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property PrimaryStatus. 
        /// <para>
        /// The status of the trial component.
        /// </para>
        /// </summary>
        public TrialComponentPrimaryStatus PrimaryStatus
        {
            get { return this._primaryStatus; }
            set { this._primaryStatus = value; }
        }

        // Check to see if PrimaryStatus property is set
        internal bool IsSetPrimaryStatus()
        {
            return this._primaryStatus != null;
        }

    }
}