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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Container for the parameters to the GetServiceView operation.
    /// Retrieves details about a specific Resource Explorer service view. This operation
    /// returns the configuration and properties of the specified view.
    /// </summary>
    public partial class GetServiceViewRequest : AmazonResourceExplorer2Request
    {
        private string _serviceViewArn;

        /// <summary>
        /// Gets and sets the property ServiceViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the service view to retrieve details for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1011)]
        public string ServiceViewArn
        {
            get { return this._serviceViewArn; }
            set { this._serviceViewArn = value; }
        }

        // Check to see if ServiceViewArn property is set
        internal bool IsSetServiceViewArn()
        {
            return this._serviceViewArn != null;
        }

    }
}