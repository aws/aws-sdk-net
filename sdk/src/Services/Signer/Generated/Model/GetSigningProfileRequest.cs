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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
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
namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the GetSigningProfile operation.
    /// Returns information on a specific signing profile.
    /// </summary>
    public partial class GetSigningProfileRequest : AmazonSignerRequest
    {
        private string _profileName;
        private string _profileOwner;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the target signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=64)]
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

        /// <summary>
        /// Gets and sets the property ProfileOwner. 
        /// <para>
        /// The AWS account ID of the profile owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string ProfileOwner
        {
            get { return this._profileOwner; }
            set { this._profileOwner = value; }
        }

        // Check to see if ProfileOwner property is set
        internal bool IsSetProfileOwner()
        {
            return this._profileOwner != null;
        }

    }
}