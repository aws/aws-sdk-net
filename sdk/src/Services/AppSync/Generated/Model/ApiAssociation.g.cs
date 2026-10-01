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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ApiId. 
        /// <para>
        /// The API ID.
        /// </para>
        /// </summary>
        public string ApiId { get; set; }

        /// <summary>
        /// Checks to see if the ApiId property is set.
        /// </summary>
        internal bool IsSetApiId() => this.ApiId != null;

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
        public AssociationStatus AssociationStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssociationStatus property is set.
        /// </summary>
        internal bool IsSetAssociationStatus() => this.AssociationStatus != null;

        /// <summary>
        /// Gets and sets the property DeploymentDetail. 
        /// <para>
        /// Details about the last deployment status.
        /// </para>
        /// </summary>
        public string DeploymentDetail { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentDetail property is set.
        /// </summary>
        internal bool IsSetDeploymentDetail() => this.DeploymentDetail != null;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 253)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;
    }
}
