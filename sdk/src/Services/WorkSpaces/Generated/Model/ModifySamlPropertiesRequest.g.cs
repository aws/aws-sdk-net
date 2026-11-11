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
    /// Container for the parameters to the ModifySamlProperties operation. Modifies multiple
    /// properties related to SAML 2.0 authentication, including the enablement status, user
    /// access URL, and relay state parameter name that are used for configuring federation
    /// with an SAML 2.0 identity provider.
    /// </summary>
    public partial class ModifySamlPropertiesRequest : AmazonWorkSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property PropertiesToDelete. 
        /// <para>
        /// The SAML properties to delete as part of your request.
        /// </para>
        ///  
        /// <para>
        /// Specify one of the following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SAML_PROPERTIES_USER_ACCESS_URL</c> to delete the user access URL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SAML_PROPERTIES_RELAY_STATE_PARAMETER_NAME</c> to delete the relay state parameter
        /// name.
        /// </para>
        ///  </li> </ul>
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
        /// The directory identifier for which you want to configure SAML properties.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 65)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property SamlProperties. 
        /// <para>
        /// The properties for configuring SAML 2.0 authentication.
        /// </para>
        /// </summary>
        public SamlProperties SamlProperties { get; set; }

        /// <summary>
        /// Checks to see if the SamlProperties property is set.
        /// </summary>
        internal bool IsSetSamlProperties() => this.SamlProperties != null;
    }
}
