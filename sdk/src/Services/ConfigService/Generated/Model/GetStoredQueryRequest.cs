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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the GetStoredQuery operation.
    /// Returns the details of a specific stored query.
    /// </summary>
    public partial class GetStoredQueryRequest : AmazonConfigServiceRequest
    {
        private string _queryName;

        /// <summary>
        /// Gets and sets the property QueryName. 
        /// <para>
        /// The name of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string QueryName
        {
            get { return this._queryName; }
            set { this._queryName = value; }
        }

        // Check to see if QueryName property is set
        internal bool IsSetQueryName()
        {
            return this._queryName != null;
        }

    }
}