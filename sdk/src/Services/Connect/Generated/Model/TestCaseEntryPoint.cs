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
    /// Defines the starting point for a test case.
    /// </summary>
    public partial class TestCaseEntryPoint
    {
        private TestCaseEntryPointType _type;
        private VoiceCallEntryPointParameters _voiceCallEntryPointParameters;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of entry point.
        /// </para>
        /// </summary>
        public TestCaseEntryPointType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VoiceCallEntryPointParameters. 
        /// <para>
        /// Parameters for voice call entry point.
        /// </para>
        /// </summary>
        public VoiceCallEntryPointParameters VoiceCallEntryPointParameters
        {
            get { return this._voiceCallEntryPointParameters; }
            set { this._voiceCallEntryPointParameters = value; }
        }

        // Check to see if VoiceCallEntryPointParameters property is set
        internal bool IsSetVoiceCallEntryPointParameters()
        {
            return this._voiceCallEntryPointParameters != null;
        }

    }
}