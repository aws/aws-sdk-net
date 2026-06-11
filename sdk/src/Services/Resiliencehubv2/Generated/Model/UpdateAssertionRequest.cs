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
    /// Container for the parameters to the UpdateAssertion operation.
    /// Updates a resilience assertion.
    /// </summary>
    public partial class UpdateAssertionRequest : AmazonResiliencehubv2Request
    {
        private string _assertionId;
        private string _serviceArn;
        private string _text;

        /// <summary>
        /// Gets and sets the property AssertionId. 
        /// <para>
        /// The unique identifier of the assertion to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssertionId
        {
            get { return this._assertionId; }
            set { this._assertionId = value; }
        }

        // Check to see if AssertionId property is set
        internal bool IsSetAssertionId()
        {
            return this._assertionId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Required=true, Min=31)]
        public string ServiceArn
        {
            get { return this._serviceArn; }
            set { this._serviceArn = value; }
        }

        // Check to see if ServiceArn property is set
        internal bool IsSetServiceArn()
        {
            return this._serviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The updated text content of the assertion.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

    }
}