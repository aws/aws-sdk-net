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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
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
    /// This is the response object from the DeleteType operation.
    /// </summary>
    public partial class DeleteTypeResponse : AmazonWebServiceResponse
    {
        private string _keyspaceArn;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property KeyspaceArn. 
        /// <para>
        ///  The unique identifier of the keyspace from which the type was deleted in the format
        /// of an Amazon Resource Name (ARN). 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1000)]
        public string KeyspaceArn
        {
            get { return this._keyspaceArn; }
            set { this._keyspaceArn = value; }
        }

        // Check to see if KeyspaceArn property is set
        internal bool IsSetKeyspaceArn()
        {
            return this._keyspaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        ///  The name of the type that was deleted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}