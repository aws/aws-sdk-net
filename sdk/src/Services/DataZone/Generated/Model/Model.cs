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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The model of the API.
    /// </summary>
    public partial class Model
    {
        private string _smithy;

        /// <summary>
        /// Gets and sets the property Smithy. 
        /// <para>
        /// Indicates the smithy model of the API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public string Smithy
        {
            get { return this._smithy; }
            set { this._smithy = value; }
        }

        // Check to see if Smithy property is set
        internal bool IsSetSmithy()
        {
            return this._smithy != null;
        }

    }
}