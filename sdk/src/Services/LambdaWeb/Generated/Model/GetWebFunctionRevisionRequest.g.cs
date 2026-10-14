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

namespace Amazon.LambdaWeb.Model
{
    /// <summary>
    /// Container for the parameters to the GetWebFunctionRevision operation. Retrieves details
    /// about a web function revision, including its state and configuration.
    /// </summary>
    public partial class GetWebFunctionRevisionRequest : AmazonLambdaWebRequest
    {
        /// <summary>
        /// Gets and sets the property FunctionName. 
        /// <para>
        /// The web function.
        /// </para>
        ///  
        /// <para>
        /// You can specify either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The function name, for example <c>my-function</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The function ARN.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN. If you specify only the function
        /// name, it is limited to 64 characters in length.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FunctionName { get; set; }

        /// <summary>
        /// Checks to see if the FunctionName property is set.
        /// </summary>
        internal bool IsSetFunctionName() => this.FunctionName != null;

        /// <summary>
        /// Gets and sets the property RevisionId. 
        /// <para>
        /// The revision to retrieve.
        /// </para>
        ///  
        /// <para>
        /// You can specify either of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The revision identifier.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The revision ARN.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The length constraint applies only to the full ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string RevisionId { get; set; }

        /// <summary>
        /// Checks to see if the RevisionId property is set.
        /// </summary>
        internal bool IsSetRevisionId() => this.RevisionId != null;
    }
}
