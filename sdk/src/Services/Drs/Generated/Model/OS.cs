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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Operating System.
    /// </summary>
    public partial class OS
    {
        private string _fullString;

        /// <summary>
        /// Gets and sets the property FullString. 
        /// <para>
        /// The long name of the Operating System.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string FullString
        {
            get { return this._fullString; }
            set { this._fullString = value; }
        }

        // Check to see if FullString property is set
        internal bool IsSetFullString()
        {
            return this._fullString != null;
        }

    }
}