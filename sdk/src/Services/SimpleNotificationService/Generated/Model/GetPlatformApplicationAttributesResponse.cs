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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Response for <c>GetPlatformApplicationAttributes</c> action.
    /// </summary>
    public partial class GetPlatformApplicationAttributesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// Attributes include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AppleCertificateExpiryDate</c> – The expiry date of the SSL certificate used to
        /// configure certificate-based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApplePlatformTeamID</c> – The Apple developer account ID used to configure token-based
        /// authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ApplePlatformBundleID</c> – The app identifier used to configure token-based authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AuthenticationMethod</c> – Returns the credential type used when sending push
        /// notifications from application to APNS/APNS_Sandbox, or application to GCM.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// APNS – Returns the token or certificate.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GCM – Returns the token or key.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  <c>EventEndpointCreated</c> – Topic ARN to which EndpointCreated event notifications
        /// should be sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EventEndpointDeleted</c> – Topic ARN to which EndpointDeleted event notifications
        /// should be sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EventEndpointUpdated</c> – Topic ARN to which EndpointUpdate event notifications
        /// should be sent.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EventDeliveryFailure</c> – Topic ARN to which DeliveryFailure event notifications
        /// should be sent upon Direct Publish delivery failure (permanent) to one of the application's
        /// endpoints.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}