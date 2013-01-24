/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the GetLoginProfile action.</para>
    /// </summary>
    public class GetLoginProfileResult  
    {
        
        private LoginProfile loginProfile;

        /// <summary>
        /// User name and password create date for the user.
        ///  
        /// </summary>
        public LoginProfile LoginProfile
        {
            get { return this.loginProfile; }
            set { this.loginProfile = value; }
        }

        /// <summary>
        /// Sets the LoginProfile property
        /// </summary>
        /// <param name="loginProfile">The value to set for the LoginProfile property </param>
        /// <returns>this instance</returns>
        public GetLoginProfileResult WithLoginProfile(LoginProfile loginProfile)
        {
            this.loginProfile = loginProfile;
            return this;
        }
            

        // Check to see if LoginProfile property is set
        internal bool IsSetLoginProfile()
        {
            return this.loginProfile != null;       
        }
    }
}
