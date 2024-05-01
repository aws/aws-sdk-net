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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
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
namespace Amazon.ECRPublic.Model
{
    /// <summary>
    /// This is the response object from the GetRegistryCatalogData operation.
    /// </summary>
    public partial class GetRegistryCatalogDataResponse : AmazonWebServiceResponse
    {
        private RegistryCatalogData _registryCatalogData;

        /// <summary>
        /// Gets and sets the property RegistryCatalogData. 
        /// <para>
        /// The catalog metadata for the public registry.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegistryCatalogData RegistryCatalogData
        {
            get { return this._registryCatalogData; }
            set { this._registryCatalogData = value; }
        }

        // Check to see if RegistryCatalogData property is set
        internal bool IsSetRegistryCatalogData()
        {
            return this._registryCatalogData != null;
        }

    }
}