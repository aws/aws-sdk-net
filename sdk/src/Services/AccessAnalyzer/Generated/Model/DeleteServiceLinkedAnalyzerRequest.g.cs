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
    /// Container for the parameters to the DeleteServiceLinkedAnalyzer operation. Deletes
    /// a service-linked analyzer. This operation can be invoked by both authorized Amazon
    /// Web Services services and customers. <para> When invoked by a customer, IAM Access
    /// Analyzer performs a callback to the managing service to verify whether the analyzer
    /// is still in use and can be deleted. If the service indicates the analyzer is still
    /// in use, the deletion is rejected with <c>ConflictException</c>. </para>
    /// </summary>
    public partial class DeleteServiceLinkedAnalyzerRequest : AmazonAccessAnalyzerRequest
    {
        /// <summary>
        /// Gets and sets the property AnalyzerName. 
        /// <para>
        /// The name of the service-linked analyzer to delete. Service-linked analyzer names follow
        /// the format <c>_AccessAnalyzerFor{ServiceName}-{Id}</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string AnalyzerName { get; set; }

        /// <summary>
        /// Checks to see if the AnalyzerName property is set.
        /// </summary>
        internal bool IsSetAnalyzerName() => this.AnalyzerName != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A client token.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;
    }
}
