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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// This is the response object from the ListIntegrationResourceProperties operation.
    /// </summary>
    public partial class ListIntegrationResourcePropertiesResponse : AmazonWebServiceResponse
    {
        private List<IntegrationResourceProperty> _integrationResourcePropertyList = AWSConfigs.InitializeCollections ? new List<IntegrationResourceProperty>() : null;
        private string _marker;

        /// <summary>
        /// Gets and sets the property IntegrationResourcePropertyList. 
        /// <para>
        /// A list of integration resource property meeting the filter criteria.
        /// </para>
        /// </summary>
        public List<IntegrationResourceProperty> IntegrationResourcePropertyList
        {
            get { return this._integrationResourcePropertyList; }
            set { this._integrationResourcePropertyList = value; }
        }

        // Check to see if IntegrationResourcePropertyList property is set
        internal bool IsSetIntegrationResourcePropertyList()
        {
            return this._integrationResourcePropertyList != null && (this._integrationResourcePropertyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// This is the pagination token for the next page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

    }
}