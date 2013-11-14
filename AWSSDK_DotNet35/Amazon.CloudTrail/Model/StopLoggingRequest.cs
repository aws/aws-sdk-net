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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the StopLogging operation.
    /// <para>Suspends the recording of AWS API calls and log file delivery for the specified trail. Under most circumstances, there is no need to
    /// use this action. You can update a trail without stopping it first. This action is the only way to stop recording.</para>
    /// </summary>
    public partial class StopLoggingRequest : AmazonCloudTrailRequest
    {
        private string name;


        /// <summary>
        /// Communicates to CloudTrail the name of the <a>Trail</a> for which to stop logging AWS API calls.
        ///  
        /// </summary>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this.name != null;
        }

    }
}
    
