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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
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
namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Describes the backend properties associated with an Amplify <c>Branch</c>.
    /// </summary>
    public partial class Backend
    {
        private string _stackArn;

        /// <summary>
        /// Gets and sets the property StackArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the CloudFormation stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string StackArn
        {
            get { return this._stackArn; }
            set { this._stackArn = value; }
        }

        // Check to see if StackArn property is set
        internal bool IsSetStackArn()
        {
            return this._stackArn != null;
        }

    }
}