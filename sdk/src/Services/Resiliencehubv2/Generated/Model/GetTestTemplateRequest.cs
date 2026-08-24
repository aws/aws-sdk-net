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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Container for the parameters to the GetTestTemplate operation.
    /// Retrieves a resilience test template by ARN, including the parameters it accepts and
    /// the fault actions it runs.
    /// </summary>
    public partial class GetTestTemplateRequest : AmazonResiliencehubv2Request
    {
        private string _testTemplateArn;

        /// <summary>
        /// Gets and sets the property TestTemplateArn. 
        /// <para>
        /// The ARN of the test template to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string TestTemplateArn
        {
            get { return this._testTemplateArn; }
            set { this._testTemplateArn = value; }
        }

        // Check to see if TestTemplateArn property is set
        internal bool IsSetTestTemplateArn()
        {
            return this._testTemplateArn != null;
        }

    }
}