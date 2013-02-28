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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <para>A complex type containing the response information for the request.</para>
    /// </summary>
    public class DeleteHostedZoneResult
    {
        
        private ChangeInfo changeInfo;

        /// <summary>
        /// A complex type that contains the ID, the status, and the date and time of your delete request.
        ///  
        /// </summary>
        public ChangeInfo ChangeInfo
        {
            get { return this.changeInfo; }
            set { this.changeInfo = value; }
        }

        /// <summary>
        /// Sets the ChangeInfo property
        /// </summary>
        /// <param name="changeInfo">The value to set for the ChangeInfo property </param>
        /// <returns>this instance</returns>
        public DeleteHostedZoneResult WithChangeInfo(ChangeInfo changeInfo)
        {
            this.changeInfo = changeInfo;
            return this;
        }
            

        // Check to see if ChangeInfo property is set
        internal bool IsSetChangeInfo()
        {
            return this.changeInfo != null;
        }
    }
}
