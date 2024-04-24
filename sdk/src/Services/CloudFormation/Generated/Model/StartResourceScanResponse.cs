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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// This is the response object from the StartResourceScan operation.
    /// </summary>
    public partial class StartResourceScanResponse : AmazonWebServiceResponse
    {
        private string _resourceScanId;

        /// <summary>
        /// Gets and sets the property ResourceScanId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the resource scan. The format is <c>arn:${Partition}:cloudformation:${Region}:${Account}:resourceScan/${Id}</c>.
        /// An example is <c>arn:aws:cloudformation:<i>us-east-1</i>:<i>123456789012</i>:resourceScan/<i>f5b490f7-7ed4-428a-aa06-31ff25db0772</i>
        /// </c>.
        /// </para>
        /// </summary>
        public string ResourceScanId
        {
            get { return this._resourceScanId; }
            set { this._resourceScanId = value; }
        }

        // Check to see if ResourceScanId property is set
        internal bool IsSetResourceScanId()
        {
            return this._resourceScanId != null;
        }

    }
}