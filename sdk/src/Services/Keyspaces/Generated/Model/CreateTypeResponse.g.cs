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

namespace Amazon.Keyspaces.Model
{
    /// <summary>
    /// This is the response object from the CreateType operation.
    /// </summary>
    public partial class CreateTypeResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KeyspaceArn. 
        /// <para>
        ///  The unique identifier of the keyspace that contains the new type in the format of
        /// an Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1000)]
        public string KeyspaceArn { get; set; }

        /// <summary>
        /// Checks to see if the KeyspaceArn property is set.
        /// </summary>
        internal bool IsSetKeyspaceArn() => this.KeyspaceArn != null;

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        ///  The formatted name of the user-defined type that was created. Note that Amazon Keyspaces
        /// requires the formatted name of the type for other operations, for example <c>GetType</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 48)]
        public string TypeName { get; set; }

        /// <summary>
        /// Checks to see if the TypeName property is set.
        /// </summary>
        internal bool IsSetTypeName() => this.TypeName != null;
    }
}
