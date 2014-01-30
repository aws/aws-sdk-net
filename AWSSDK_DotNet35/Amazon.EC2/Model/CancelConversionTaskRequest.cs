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
    /// Container for the parameters to the CancelConversionTask operation.
    /// <para>Cancels an active conversion task. The task can be the import of an instance or volume. The action removes all artifacts of the
    /// conversion, including a partially uploaded volume or instance. If the conversion is complete or is in the process of transferring the final
    /// disk image, the command fails and returns an exception.</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
    /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CancelConversionTaskRequest : AmazonEC2Request
    {
        private string conversionTaskId;
        private string reasonMessage;


        /// <summary>
        /// The ID of the conversion task.
        ///  
        /// </summary>
        public string ConversionTaskId
        {
            get { return this.conversionTaskId; }
            set { this.conversionTaskId = value; }
        }

        // Check to see if ConversionTaskId property is set
        internal bool IsSetConversionTaskId()
        {
            return this.conversionTaskId != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string ReasonMessage
        {
            get { return this.reasonMessage; }
            set { this.reasonMessage = value; }
        }

        // Check to see if ReasonMessage property is set
        internal bool IsSetReasonMessage()
        {
            return this.reasonMessage != null;
        }

    }
}
    
