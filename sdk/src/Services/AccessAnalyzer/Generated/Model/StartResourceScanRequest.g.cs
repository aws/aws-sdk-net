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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// Container for the parameters to the StartResourceScan operation. Immediately starts
    /// a scan of the policies applied to the specified resource. <note> <para> This action
    /// is supported only for external access analyzers. </para> </note>
    /// </summary>
    public partial class StartResourceScanRequest : AmazonAccessAnalyzerRequest
    {
        /// <summary>
        /// Gets and sets the property AnalyzerArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access-analyzer-getting-started.html#permission-resources">ARN
        /// of the analyzer</a> to use to scan the policies applied to the specified resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AnalyzerArn { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzerArn property is set.
        /// </summary>
        internal bool IsSetAnalyzerArn() => this.AnalyzerArn != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The ARN of the resource to scan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerAccount. 
        /// <para>
        /// The Amazon Web Services account ID that owns the resource. For most Amazon Web Services
        /// resources, the owning account is the account in which the resource was created.
        /// </para>
        /// </summary>
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerAccount property is set.
        /// </summary>
        internal bool IsSetResourceOwnerAccount() => this.ResourceOwnerAccount != null;
    }
}
