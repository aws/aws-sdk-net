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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
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
namespace Amazon.Proton.Model
{
    /// <summary>
    /// This is the response object from the ListServiceTemplateVersions operation.
    /// </summary>
    public partial class ListServiceTemplateVersionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ServiceTemplateVersionSummary> _templateVersions = AWSConfigs.InitializeCollections ? new List<ServiceTemplateVersionSummary>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates the location of the next major or minor version in the array
        /// of major or minor versions of a service template, after the current requested list
        /// of service major or minor versions.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateVersions. 
        /// <para>
        /// An array of major or minor versions of a service template with detail data.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ServiceTemplateVersionSummary> TemplateVersions
        {
            get { return this._templateVersions; }
            set { this._templateVersions = value; }
        }

        // Check to see if TemplateVersions property is set
        internal bool IsSetTemplateVersions()
        {
            return this._templateVersions != null && (this._templateVersions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}