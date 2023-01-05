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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCustomLogSource operation.
    /// Removes a custom log source from Amazon Security Lake.
    /// </summary>
    public partial class DeleteCustomLogSourceRequest : AmazonSecurityLakeRequest
    {
        private string _customSourceName;

        /// <summary>
        /// Gets and sets the property CustomSourceName. 
        /// <para>
        /// The custom source name for the custom log source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CustomSourceName
        {
            get { return this._customSourceName; }
            set { this._customSourceName = value; }
        }

        // Check to see if CustomSourceName property is set
        internal bool IsSetCustomSourceName()
        {
            return this._customSourceName != null;
        }

    }
}