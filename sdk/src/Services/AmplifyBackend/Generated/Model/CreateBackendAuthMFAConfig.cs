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
 * Do not modify this file. This file is generated from the amplifybackend-2020-08-11.normal.json service model.
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
namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// Describes whether to apply multi-factor authentication policies for your Amazon Cognito
    /// user pool configured as a part of your Amplify project.
    /// </summary>
    public partial class CreateBackendAuthMFAConfig
    {
        private MFAMode _mfaMode;
        private Settings _settings;

        /// <summary>
        /// Gets and sets the property MFAMode. 
        /// <para>
        /// Describes whether MFA should be [ON, OFF, or OPTIONAL] for authentication in your
        /// Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MFAMode MFAMode
        {
            get { return this._mfaMode; }
            set { this._mfaMode = value; }
        }

        // Check to see if MFAMode property is set
        internal bool IsSetMFAMode()
        {
            return this._mfaMode != null;
        }

        /// <summary>
        /// Gets and sets the property Settings. 
        /// <para>
        /// Describes the configuration settings and methods for your Amplify app users to use
        /// MFA.
        /// </para>
        /// </summary>
        public Settings Settings
        {
            get { return this._settings; }
            set { this._settings = value; }
        }

        // Check to see if Settings property is set
        internal bool IsSetSettings()
        {
            return this._settings != null;
        }

    }
}