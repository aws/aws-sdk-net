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
 * Do not modify this file. This file is generated from the lambda-microvms-2025-09-09.normal.json service model.
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
namespace Amazon.LambdaMicrovms.Model
{
    /// <summary>
    /// Configuration for hooks invoked during MicroVM image build events such as ready and
    /// validate.
    /// </summary>
    public partial class MicrovmImageHooks
    {
        private HookState _ready;
        private int? _readyTimeoutInSeconds;
        private HookState _validate;
        private int? _validateTimeoutInSeconds;

        /// <summary>
        /// Gets and sets the property Ready. 
        /// <para>
        /// The path of the hook invoked when the MicroVM image build is ready.
        /// </para>
        /// </summary>
        public HookState Ready
        {
            get { return this._ready; }
            set { this._ready = value; }
        }

        // Check to see if Ready property is set
        internal bool IsSetReady()
        {
            return this._ready != null;
        }

        /// <summary>
        /// Gets and sets the property ReadyTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the ready hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3600)]
        public int? ReadyTimeoutInSeconds
        {
            get { return this._readyTimeoutInSeconds; }
            set { this._readyTimeoutInSeconds = value; }
        }

        // Check to see if ReadyTimeoutInSeconds property is set
        internal bool IsSetReadyTimeoutInSeconds()
        {
            return this._readyTimeoutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Validate. 
        /// <para>
        /// The path of the hook invoked to validate the MicroVM image build.
        /// </para>
        /// </summary>
        public HookState Validate
        {
            get { return this._validate; }
            set { this._validate = value; }
        }

        // Check to see if Validate property is set
        internal bool IsSetValidate()
        {
            return this._validate != null;
        }

        /// <summary>
        /// Gets and sets the property ValidateTimeoutInSeconds. 
        /// <para>
        /// The maximum time in seconds for the validate hook to complete.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=3600)]
        public int? ValidateTimeoutInSeconds
        {
            get { return this._validateTimeoutInSeconds; }
            set { this._validateTimeoutInSeconds = value; }
        }

        // Check to see if ValidateTimeoutInSeconds property is set
        internal bool IsSetValidateTimeoutInSeconds()
        {
            return this._validateTimeoutInSeconds.HasValue; 
        }

    }
}