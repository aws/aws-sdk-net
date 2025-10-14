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
 * Do not modify this file. This file is generated from the appstream-2016-12-01.normal.json service model.
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
namespace Amazon.AppStream.Model
{
    /// <summary>
    /// This is the response object from the DescribeSoftwareAssociations operation.
    /// </summary>
    public partial class DescribeSoftwareAssociationsResponse : AmazonWebServiceResponse
    {
        private string _associatedResource;
        private string _nextToken;
        private List<SoftwareAssociations> _softwareAssociations = AWSConfigs.InitializeCollections ? new List<SoftwareAssociations>() : null;

        /// <summary>
        /// Gets and sets the property AssociatedResource. 
        /// <para>
        /// The ARN of the resource to describe software associations.
        /// </para>
        /// </summary>
        public string AssociatedResource
        {
            get { return this._associatedResource; }
            set { this._associatedResource = value; }
        }

        // Check to see if AssociatedResource property is set
        internal bool IsSetAssociatedResource()
        {
            return this._associatedResource != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token to use to retrieve the next page of results for this operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property SoftwareAssociations. 
        /// <para>
        /// Collection of license included applications association details including:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// License included application name and version information
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deployment status (SoftwareDeploymentStatus enum)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Error details for failed deployments
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Association timestamps
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<SoftwareAssociations> SoftwareAssociations
        {
            get { return this._softwareAssociations; }
            set { this._softwareAssociations = value; }
        }

        // Check to see if SoftwareAssociations property is set
        internal bool IsSetSoftwareAssociations()
        {
            return this._softwareAssociations != null && (this._softwareAssociations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}