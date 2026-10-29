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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyCertificateBasedAuthProperties operation.
    /// Modifies the properties of the certificate-based authentication you want to use with
    /// your WorkSpaces.
    /// </summary>
    public partial class ModifyCertificateBasedAuthPropertiesRequest : AmazonWorkSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property CertificateBasedAuthProperties. 
        /// <para>
        /// The properties of the certificate-based authentication.
        /// </para>
        /// </summary>
        public CertificateBasedAuthProperties CertificateBasedAuthProperties { get; set; }

        /// <summary>
        /// Checks to see if the CertificateBasedAuthProperties property is set.
        /// </summary>
        internal bool IsSetCertificateBasedAuthProperties() => this.CertificateBasedAuthProperties != null;

        /// <summary>
        /// Gets and sets the property PropertiesToDelete. 
        /// <para>
        /// The properties of the certificate-based authentication you want to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PropertiesToDelete { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PropertiesToDelete property is set.
        /// </summary>
        internal bool IsSetPropertiesToDelete() => this.PropertiesToDelete != null && (this.PropertiesToDelete.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The resource identifiers, in the form of directory IDs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 65)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
