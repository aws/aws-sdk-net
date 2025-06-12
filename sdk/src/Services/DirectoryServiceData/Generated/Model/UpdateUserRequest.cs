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
 * Do not modify this file. This file is generated from the directory-service-data-2023-05-31.normal.json service model.
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
namespace Amazon.DirectoryServiceData.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateUser operation.
    /// Updates user information.
    /// </summary>
    public partial class UpdateUserRequest : AmazonDirectoryServiceDataRequest
    {
        private string _clientToken;
        private string _directoryId;
        private string _emailAddress;
        private string _givenName;
        private Dictionary<string, AttributeValue> _otherAttributes = AWSConfigs.InitializeCollections ? new Dictionary<string, AttributeValue>() : null;
        private string _samAccountName;
        private string _surname;
        private UpdateType _updateType;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique and case-sensitive identifier that you provide to make sure the idempotency
        /// of the request, so multiple identical calls have the same effect as one single call.
        /// 
        /// </para>
        ///  
        /// <para>
        ///  A client token is valid for 8 hours after the first request that uses it completes.
        /// After 8 hours, any request with the same client token is treated as a new request.
        /// If the request succeeds, any future uses of that token will be idempotent for another
        /// 8 hours. 
        /// </para>
        ///  
        /// <para>
        ///  If you submit a request with the same client token but change one of the other parameters
        /// within the 8-hour idempotency window, Directory Service Data returns an <c>ConflictException</c>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        ///  This parameter is optional when using the CLI or SDK. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        ///  The identifier (ID) of the directory that's associated with the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        ///  The email address of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property GivenName. 
        /// <para>
        ///  The first name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string GivenName
        {
            get { return this._givenName; }
            set { this._givenName = value; }
        }

        // Check to see if GivenName property is set
        internal bool IsSetGivenName()
        {
            return this._givenName != null;
        }

        /// <summary>
        /// Gets and sets the property OtherAttributes. 
        /// <para>
        ///  An expression that defines one or more attribute names with the data type and value
        /// of each attribute. A key is an attribute name, and the value is a list of maps. For
        /// a list of supported attributes, see <a href="https://docs.aws.amazon.com/directoryservice/latest/admin-guide/ad_data_attributes.html">Directory
        /// Service Data Attributes</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  Attribute names are case insensitive. 
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public Dictionary<string, AttributeValue> OtherAttributes
        {
            get { return this._otherAttributes; }
            set { this._otherAttributes = value; }
        }

        // Check to see if OtherAttributes property is set
        internal bool IsSetOtherAttributes()
        {
            return this._otherAttributes != null && (this._otherAttributes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SAMAccountName. 
        /// <para>
        ///  The name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string SAMAccountName
        {
            get { return this._samAccountName; }
            set { this._samAccountName = value; }
        }

        // Check to see if SAMAccountName property is set
        internal bool IsSetSAMAccountName()
        {
            return this._samAccountName != null;
        }

        /// <summary>
        /// Gets and sets the property Surname. 
        /// <para>
        ///  The last name of the user. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=64)]
        public string Surname
        {
            get { return this._surname; }
            set { this._surname = value; }
        }

        // Check to see if Surname property is set
        internal bool IsSetSurname()
        {
            return this._surname != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateType. 
        /// <para>
        ///  The type of update to be performed. If no value exists for the attribute, use <c>ADD</c>.
        /// Otherwise, use <c>REPLACE</c> to change an attribute value or <c>REMOVE</c> to clear
        /// the attribute value. 
        /// </para>
        /// </summary>
        public UpdateType UpdateType
        {
            get { return this._updateType; }
            set { this._updateType = value; }
        }

        // Check to see if UpdateType property is set
        internal bool IsSetUpdateType()
        {
            return this._updateType != null;
        }

    }
}