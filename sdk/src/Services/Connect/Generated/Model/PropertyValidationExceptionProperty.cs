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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Contains information about why a property is not valid.
    /// </summary>
    public partial class PropertyValidationExceptionProperty
    {
        private string _message;
        private string _propertyPath;
        private PropertyValidationExceptionReason _reason;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A message describing why the property is not valid.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyPath. 
        /// <para>
        /// The full property path.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PropertyPath
        {
            get { return this._propertyPath; }
            set { this._propertyPath = value; }
        }

        // Check to see if PropertyPath property is set
        internal bool IsSetPropertyPath()
        {
            return this._propertyPath != null;
        }

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// Why the property is not valid.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PropertyValidationExceptionReason Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

    }
}