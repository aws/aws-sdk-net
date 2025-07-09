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
    /// This is the response object from the GetCloudExadataInfrastructure operation.
    /// </summary>
    public partial class GetCloudExadataInfrastructureResponse : AmazonWebServiceResponse
    {
        private CloudExadataInfrastructure _cloudExadataInfrastructure;

        /// <summary>
        /// Gets and sets the property CloudExadataInfrastructure. 
        /// <para>
        /// The Exadata infrastructure.
        /// </para>
        /// </summary>
        public CloudExadataInfrastructure CloudExadataInfrastructure
        {
            get { return this._cloudExadataInfrastructure; }
            set { this._cloudExadataInfrastructure = value; }
        }

        // Check to see if CloudExadataInfrastructure property is set
        internal bool IsSetCloudExadataInfrastructure()
        {
            return this._cloudExadataInfrastructure != null;
        }

    }
}