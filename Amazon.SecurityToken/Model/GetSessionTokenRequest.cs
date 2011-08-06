/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the GetSessionToken operation.
    /// 
    /// </summary>
    /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.GetSessionToken"/>
    public class GetSessionTokenRequest : AmazonWebServiceRequest
    {
        private int? durationSeconds;
        public int DurationSeconds
        {
            get { return this.durationSeconds ?? default(int); }
            set { this.durationSeconds = value; }
        }

        /// <summary>
        /// Sets the DurationSeconds property
        /// </summary>
        /// <param name="durationSeconds">The value to set for the DurationSeconds property </param>
        /// <returns>this instance</returns>
        public GetSessionTokenRequest WithDurationSeconds(int durationSeconds)
        {
            this.durationSeconds = durationSeconds;
            return this;
        }
            

        // Check to see if DurationSeconds property is set
        internal bool IsSetDurationSeconds()
        {
            return this.durationSeconds.HasValue;       
        }
    }
}
    
