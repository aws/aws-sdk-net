/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Container for the parameters to the CreateResourceShare operation. Create a new resource
    /// share request for MediaConvert resources with AWS Support.
    /// </summary>
    public partial class CreateResourceShareRequest : AmazonMediaConvertRequest
    {
        /// <summary>
        /// Gets and sets the property JobId. Specify MediaConvert Job ID or ARN to share
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property SupportCaseId. AWS Support case identifier
        /// </summary>
        [AWSProperty(Required = true)]
        public string SupportCaseId { get; set; }

        /// <summary>
        /// Checks to see if the SupportCaseId property is set.
        /// </summary>
        internal bool IsSetSupportCaseId() => this.SupportCaseId != null;
    }
}
