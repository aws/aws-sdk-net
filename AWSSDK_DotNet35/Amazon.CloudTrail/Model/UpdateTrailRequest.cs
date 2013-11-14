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
    /// Container for the parameters to the UpdateTrail operation.
    /// <para>From the command line, use update-subscription.</para> <para>Updates the settings that specify delivery of log files. Changes to a
    /// trail do not require stopping the CloudTrail service. You use this action to designate an existing bucket for log delivery. If the existing
    /// bucket has previously been a target for CloudTrail log files, an IAM policy exists for the bucket. Use a Trail data type to pass updated
    /// bucket or topic names.</para>
    /// </summary>
    public partial class UpdateTrailRequest : AmazonCloudTrailRequest
    {
        private Trail trail;


        /// <summary>
        /// Represents the <a>Trail</a> structure that contains the CloudTrail setting for an account.
        ///  
        /// </summary>
        public Trail Trail
        {
            get { return this.trail; }
            set { this.trail = value; }
        }

        // Check to see if Trail property is set
        internal bool IsSetTrail()
        {
            return this.trail != null;
        }

    }
}
    
