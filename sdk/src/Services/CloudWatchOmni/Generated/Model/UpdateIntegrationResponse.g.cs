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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// This is the response object from the UpdateIntegration operation.
    /// </summary>
    public partial class UpdateIntegrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property Integration. The details of the updated integration. This
        /// is the same object returned by GetIntegration and CreateIntegration. Populated on
        /// a successful update; absent only if the post-update read-back of the resource did
        /// not complete.
        /// </summary>
        public Integration Integration { get; set; }

        /// <summary>
        /// Checks to see if the Integration property is set.
        /// </summary>
        internal bool IsSetIntegration() => this.Integration != null;
    }
}
