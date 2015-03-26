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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeMyUserProfile</code> request.
    /// </summary>
    public partial class DescribeMyUserProfileResponse : AmazonWebServiceResponse
    {
        private SelfUserProfile _userProfile;

        /// <summary>
        /// Gets and sets the property UserProfile. 
        /// <para>
        /// A <code>UserProfile</code> object that describes the user's SSH information.
        /// </para>
        /// </summary>
        public SelfUserProfile UserProfile
        {
            get { return this._userProfile; }
            set { this._userProfile = value; }
        }

        // Check to see if UserProfile property is set
        internal bool IsSetUserProfile()
        {
            return this._userProfile != null;
        }

    }
}