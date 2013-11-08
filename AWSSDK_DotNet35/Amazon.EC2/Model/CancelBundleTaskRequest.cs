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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CancelBundleTask operation.
    /// <para> CancelBundleTask operation cancels a pending or in-progress bundling task. This is an asynchronous call and it make take a while for
    /// the task to be canceled. If a task is canceled while it is storing items, there may be parts of the incomplete AMI stored in S3. It is up to
    /// the caller to clean up these parts from S3. </para>
    /// </summary>
    public partial class CancelBundleTaskRequest : AmazonEC2Request
    {
        private string bundleId;


        /// <summary>
        /// The ID of the bundle task to cancel.
        ///  
        /// </summary>
        public string BundleId
        {
            get { return this.bundleId; }
            set { this.bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this.bundleId != null;
        }

    }
}
    
