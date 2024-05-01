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
 * Do not modify this file. This file is generated from the customer-profiles-2020-08-15.normal.json service model.
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
namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// Container for the parameters to the PutProfileObject operation.
    /// Adds additional objects to customer profiles of a given ObjectType.
    /// 
    ///  
    /// <para>
    /// When adding a specific profile object, like a Contact Record, an inferred profile
    /// can get created if it is not mapped to an existing profile. The resulting profile
    /// will only have a phone number populated in the standard ProfileObject. Any additional
    /// Contact Records with the same phone number will be mapped to the same inferred profile.
    /// </para>
    ///  
    /// <para>
    /// When a ProfileObject is created and if a ProfileObjectType already exists for the
    /// ProfileObject, it will provide data to a standard profile depending on the ProfileObjectType
    /// definition.
    /// </para>
    ///  
    /// <para>
    /// PutProfileObject needs an ObjectType, which can be created using PutProfileObjectType.
    /// </para>
    /// </summary>
    public partial class PutProfileObjectRequest : AmazonCustomerProfilesRequest
    {
        private string _domainName;
        private string _object;
        private string _objectTypeName;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The unique name of the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property Object. 
        /// <para>
        /// A string that is serialized from a JSON object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256000)]
        public string Object
        {
            get { return this._object; }
            set { this._object = value; }
        }

        // Check to see if Object property is set
        internal bool IsSetObject()
        {
            return this._object != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectTypeName. 
        /// <para>
        /// The name of the profile object type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ObjectTypeName
        {
            get { return this._objectTypeName; }
            set { this._objectTypeName = value; }
        }

        // Check to see if ObjectTypeName property is set
        internal bool IsSetObjectTypeName()
        {
            return this._objectTypeName != null;
        }

    }
}