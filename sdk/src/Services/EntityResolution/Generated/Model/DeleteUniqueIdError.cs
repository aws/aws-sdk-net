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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// The error information provided when the delete unique ID operation doesn't complete.
    /// </summary>
    public partial class DeleteUniqueIdError
    {
        private DeleteUniqueIdErrorType _errorType;
        private string _uniqueId;

        /// <summary>
        /// Gets and sets the property ErrorType. 
        /// <para>
        ///  The error type for the delete unique ID operation.
        /// </para>
        ///  
        /// <para>
        /// The <c>SERVICE_ERROR</c> value indicates that an internal service-side problem occurred
        /// during the deletion operation.
        /// </para>
        ///  
        /// <para>
        /// The <c>VALIDATION_ERROR</c> value indicates that the deletion operation couldn't complete
        /// because of invalid input parameters or data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DeleteUniqueIdErrorType ErrorType
        {
            get { return this._errorType; }
            set { this._errorType = value; }
        }

        // Check to see if ErrorType property is set
        internal bool IsSetErrorType()
        {
            return this._errorType != null;
        }

        /// <summary>
        /// Gets and sets the property UniqueId. 
        /// <para>
        /// The unique ID that couldn't be deleted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=780)]
        public string UniqueId
        {
            get { return this._uniqueId; }
            set { this._uniqueId = value; }
        }

        // Check to see if UniqueId property is set
        internal bool IsSetUniqueId()
        {
            return this._uniqueId != null;
        }

    }
}