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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// This is the response object from the AttachObject operation.
    /// </summary>
    public partial class AttachObjectResponse : AmazonWebServiceResponse
    {
        private string _attachedObjectIdentifier;

        /// <summary>
        /// Gets and sets the property AttachedObjectIdentifier. 
        /// <para>
        /// The attached <c>ObjectIdentifier</c>, which is the child <c>ObjectIdentifier</c>.
        /// </para>
        /// </summary>
        public string AttachedObjectIdentifier
        {
            get { return this._attachedObjectIdentifier; }
            set { this._attachedObjectIdentifier = value; }
        }

        // Check to see if AttachedObjectIdentifier property is set
        internal bool IsSetAttachedObjectIdentifier()
        {
            return this._attachedObjectIdentifier != null;
        }

    }
}