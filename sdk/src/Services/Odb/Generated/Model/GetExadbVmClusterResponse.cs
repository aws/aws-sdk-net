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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// This is the response object from the GetExadbVmCluster operation.
    /// </summary>
    public partial class GetExadbVmClusterResponse : AmazonWebServiceResponse
    {
        private ExadbVmCluster _exadbVmCluster;

        /// <summary>
        /// Gets and sets the property ExadbVmCluster. 
        /// <para>
        /// The Exascale VM cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExadbVmCluster ExadbVmCluster
        {
            get { return this._exadbVmCluster; }
            set { this._exadbVmCluster = value; }
        }

        // Check to see if ExadbVmCluster property is set
        internal bool IsSetExadbVmCluster()
        {
            return this._exadbVmCluster != null;
        }

    }
}