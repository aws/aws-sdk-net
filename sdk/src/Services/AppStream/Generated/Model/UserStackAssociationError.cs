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
    /// Describes the error that is returned when a user can’t be associated with or disassociated
    /// from a stack.
    /// </summary>
    public partial class UserStackAssociationError
    {
        private UserStackAssociationErrorCode _errorCode;
        private string _errorMessage;
        private UserStackAssociation _userStackAssociation;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code for the error that is returned when a user can’t be associated with
        /// or disassociated from a stack.
        /// </para>
        /// </summary>
        public UserStackAssociationErrorCode ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message for the error that is returned when a user can’t be associated with
        /// or disassociated from a stack.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UserStackAssociation. 
        /// <para>
        /// Information about the user and associated stack.
        /// </para>
        /// </summary>
        public UserStackAssociation UserStackAssociation
        {
            get { return this._userStackAssociation; }
            set { this._userStackAssociation = value; }
        }

        // Check to see if UserStackAssociation property is set
        internal bool IsSetUserStackAssociation()
        {
            return this._userStackAssociation != null;
        }

    }
}