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
 * Do not modify this file. This file is generated from the alexaforbusiness-2017-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AlexaForBusiness.Model
{
    /// <summary>
    /// The default conference provider that is used if no other scheduled meetings are detected.
    /// </summary>
    public partial class ConferencePreference
    {
        private string _defaultConferenceProviderArn;

        /// <summary>
        /// Gets and sets the property DefaultConferenceProviderArn. 
        /// <para>
        /// The ARN of the default conference provider.
        /// </para>
        /// </summary>
        public string DefaultConferenceProviderArn
        {
            get { return this._defaultConferenceProviderArn; }
            set { this._defaultConferenceProviderArn = value; }
        }

        // Check to see if DefaultConferenceProviderArn property is set
        internal bool IsSetDefaultConferenceProviderArn()
        {
            return this._defaultConferenceProviderArn != null;
        }

    }
}