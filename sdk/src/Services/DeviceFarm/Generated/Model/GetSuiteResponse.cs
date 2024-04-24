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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Represents the result of a get suite request.
    /// </summary>
    public partial class GetSuiteResponse : AmazonWebServiceResponse
    {
        private Suite _suite;

        /// <summary>
        /// Gets and sets the property Suite. 
        /// <para>
        /// A collection of one or more tests.
        /// </para>
        /// </summary>
        public Suite Suite
        {
            get { return this._suite; }
            set { this._suite = value; }
        }

        // Check to see if Suite property is set
        internal bool IsSetSuite()
        {
            return this._suite != null;
        }

    }
}