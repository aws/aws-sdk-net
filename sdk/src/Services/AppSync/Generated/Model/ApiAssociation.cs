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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// Describes an <c>ApiAssociation</c> object.
    /// </summary>
    public partial class ApiAssociation
    {
        private string _apiId;
        private AssociationStatus _associationStatus;
        private string _deploymentDetail;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID.
        /// </para>
        /// </summary>
        public string ApiId
        {
            get { return this._apiId; }
            set { this._apiId = value; }
        }

        // Check to see if ApiId property is set
        internal bool IsSetApiId()
        {
            return this._apiId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationStatus. 
        /// <para>
        /// Identifies the status of an association.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>PROCESSING</b>: The API association is being created. You cannot modify association
        /// requests during processing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>SUCCESS</b>: The API association was successful. You can modify associations after
        /// success.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b>: The API association has failed. You can modify associations after
        /// failure.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AssociationStatus AssociationStatus
        {
            get { return this._associationStatus; }
            set { this._associationStatus = value; }
        }

        // Check to see if AssociationStatus property is set
        internal bool IsSetAssociationStatus()
        {
            return this._associationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentDetail. 
        /// <para>
        /// Details about the last deployment status.
        /// </para>
        /// </summary>
        public string DeploymentDetail
        {
            get { return this._deploymentDetail; }
            set { this._deploymentDetail = value; }
        }

        // Check to see if DeploymentDetail property is set
        internal bool IsSetDeploymentDetail()
        {
            return this._deploymentDetail != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=253)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

    }
}