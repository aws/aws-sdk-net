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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the DescribeJob operation.
    /// </summary>
    public partial class DescribeJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property DocumentSource. 
        /// <para>
        /// An S3 link to the job document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1350)]
        public string DocumentSource { get; set; }

        /// <summary>
        /// Checks to see if the DocumentSource property is set.
        /// </summary>
        internal bool IsSetDocumentSource() => this.DocumentSource != null;

        /// <summary>
        /// Gets and sets the property Job. 
        /// <para>
        /// Information about the job.
        /// </para>
        /// </summary>
        public Job Job { get; set; }

        /// <summary>
        /// Checks to see if the Job property is set.
        /// </summary>
        internal bool IsSetJob() => this.Job != null;
    }
}
