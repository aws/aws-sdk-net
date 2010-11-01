/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Contains the result of a successful invocation of the GetUser
    /// action.</para>
    /// </summary>
    public class GetUserResult  
    {
        
        private User user;

        /// <summary>
        /// Information about the User.
        ///  
        /// </summary>
        public User User
        {
            get { return this.user; }
            set { this.user = value; }
        }

        /// <summary>
        /// Sets the User property
        /// </summary>
        /// <param name="user">The value to set for the User property </param>
        /// <returns>this instance</returns>
        public GetUserResult WithUser(User user)
        {
            this.user = user;
            return this;
        }
            
        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this.user != null;       
        }
    }
}
