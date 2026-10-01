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

namespace Amazon.Route53Profiles.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateProfileResourceAssociation operation. Updates
    /// the specified Route 53 Profile resourse association.
    /// </summary>
    public partial class UpdateProfileResourceAssociationRequest : AmazonRoute53ProfilesRequest
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  Name of the resource association. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 64)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ProfileResourceAssociationId. 
        /// <para>
        ///  ID of the resource association. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ProfileResourceAssociationId { get; set; }

        /// <summary>
        /// Checks to see if the ProfileResourceAssociationId property is set.
        /// </summary>
        internal bool IsSetProfileResourceAssociationId() => this.ProfileResourceAssociationId != null;

        /// <summary>
        /// Gets and sets the property ResourceProperties. 
        /// <para>
        ///  If you are adding a DNS Firewall rule group, include also a priority. The priority
        /// indicates the processing order for the rule groups, starting with the priority assinged
        /// the lowest value. 
        /// </para>
        ///  
        /// <para>
        /// The allowed values for priority are between 100 and 9900.
        /// </para>
        /// </summary>
        public string ResourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the ResourceProperties property is set.
        /// </summary>
        internal bool IsSetResourceProperties() => this.ResourceProperties != null;
    }
}
