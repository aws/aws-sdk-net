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
    /// An object that defines the Key element of a ProfileObject. A Key is a special element
    /// that can be used to search for a customer profile.
    /// </summary>
    public partial class ObjectTypeKey
    {
        private List<string> _fieldNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _standardIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FieldNames. 
        /// <para>
        /// The reference for the key name of the fields map.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> FieldNames
        {
            get { return this._fieldNames; }
            set { this._fieldNames = value; }
        }

        // Check to see if FieldNames property is set
        internal bool IsSetFieldNames()
        {
            return this._fieldNames != null && (this._fieldNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StandardIdentifiers. 
        /// <para>
        /// The types of keys that a ProfileObject can have. Each ProfileObject can have only
        /// 1 UNIQUE key but multiple PROFILE keys. PROFILE, ASSET, CASE, or ORDER means that
        /// this key can be used to tie an object to a PROFILE, ASSET, CASE, or ORDER respectively.
        /// UNIQUE means that it can be used to uniquely identify an object. If a key a is marked
        /// as SECONDARY, it will be used to search for profiles after all other PROFILE keys
        /// have been searched. A LOOKUP_ONLY key is only used to match a profile but is not persisted
        /// to be used for searching of the profile. A NEW_ONLY key is only used if the profile
        /// does not already exist before the object is ingested, otherwise it is only used for
        /// matching objects to profiles.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> StandardIdentifiers
        {
            get { return this._standardIdentifiers; }
            set { this._standardIdentifiers = value; }
        }

        // Check to see if StandardIdentifiers property is set
        internal bool IsSetStandardIdentifiers()
        {
            return this._standardIdentifiers != null && (this._standardIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}