/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the CancelSigningProfile operation.
    /// Changes the state of an <code>ACTIVE</code> signing profile to <code>CANCELED</code>.
    /// A canceled profile is still viewable with the <code>ListSigningProfiles</code> operation,
    /// but it cannot perform new signing jobs, and is deleted two years after cancelation.
    /// </summary>
    public partial class CancelSigningProfileRequest : AmazonSignerRequest
    {
        private string _profileName;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the signing profile to be canceled.
        /// </para>
        /// </summary>
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

    }
}