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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains the results for the <a>CreateComputer</a> operation.
    /// </summary>
    public partial class CreateComputerResponse : AmazonWebServiceResponse
    {
        private Computer _computer;

        /// <summary>
        /// Gets and sets the property Computer. 
        /// <para>
        /// A <a>Computer</a> object that represents the computer account.
        /// </para>
        /// </summary>
        public Computer Computer
        {
            get { return this._computer; }
            set { this._computer = value; }
        }

        // Check to see if Computer property is set
        internal bool IsSetComputer()
        {
            return this._computer != null;
        }

    }
}