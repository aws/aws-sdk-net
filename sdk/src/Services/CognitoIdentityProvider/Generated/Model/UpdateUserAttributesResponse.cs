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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Represents the response from the server for the request to update user attributes.
    /// </summary>
    public partial class UpdateUserAttributesResponse : AmazonWebServiceResponse
    {
        private List<CodeDeliveryDetailsType> _codeDeliveryDetailsList = AWSConfigs.InitializeCollections ? new List<CodeDeliveryDetailsType>() : null;

        /// <summary>
        /// Gets and sets the property CodeDeliveryDetailsList. 
        /// <para>
        /// When the attribute-update request includes an email address or phone number attribute,
        /// Amazon Cognito sends a message to users with a code that confirms ownership of the
        /// new value that they entered. The <c>CodeDeliveryDetails</c> object is information
        /// about the delivery destination for that link or code. This behavior happens in user
        /// pools configured to automatically verify changes to those attributes. For more information,
        /// see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/signing-up-users-in-your-app.html#verifying-when-users-change-their-email-or-phone-number">Verifying
        /// when users change their email or phone number</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodeDeliveryDetailsType> CodeDeliveryDetailsList
        {
            get { return this._codeDeliveryDetailsList; }
            set { this._codeDeliveryDetailsList = value; }
        }

        // Check to see if CodeDeliveryDetailsList property is set
        internal bool IsSetCodeDeliveryDetailsList()
        {
            return this._codeDeliveryDetailsList != null && (this._codeDeliveryDetailsList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}