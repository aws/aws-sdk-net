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

namespace Amazon.AmplifyBackend.Model
{
    /// <summary>
    /// The password policy configuration for the backend of your Amplify project.
    /// </summary>
    public partial class CreateBackendAuthPasswordPolicyConfig
    {
        private List<string> _additionalConstraints = new List<string>();
        private double? _minimumLength;

        /// <summary>
        /// Gets and sets the property AdditionalConstraints. 
        /// <para>
        /// Additional constraints for the password used to access the backend of your Amplify
        /// project.
        /// </para>
        /// </summary>
        public List<string> AdditionalConstraints
        {
            get { return this._additionalConstraints; }
            set { this._additionalConstraints = value; }
        }

        // Check to see if AdditionalConstraints property is set
        internal bool IsSetAdditionalConstraints()
        {
            return this._additionalConstraints != null && this._additionalConstraints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MinimumLength. 
        /// <para>
        /// The minimum length of the password used to access the backend of your Amplify project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public double MinimumLength
        {
            get { return this._minimumLength.GetValueOrDefault(); }
            set { this._minimumLength = value; }
        }

        // Check to see if MinimumLength property is set
        internal bool IsSetMinimumLength()
        {
            return this._minimumLength.HasValue; 
        }

    }
}