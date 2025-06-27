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
 * Do not modify this file. This file is generated from the rpcv2protocol-2020-07-14.normal.json service model.
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
namespace Amazon.RpcV2Protocol.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class RecursiveShapesInputOutputNested2
    {
        private string _bar;
        private RecursiveShapesInputOutputNested1 _recursiveMember;

        /// <summary>
        /// Gets and sets the property Bar.
        /// </summary>
        public string Bar
        {
            get { return this._bar; }
            set { this._bar = value; }
        }

        // Check to see if Bar property is set
        internal bool IsSetBar()
        {
            return this._bar != null;
        }

        /// <summary>
        /// Gets and sets the property RecursiveMember.
        /// </summary>
        public RecursiveShapesInputOutputNested1 RecursiveMember
        {
            get { return this._recursiveMember; }
            set { this._recursiveMember = value; }
        }

        // Check to see if RecursiveMember property is set
        internal bool IsSetRecursiveMember()
        {
            return this._recursiveMember != null;
        }

    }
}