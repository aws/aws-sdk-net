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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCidrCollection operation. Creates a CIDR
    /// collection in the current Amazon Web Services account.
    /// </summary>
    public partial class CreateCidrCollectionRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A unique identifier for the account that can be used to reference the collection from
        /// other API calls.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A client-specific token that allows requests to be securely retried so that the intended
        /// outcome will only occur once, retries receive a similar response, and there are no
        /// additional edge cases to handle.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CallerReference { get; set; }

        /// <summary>
        /// Checks to see if the CallerReference property is set.
        /// </summary>
        internal bool IsSetCallerReference() => this.CallerReference != null;
    }
}
