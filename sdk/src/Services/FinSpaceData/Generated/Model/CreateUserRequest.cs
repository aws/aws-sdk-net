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
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Container for the parameters to the CreateUser operation.
    /// Creates a new user in FinSpace.
    /// </summary>
    public partial class CreateUserRequest : AmazonFinSpaceDataRequest
    {
        private ApiAccess _apiAccess;
        private string _apiAccessPrincipalArn;
        private string _clientToken;
        private string _emailAddress;
        private string _firstName;
        private string _lastName;
        private UserType _type;

        /// <summary>
        /// Gets and sets the property ApiAccess. 
        /// <para>
        /// The option to indicate whether the user can use the <code>GetProgrammaticAccessCredentials</code>
        /// API to obtain credentials that can then be used to access other FinSpace Data API
        /// operations.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ENABLED</code> – The user has permissions to use the APIs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DISABLED</code> – The user does not have permissions to use any APIs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ApiAccess ApiAccess
        {
            get { return this._apiAccess; }
            set { this._apiAccess = value; }
        }

        // Check to see if ApiAccess property is set
        internal bool IsSetApiAccess()
        {
            return this._apiAccess != null;
        }

        /// <summary>
        /// Gets and sets the property ApiAccessPrincipalArn. 
        /// <para>
        /// The ARN identifier of an AWS user or role that is allowed to call the <code>GetProgrammaticAccessCredentials</code>
        /// API to obtain a credentials token for a specific FinSpace user. This must be an IAM
        /// role within your FinSpace account.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ApiAccessPrincipalArn
        {
            get { return this._apiAccessPrincipalArn; }
            set { this._apiAccessPrincipalArn = value; }
        }

        // Check to see if ApiAccessPrincipalArn property is set
        internal bool IsSetApiAccessPrincipalArn()
        {
            return this._apiAccessPrincipalArn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
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
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address of the user that you want to register. The email address serves
        /// as a uniquer identifier for each user and cannot be changed after it's created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=4, Max=320)]
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
        /// Gets and sets the property FirstName. 
        /// <para>
        /// The first name of the user that you want to register.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        // Check to see if FirstName property is set
        internal bool IsSetFirstName()
        {
            return this._firstName != null;
        }

        /// <summary>
        /// Gets and sets the property LastName. 
        /// <para>
        /// The last name of the user that you want to register.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=50)]
        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        // Check to see if LastName property is set
        internal bool IsSetLastName()
        {
            return this._lastName != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The option to indicate the type of user. Use one of the following options to specify
        /// this parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SUPER_USER</code> – A user with permission to all the functionality and data
        /// in FinSpace.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>APP_USER</code> – A user with specific permissions in FinSpace. The users are
        /// assigned permissions by adding them to a permission group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public UserType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}