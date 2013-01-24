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

namespace Amazon.CloudFront.Model
{
    /// <summary>Cookie Preference
    /// </summary>
    public class CookiePreference  
    {
        
        private string forward;
        private CookieNames whitelistedNames;
        public string Forward
        {
            get { return this.forward; }
            set { this.forward = value; }
        }

        /// <summary>
        /// Sets the Forward property
        /// </summary>
        /// <param name="forward">The value to set for the Forward property </param>
        /// <returns>this instance</returns>
        public CookiePreference WithForward(string forward)
        {
            this.forward = forward;
            return this;
        }
            

        // Check to see if Forward property is set
        internal bool IsSetForward()
        {
            return this.forward != null;       
        }
        public CookieNames WhitelistedNames
        {
            get { return this.whitelistedNames; }
            set { this.whitelistedNames = value; }
        }

        /// <summary>
        /// Sets the WhitelistedNames property
        /// </summary>
        /// <param name="whitelistedNames">The value to set for the WhitelistedNames property </param>
        /// <returns>this instance</returns>
        public CookiePreference WithWhitelistedNames(CookieNames whitelistedNames)
        {
            this.whitelistedNames = whitelistedNames;
            return this;
        }
            

        // Check to see if WhitelistedNames property is set
        internal bool IsSetWhitelistedNames()
        {
            return this.whitelistedNames != null;       
        }
    }
}
