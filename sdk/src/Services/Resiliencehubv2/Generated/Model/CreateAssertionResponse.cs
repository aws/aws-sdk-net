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
    /// This is the response object from the CreateAssertion operation.
    /// </summary>
    public partial class CreateAssertionResponse : AmazonWebServiceResponse
    {
        private Assertion _assertion;

        /// <summary>
        /// Gets and sets the property Assertion. 
        /// <para>
        /// The created assertion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Assertion Assertion
        {
            get { return this._assertion; }
            set { this._assertion = value; }
        }

        // Check to see if Assertion property is set
        internal bool IsSetAssertion()
        {
            return this._assertion != null;
        }

    }
}